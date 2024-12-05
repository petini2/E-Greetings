using EGreetings_Project.Data;
using EGreetings_Project.Data.Seeder;
using EGreetings_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using static EGreetings_Project.Services.SendMailServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EGreetingsDbContext>(o=>o.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));
builder.Services.AddRazorPages();

builder.Services.AddIdentity<User, IdentityRole>(o=>o.SignIn.RequireConfirmedEmail=true)
    .AddEntityFrameworkStores<EGreetingsDbContext>()
    .AddDefaultTokenProviders();

// Add services to the container.
builder.Services.AddControllersWithViews();


//Setting Identity Options
builder.Services.Configure<IdentityOptions>(options =>
{

    //Setting Password
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 1;
    options.Password.RequiredUniqueChars = 1;


    //Setting User
    options.User.AllowedUserNameCharacters = "abcdefghijkmnopqrstuvwxyzABCDEFGHIJKMNOQPRSTVUWXYZ1234567890 -.@+";
    options.User.RequireUniqueEmail = true;

    //Setting Lockout
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    //Setting Login
    options.SignIn.RequireConfirmedEmail = true;
    //options.SignIn.RequireConfirmedAccount = true;
    options.SignIn.RequireConfirmedPhoneNumber = false;
});

//Setting cookie
builder.Services.ConfigureApplicationCookie(options =>
{
    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);

    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
});
//Setting time to update informations
builder.Services.Configure<SecurityStampValidatorOptions>(o =>
{
    o.ValidationInterval = TimeSpan.FromMinutes(5);
});
//Register Email
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddTransient<IEmailSender, EmailSenderService>();

//Setting time for token 
builder.Services.Configure<DataProtectionTokenProviderOptions>(o =>
{
    o.TokenLifespan = TimeSpan.FromHours(24);
});

var app = builder.Build();

//Add roles if roles not exits 
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    await RoleSeeder.SeedRolesAsync(roleManager);
}
// Add 2 user with 2 roles Admin & User
// Add 2 user with 2 roles Admin & User
using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    await UserSeeder.SeedUserAsync(userManager, roleManager);
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
