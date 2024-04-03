using Microsoft.Win32;
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace HotelManagmentSyatem.Global_Classes
{
    internal class clsUtil
    {
        //file
        public static string GenerateGUID()
        {

            // Generate a new GUID
            Guid newGuid = Guid.NewGuid();

            // convert the GUID to a string
            return newGuid.ToString();

        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {

            // Check if the folder exists
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    return true;


                }
                catch (Exception ex)
                {
                    //    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;

        }

        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            // Full file name. Change your file name   
            string fileName = sourceFile;

            FileInfo fi = new FileInfo(fileName); //this object contain the file information like size, extention , createed time, ...etc

            string extn = fi.Extension;

            return GenerateGUID() + extn;

        }

        public static bool CopyImageToProjectImagesFolder(ref string sourceFilePath)
        {
            // this funciton will copy the image to the
            // project images foldr after renaming it
            // with GUID with the same extention, then it will update the sourceFileName with the new name.

            string DestinationFolderPath = @"C:\DVLD-People-Images\";
            if (!CreateFolderIfDoesNotExist(DestinationFolderPath))
            {
                return false;
            }

            string destinationFilePath = DestinationFolderPath + ReplaceFileNameWithGUID(sourceFilePath);
            try
            {
                File.Copy(sourceFilePath, destinationFilePath, true);

            }
            catch (IOException iox)
            {
                //MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFilePath = destinationFilePath;
            return true;
        }

        //registry
        public static void DeleteFromRegistry()
        {
            // Specify the registry key path and value name
            string keyPath = @"SOFTWARE\DVLD";
            string UsernameValue = "Current_User_Name";
            string PasswordValue = "Current_User_Password";

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
                //   MessageBox.Show("UnauthorizedAccessException: Run the program with administrative privileges.");
            }
            catch (Exception ex)
            {
                LogMessageError(ex.Message);
            }
        }

        public static void WriteToRegistry(string UserName, string Password)
        {
            // Specify the Registry key and path
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            string UsernameValue = "Current_User_Name";
            string UserNameData = UserName;
            string PasswordValue = "Current_User_Password";
            string PasswordData = Password;

            try
            {
                // Write the value to the Registry
                Registry.SetValue(keyPath, UsernameValue, UserNameData, RegistryValueKind.String);
                Registry.SetValue(keyPath, PasswordValue, PasswordData, RegistryValueKind.String);
            }
            catch (Exception ex)
            {
                LogMessageError(ex.Message);
            }
        }

        public static void ReadFromRegistry(ref string UserName, ref string Password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            string UsernameValue = "Current_User_Name";
            string PasswordValue = "Current_User_Password";
            try
            {
                // Read the value from the Registry
                string value1 = Registry.GetValue(keyPath, UsernameValue, null) as string;
                string value2 = Registry.GetValue(keyPath, PasswordValue, null) as string;

                if (value1 != null && value2 != null)
                {
                    UserName = value1; Password = value2;
                }
                else
                {
                    UserName = null; Password = null;
                }
            }
            catch (Exception ex)
            {
                LogMessageError($"An error occurred: {ex.Message}");
            }
        }

        //event log
        static string sourceName = ConfigurationManager.AppSettings["ProjectName"];


        public static void LogMessageError(string messageError)
        {
            //log the error in event viewer
            // Create the event source if it does not exist
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }

            // Log an information event
            EventLog.WriteEntry(sourceName, messageError, EventLogEntryType.Error);

        }

        static public string ConvertSecondsToTimeFormat(int seconds)
        {
            string TimeFormat = "0:0:0";
            if (seconds / 60 == 0)
            {
                TimeFormat.Insert(4, seconds.ToString());
                return TimeFormat;
            }
            seconds = seconds / 60;
            TimeFormat.Insert(2, seconds.ToString());
            seconds = seconds / 60;
            TimeFormat.Insert(0, seconds.ToString());

            return TimeFormat;
        }
    }
}
