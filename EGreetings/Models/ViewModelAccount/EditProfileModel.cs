using System.ComponentModel.DataAnnotations;

namespace EGreetings.Models.ViewModelAccount
{
    public class EditProfileModel
    {
        [Key]
        public string Id { get; set; }
        [Required(ErrorMessage = "Username is required!")]
        [Display(Name = "Username")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 20 characters.")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Username can only contain letters and numbers.")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Phone is required!")]
        [Phone(ErrorMessage = "Invalid phone number")]
        [StringLength(10, ErrorMessage = "Password must be exactly 10 characters long.", MinimumLength = 10)]
        [Display(Name = "Phone")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Gender is required!")]
        [Display(Name = "Gender")]
        public string? Gender { get; set; }

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Date of birth is required!")]
        [DataType(DataType.Date)]
        [AgeValidation(18, 80, ErrorMessage = "Age must be between 18 and 80 years.")]
        public DateTime? Dob { get; set; }

        // Strong password validation (at least one uppercase letter, one lowercase letter, one number, and one special character)
        [Required(ErrorMessage = "Password is required!")]
        [StringLength(100, ErrorMessage = "Password must be at least 6 characters long.", MinimumLength = 6)]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$",
            ErrorMessage = "Password must be at least 6 characters long and include at least one uppercase letter, one lowercase letter, one number, and one special character.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required!")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string? ConfirmPassword { get; set; }

        [Display(Name = "Avatar Image")]
        [Required(ErrorMessage = "Avatar is required!")]
        [ValidImageExtension(allowedExtensions: new[] { ".jpg", ".jpeg", ".png" })]
        public string imgAvatar { get; set; }
        public IFormFile? newAvatar { get; set; }
        public DateTime? TokenResetPasswordCreatedDate { get; set; }
        public int? sendTimes { get; set; }
        public bool useBasic { get; set; }
        public bool useStandard { get; set; }
        public bool usePremium { get; set; }
    }

    // Custom attribute to validate file extensions
    public class ProfileFileExtensionsAttribute : ValidationAttribute
    {
        public string Extensions { get; set; }

        public ProfileFileExtensionsAttribute() { }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file == null)
            {
                return ValidationResult.Success;
            }

            var allowedExtensions = Extensions.Split(',').Select(ext => ext.Trim().ToLower()).ToArray();
            var fileExtension = Path.GetExtension(file.FileName)?.ToLower();

            if (allowedExtensions.Contains(fileExtension))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult($"File extension must be one of the following: {Extensions}");
            }
        }
    }
}


public class AgeProfileValidationAttribute : ValidationAttribute
{
    private readonly int _minAge;
    private readonly int _maxAge;

    public AgeProfileValidationAttribute(int minAge, int maxAge)
    {
        _minAge = minAge;
        _maxAge = maxAge;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return ValidationResult.Success;
        }

        // Kiểm tra độ tuổi
        DateTime birthDate = (DateTime)value;
        int age = DateTime.Now.Year - birthDate.Year;

        // Nếu ngày sinh chưa qua sinh nhật trong năm nay, giảm tuổi đi 1
        if (birthDate.Date > DateTime.Now.AddYears(-age)) age--;

        if (age < _minAge || age > _maxAge)
        {
            return new ValidationResult($"Age must be between {_minAge} and {_maxAge} years.");
        }

        return ValidationResult.Success;
    }
}
public class ProfileValidImageExtensionAttribute : ValidationAttribute
{
    private readonly string[] _allowedExtensions;

    public ProfileValidImageExtensionAttribute(string[] allowedExtensions)
    {
        _allowedExtensions = allowedExtensions;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
            if (_allowedExtensions.Contains(extension))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Only JPG, JPEG, or PNG files are allowed.");
            }
        }
        return ValidationResult.Success;
    }
}
