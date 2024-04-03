using System.Security.Cryptography;
using System.Text;

namespace HotelManagmentSyatem.Global_Classes
{
    public class clsEncrypted
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert the password string to a byte array
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                // Compute the hash value of the password bytes
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);

                // Convert the hashed bytes back to a string representation
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    stringBuilder.Append(hashedBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
    }
}
