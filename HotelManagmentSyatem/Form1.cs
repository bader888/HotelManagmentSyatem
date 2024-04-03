using HotelLogic;
using HotelManagmentSyatem.hotel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace HotelManagmentSyatem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // Delegate declaration
        public delegate void DataSender(clsFacilite NewFacilite);

        // Event to be raised when data is sent from Form2
        public event DataSender DataSent;

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }
        public void LoadHotelFacilities()
        {
            List<clsFacilite> HotelFacilities = clsFacilite.GetClsFacilites();
            foreach (var item in HotelFacilities)
            {
                // Instantiate the UserControl
                ctrlHotelFacilite ctrlHotelFacilite = new ctrlHotelFacilite();

                // Dynamically create an event handler method
                MethodInfo eventHandlerMethod = GetType().GetMethod("DeleteFacilite_Event", BindingFlags.NonPublic | BindingFlags.Instance);

                // Subscribe to the event using reflection
                EventInfo customEvent = ctrlHotelFacilite.GetType().GetEvent("CustomEvent");

                Delegate handler = Delegate.CreateDelegate(customEvent.EventHandlerType, this, eventHandlerMethod);

                customEvent.AddEventHandler(ctrlHotelFacilite, handler);

                ctrlHotelFacilite.FacilitieName = item.Name;
                ctrlHotelFacilite.IconUrl = item.IconUrl;
                ctrlHotelFacilite.FaciliteID = (int)item.ID;
                ctrlHotelFacilite.Check += FaciliteChecked;
                flowLayoutPanel1.Controls.Add(ctrlHotelFacilite);
            }
        }

        List<int> FacilitesID = new List<int>();

        private void FaciliteChecked(int FaciliteID)
        {
            MessageBox.Show(FaciliteID.ToString());

            if (FacilitesID.Count == 0)
            {
                MessageBox.Show("this the first ele in list, and added");

                FacilitesID.Add(FaciliteID);
                return;
            }

            if (FacilitesID.Contains(FaciliteID))
            {

                MessageBox.Show("this found in list, and deleted");
                FacilitesID.Remove(FaciliteID);
            }
            else
            {
                MessageBox.Show("this not found in list, and Add");
                FacilitesID.Add(FaciliteID);
            }

        }

        // Event handler for the custom event
        private void DeleteFacilite_Event(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Remove((ctrlHotelFacilite)sender);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            LoadHotelFacilities();

        }

        private void btnAddNewFacilitie_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateFacilitie frm = new frmAddUpdateFacilitie();
            frm.DataSent += DataFromAddUpdateFacilitieForm;
            frm.ShowDialog();

        }

        private void DataFromAddUpdateFacilitieForm(clsFacilite NewFacilite)
        {
            ctrlHotelFacilite ctrlHotelFacilite = new ctrlHotelFacilite();
            ctrlHotelFacilite.FacilitieName = NewFacilite.Name;
            ctrlHotelFacilite.IconUrl = NewFacilite.IconUrl;
            ctrlHotelFacilite.FaciliteID = (int)NewFacilite.ID;
            flowLayoutPanel1.Controls.Add(ctrlHotelFacilite);
        }
        string SourcePath = null;

        public static bool CopyFile(string FileSourcePath, string destinationFolderPath = "C:\\newFolder")
        {
            // Specify the destination folder
            //   string destinationFolderPath = "C:\\ImagesHotel";

            try
            {
                // Ensure the destination folder exists; if not, create it
                if (!Directory.Exists(destinationFolderPath))
                {
                    Directory.CreateDirectory(destinationFolderPath);
                }

                // Get the file name from the source file path
                string fileName = Path.GetFileName(FileSourcePath);

                // Generate a new GUID
                Guid newGuid = Guid.NewGuid();

                // Convert the GUID to string for display
                string guidString = newGuid.ToString();


                // Combine the destination folder path and file name to create the full destination path
                string destinationFilePath = Path.Combine(destinationFolderPath, guidString + "png");

                // Copy the file to the destination folder
                File.Copy(FileSourcePath, destinationFilePath, true); // The third parameter "true" specifies to overwrite if the file already exists 
                return true;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while copying the file: {ex.Message}");
                return false;
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


        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CopyFile(SourcePath).ToString());
        }


        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set dialog properties
            openFileDialog1.Title = "Select a File";
            // openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            // Display the dialog
            DialogResult result = openFileDialog1.ShowDialog();

            // Check if user clicked OK
            if (result == DialogResult.OK)
            {
                // Get the selected file path
                SourcePath = openFileDialog1.FileName;

            }
        }
    }

}



