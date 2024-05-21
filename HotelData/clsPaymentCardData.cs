using Microsoft.Win32;
using System;

namespace HotelData
{
    public class clsPaymentCardData
    {
        public static void GetPaymentCardFromRegistry(ref string cardHolderName, ref string CardNumber, ref string CVC, ref decimal totalAmount, ref DateTime ExpieryDate)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\HotelManagmentSystem\paymentCardData";
            string totalAmountDataValue = "cardHolderName";
            string CardNumberValue = "CardNumber";
            string CVCValue = "CVC";
            string totalAmountValue = "totalAmount";
            string ExpieryDateValue = "ExpieryDate";


            try
            {



                // Read the value from the Registry
                string value1 = Registry.GetValue(keyPath, totalAmountDataValue, null) as string;
                string value2 = Registry.GetValue(keyPath, CardNumberValue, null) as string;
                string value3 = Registry.GetValue(keyPath, CVCValue, null) as string;
                string value4 = Registry.GetValue(keyPath, totalAmountValue, null) as string;
                string value5 = Registry.GetValue(keyPath, ExpieryDateValue, null) as string;

                if (value1 != null && value2 != null && value3 != null && value4 != null)
                {
                    cardHolderName = value1;
                    CardNumber = value2;
                    CVC = value3;
                    totalAmount = decimal.Parse(value4);
                    ExpieryDate = DateTime.Parse(value5);
                }
                else
                {
                    cardHolderName = null;
                    CardNumber = null;
                    CVC = null;
                    totalAmount = 0;
                    ExpieryDate = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public static void SavePaymentCardForCurrentUser(string cardHolderName, string CardNumber, string CVC, string totalAmount,
            string ExpiryDate)
        {
            // Specify the Registry key and path
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\HotelManagmentSystem\paymentCardData";

            string cardHolderNameValue = "cardHolderName";
            string cardHolderNameData = cardHolderName;

            string CardNumberValue = "CardNumber";
            string CardNumberData = CardNumber;

            string CVCValue = "CVC";
            string CVCData = CVC;

            string totalAmountValue = "totalAmount";
            string totalAmountData = totalAmount;

            string ExpiryDateValue = "ExpiryDate";
            string ExpiryDateData = ExpiryDate;
            try
            {
                // Write the value to the Registry
                Registry.SetValue(keyPath, cardHolderNameValue, cardHolderNameData, RegistryValueKind.String);
                Registry.SetValue(keyPath, CardNumberValue, CardNumberData, RegistryValueKind.String);
                Registry.SetValue(keyPath, CVCValue, CVCData, RegistryValueKind.String);
                Registry.SetValue(keyPath, totalAmountValue, totalAmountData, RegistryValueKind.String);
                Registry.SetValue(keyPath, ExpiryDateValue, ExpiryDateData, RegistryValueKind.String);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }

        public static void RemoveCurrentUserFromRegistry()
        {
            // Specify the registry key path and value name
            string keyPath = @"SOFTWARE\HotelManagmentSystem";
            string UsernameValue = "Current_User_Name";
            string PasswordValue = "Current_User_Password";
            string VisitorValue = "Current_Visitor";

            try
            {
                // Open the registry key in read/write mode with explicit registry view
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(keyPath, true))
                    {
                        if (key != null)
                        {
                            // Delete the specified value
                            key.DeleteValue(UsernameValue);
                            key.DeleteValue(PasswordValue);
                            key.DeleteValue(VisitorValue);
                        }
                        else
                        {
                            // MessageBox.Show("pla pla");
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("UnauthorizedAccessException: Run the program with administrative privileges.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
