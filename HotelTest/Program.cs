using HotelLogic;
using System;
using System.Security.Cryptography;
using System.Text;

namespace HotelTest
{
    internal class Program
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

        static void Main(string[] args)
        {

            clsCustomer customer = new clsCustomer();
            customer.PersonID = 22;
            customer.Email = "bader@gmail.com";
            customer.Password = HashPassword("1234");
            Console.WriteLine(customer.Save());


            //    Console.WriteLine(clsCustomerData.UpdateCustomer(2, 1, "PLPL", "PLAPLA"));

            //clsCustomerData.UpdateCustomer(1, 1, "BaderHiader@gmail.com", "1234");

        }
    }
}
