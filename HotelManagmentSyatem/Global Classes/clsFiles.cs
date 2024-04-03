using System;
using System.IO;

namespace HotelManagmentSyatem.Global_Classes
{
    public class clsFileManager
    {



        public static string CopyFile(string fileSourcePath, string destinationFolderPath = "C:\\newFolder")
        {
            try
            {
                // Ensure the destination folder exists; if not, create it
                if (!Directory.Exists(destinationFolderPath))
                {
                    Directory.CreateDirectory(destinationFolderPath);
                }

                // Get the file name from the source file path
                string fileName = Path.GetFileName(fileSourcePath);

                Guid newGuid = Guid.NewGuid();

                // Convert the GUID to string for display
                string guidString = newGuid.ToString();


                // Combine the destination folder path and file name to create the full destination path
                string destinationFilePath = Path.Combine(destinationFolderPath, guidString + ".png");

                // Copy the file to the destination folder
                File.Copy(fileSourcePath, destinationFilePath, true); // The third parameter "true" specifies to overwrite if the file already exists

                return destinationFilePath; // Return the new file path
            }
            catch (Exception ex)
            {
                // Handle exceptions here if necessary
                Console.WriteLine($"An error occurred while copying the file: {ex.Message}");
                return null; // Return null if an error occurs
            }
        }
        public static bool DeleteFile(string FileSourcePath)
        {
            try
            {
                // Check if the file exists
                if (File.Exists(FileSourcePath))
                {
                    // Delete the file
                    File.Delete(FileSourcePath);
                    return true;

                }
                else
                {
                    return false;

                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
