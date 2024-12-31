using Azure.Storage.Blobs;
using EGreetings.Data;
using EGreetings.Data.Seeder;
using EGreetings.Models;
using EGreetings.Services;
using Hangfire;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Azure;

var builder = WebApplication.CreateBuilder(args);

// Thêm các dịch vụ cần thiết
builder.Services.AddControllers();

// Cấu hình DbContext với chuỗi kết nối từ appsettings
builder.Services.AddDbContext<EGreetingsDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"))
);

// Cấu hình Hangfire với SQL Server
builder.Services.AddHangfire(x => x.UseSqlServerStorage(builder.Configuration.GetConnectionString("ConnectionString")));
builder.Services.AddHangfireServer();  // Khởi tạo Hangfire server

// Cấu hình Identity và các tùy chọn liên quan đến người dùng
builder.Services.AddIdentity<User, IdentityRole>(options =>
    options.SignIn.RequireConfirmedEmail = true)
    .AddEntityFrameworkStores<EGreetingsDbContext>()
    .AddDefaultTokenProviders();

// Cấu hình Razor Pages và MVC controllers
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews(options =>
{
    options.Filters.AddService<CategoryDataActionFilter>();
});
builder.Services.AddHttpClient();

// Cấu hình các dịch vụ khác
builder.Services.AddLogging();

// Cấu hình cho dịch vụ bảo vệ dữ liệu
builder.Services.AddScoped<CategoryDataActionFilter>();  // Đảm bảo filter này được thêm vào

// Cấu hình Azure Blob Storage
builder.Services.Configure<AzureBlobStorageSettings>(builder.Configuration.GetSection("AzureBlobStorage"));
// Sử dụng Connection String để kết nối với Azure Blob Storage
builder.Services.AddSingleton<BlobServiceClient>(x =>
    new BlobServiceClient(builder.Configuration["AzureBlobStorage:ConnectionString"])
);


// Cấu hình MailSettings từ appsettings.json
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));

// Đăng ký các dịch vụ khác
//builder.Services.AddScoped<EmailJobServices>(); // Đăng ký EmailJobService
builder.Services.AddSingleton<IEmailSender, EmailSenderService>();  // EmailSenderService nên là Singleton nếu nó không phụ thuộc vào trạng thái yêu cầu
builder.Services.AddScoped<IEmailRepository, EmailRepository>();  // EmailRepository phải là Scoped vì nó truy cập DB
builder.Services.AddSingleton<IRecurringJobManager, RecurringJobManager>();  // RecurringJobManager có thể là Singleton
builder.Services.AddScoped<EmailSenderService>();
builder.Services.AddScoped<EmailJobServices>();  // EmailJobServices nên là Scoped vì nó phụ thuộc vào các dịch vụ Scoped
builder.Services.AddSingleton<HangfireJobConfiguration>();  // HangfireJobConfiguration có thể là Singleton
//builder.Services.AddHangfire(config =>
//{
//    // Dùng bộ nhớ để lưu trữ các công việc (thực tế bạn nên dùng cơ sở dữ liệu như SQL Server)
//    config.UseMemoryStorage();
//});
//builder.Services.AddHangfire(x => x.UseInMemoryStorage());
// Cấu hình Identity Options
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 1;
    options.Password.RequiredUniqueChars = 1;

    options.User.AllowedUserNameCharacters = "abcdefghijkmnopqrstuvwxyzABCDEFGHIJKMNOQPRSTVUWXYZ1234567890 -.@+";
    options.User.RequireUniqueEmail = true;

    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    options.SignIn.RequireConfirmedEmail = true;
    options.SignIn.RequireConfirmedPhoneNumber = false;
});

// Cấu hình Cookie Authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30); // Set the cookie expiration time
        options.LoginPath = "/Account/Login"; // Redirect to login if the user is not authenticated
        options.AccessDeniedPath = "/Account/AccessDenied"; // Redirect to access denied if the user does not have permission
        options.LogoutPath = "/Account/Logout";
    });

// Cấu hình Session
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // Secure session cookie
});

// Cấu hình Validation Interval
builder.Services.Configure<SecurityStampValidatorOptions>(options =>
{
    options.ValidationInterval = TimeSpan.FromMinutes(5);
});

// Cấu hình Token LifeSpan
builder.Services.Configure<DataProtectionTokenProviderOptions>(options =>
{
    options.TokenLifespan = TimeSpan.FromHours(24);
});

// Đăng ký IHttpContextAccessor
builder.Services.AddHttpContextAccessor();

// Đăng ký các dịch vụ của Azure (Blob, Queue, Table)
//builder.Services.AddAzureClients(clientBuilder =>
//{
//    clientBuilder.AddBlobServiceClient(builder.Configuration["StorageConnection:blobServiceUri"]!).WithName("StorageConnection");
//    //clientBuilder.AddQueueServiceClient(builder.Configuration["StorageConnection:queueServiceUri"]!).WithName("StorageConnection");
//    //clientBuilder.AddTableServiceClient(builder.Configuration["StorageConnection:tableServiceUri"]!).WithName("StorageConnection");
//});

var app = builder.Build();

// Add roles if roles don't exist
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    await RoleSeeder.SeedRolesAsync(roleManager);
}

// Add users with roles
using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    await UserSeeder.SeedUserAsync(userManager, roleManager);
}

// Apply Migration and Seed Data
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<EGreetingsDbContext>();

    // Áp dụng migration nếu cần
    // dbContext.Database.Migrate();

    // Seed dữ liệu
    CategorySeeder.Seed(dbContext);      // Gọi Seeder cho Categories
    SubsSeeder.Seed(dbContext);          // Gọi Seeder cho Subs
    TemplateSeeder.SeedTemplate(dbContext);  // Gọi Seeder cho Templates
    BookingSeeder.Seed(dbContext);       // Gọi Seeder cho Bookings
    TransactionSeeder.Seed(dbContext);   // Gọi Seeder cho Transactions
    FeedbackSeeder.Seed(dbContext);      // Gọi Seeder cho Feedbacks
    var bookingDetailsSeeder = new BookingDetailsSeeder(dbContext);
    var templateHistorySeeder = new TemplateHistorySeeder(dbContext);

    // Call the Seed methods asynchronously
    await bookingDetailsSeeder.Seed();
    await templateHistorySeeder.Seed();
}

//// Lên lịch công việc gửi email mỗi ngày lúc 00:00
//RecurringJob.AddOrUpdate<EmailJobServices>(
//    job => job.CheckAndScheduleEmails(),
//    "0 0 * * *"  // Cron expression cho việc chạy công việc vào lúc 00:00 mỗi ngày
//);
//BackgroundJob.Enqueue(() => Console.WriteLine("Hello, Hangfire!"));


// Cấu hình các pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHangfireDashboard("/hangfire");
app.UseHangfireServer();
var recurringJobManager = app.Services.GetRequiredService<IRecurringJobManager>();
var hangfireJobConfig = new HangfireJobConfiguration(recurringJobManager);
hangfireJobConfig.ConfigureRecurringJobs();  // Cấu hình các job định kỳ nếu cần

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapAreaControllerRoute(
    name: "admin",
    areaName: "Admin",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}"
);
BackgroundJob.Enqueue(() => Console.WriteLine("Hello, Hangfire!"));
app.MapRazorPages();
app.MapControllers();
app.Run();
