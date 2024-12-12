using Microsoft.AspNetCore.DataProtection;

namespace EGreetings_Project.Services
{
    public class DataProtection
    {
        private readonly IDataProtector _protector;

        public DataProtection(IDataProtectionProvider dataProtectionProvider)
        {
            // Lấy IDataProtector với một tên khóa cụ thể
            _protector = dataProtectionProvider.CreateProtector("YourAppName-Encryptor");
        }

        // Mã hóa dữ liệu
        public string Encrypt(string plaintext)
        {
            return _protector.Protect(plaintext); // Mã hóa dữ liệu
        }

        // Giải mã dữ liệu
        public string Decrypt(string encryptedText)
        {
            try
            {
                return _protector.Unprotect(encryptedText); // Giải mã dữ liệu
            }
            catch (Exception)
            {
                // Xử lý khi dữ liệu bị lỗi giải mã
                return null;
            }
        }
    }
}
