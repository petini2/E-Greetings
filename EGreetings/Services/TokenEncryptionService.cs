using System.Security.Cryptography;

namespace EGreetings.Services
{
    public class TokenCryptographyService
    {
        private readonly string key;  // Secret key for AES encryption (256 bits)
        private readonly string iv;   // Initialization vector for AES encryption (128 bits)

        // Constructor to generate random key and iv
        public TokenCryptographyService()
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.GenerateKey();  // Generate random 256-bit key
                aesAlg.GenerateIV();   // Generate random 128-bit IV

                key = Convert.ToBase64String(aesAlg.Key);  // Store key as Base64 string
                iv = Convert.ToBase64String(aesAlg.IV);    // Store iv as Base64 string
            }
        }

        // Encrypt the token using AES encryption
        public string EncryptToken(string token)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Convert.FromBase64String(key);  // Convert key from Base64 string
                aesAlg.IV = Convert.FromBase64String(iv);    // Convert iv from Base64 string
                aesAlg.Padding = PaddingMode.PKCS7; // Ensure PKCS7 padding is used

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                {
                    // Write the token into the CryptoStream which encrypts the data
                    swEncrypt.Write(token);
                    swEncrypt.Flush();  // Ensure all data is written
                    return Convert.ToBase64String(msEncrypt.ToArray());  // Return the encrypted data as a Base64 string
                }
            }
        }

        // Decrypt the token using AES decryption
        public string DecryptToken(string encryptedToken)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Convert.FromBase64String(key);  // Convert key from Base64 string
                aesAlg.IV = Convert.FromBase64String(iv);    // Convert iv from Base64 string
                aesAlg.Padding = PaddingMode.PKCS7; // Ensure PKCS7 padding is used

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedToken)))
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }
}
