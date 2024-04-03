using System.Text.RegularExpressions;

namespace HotelManagmentSyatem.Global_Classes
{
    internal class clsValidatoin
    {
        /// <summary>
        /// Validates the format of an email address.
        /// </summary>
        /// <param name="email">The email address to be validated.</param>
        /// <returns>
        ///   <c>true</c> if the email address is in the correct format; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This function uses a basic format validation and does not check the existence of the email address.
        /// </remarks>
        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(emailAddress);
        }
        /// <summary>
        /// Validates if a given string represents a non-negative integer.
        /// </summary>
        /// <param name="Number">The string to be validated.</param>
        /// <returns>
        ///   <c>true</c> if the input string is a non-negative integer; otherwise, <c>false</c>.
        /// </returns>
        public static bool ValidateInteger(string Number)
        {
            var pattern = @"^[0-9]*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool ValidateFloat(string Number)
        {
            var pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        /// <summary>
        /// Checks if a given string represents a numeric value (integer or floating-point).
        /// </summary>
        /// <param name="Number">The string to be checked for numeric representation.</param>
        /// <returns>
        ///   <c>true</c> if the input string is a numeric value; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNumber(string Number)
        {
            return (ValidateInteger(Number) || ValidateFloat(Number));
        }
    }
}
