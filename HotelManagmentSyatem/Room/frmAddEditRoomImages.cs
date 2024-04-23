using Bunifu.UI.WinForms;
using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Room
{
    public partial class frmAddEditRoomImages : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _RoomID = -1;
        List<int> pictureTags = new List<int>();
        List<string> RoomImagPaths = new List<string>();
        clsRoomImage _RoomImages = new clsRoomImage();

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, enMode Mode);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public frmAddEditRoomImages(int RoomID, enMode Mode)
        {
            InitializeComponent();
            _Mode = Mode;
            _RoomID = RoomID;
            btnSave.Enabled = false;
        }

        private void _ResetDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblHeader.Text = "Add Room Images";
                _RoomImages = new clsRoomImage();
            }
            else
            {
                lblHeader.Text = "Update Room Images";
            }

            flpImages.Controls.Clear();

        }

        private void _LoadData()
        {
            DataTable dtRoomImages = clsRoomImage.GetAllImagesForRoomID(_RoomID);

            if (_Mode == enMode.Update)
            {
                if (dtRoomImages.Rows.Count > 0)
                {

                }

                int numberOfItems;

                foreach (DataRow row in dtRoomImages.Rows)
                {
                    numberOfItems = flpImages.Controls.Count;
                    BunifuPictureBox pic = new BunifuPictureBox();
                    pic.Click += PictureBox_Click;
                    pic.Load(row["imagePath"].ToString());
                    pic.Type = BunifuPictureBox.Types.Square;
                    pic.Tag = numberOfItems;
                    flpImages.Controls.Add(pic);
                    RoomImagPaths.Add(row["imagePath"].ToString());
                }

            }
        }

        private void btnAddImages_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                int numberOfItems;
                foreach (string fileName in openFileDialog.FileNames)
                {
                    // You can handle each selected image file here
                    // For example, you can add them to a list or display them on the form
                    // In this example, we'll just display the file paths in a list box
                    numberOfItems = flpImages.Controls.Count;

                    BunifuPictureBox pic = new BunifuPictureBox();
                    pic.Click += PictureBox_Click;
                    pic.Load(fileName);
                    pic.Type = BunifuPictureBox.Types.Square;
                    pic.Tag = numberOfItems;
                    flpImages.Controls.Add(pic);
                    RoomImagPaths.Add(fileName);

                }
            }
            btnSave.Enabled = true;

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            BunifuPictureBox clickedPictureBox = (BunifuPictureBox)sender;


            if (clickedPictureBox.BorderStyle == BorderStyle.FixedSingle)
            {
                // If the border is already green, remove it and remove the tag from the list
                clickedPictureBox.BorderStyle = BorderStyle.None; // Restore default border color 
                clickedPictureBox.Type = BunifuPictureBox.Types.Square;
                pictureTags.Remove((int)clickedPictureBox.Tag);
            }
            else
            {
                // If the border is not green, set it to green and add the tag to the list
                clickedPictureBox.BorderStyle = BorderStyle.FixedSingle;
                clickedPictureBox.Type = BunifuPictureBox.Types.Circle;
                pictureTags.Add((int)clickedPictureBox.Tag);
            }

            btnRemove.Visible = pictureTags.Count > 0;


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (var tag in pictureTags)
            {
                Control control = flpImages.Controls[tag];
                flpImages.Controls.Remove(control);
                RoomImagPaths.RemoveAt(tag);
            }

            int number = -1;
            foreach (BunifuPictureBox control in flpImages.Controls)
            {
                number++;
                control.Tag = number;
            }
            pictureTags.Clear();
            btnRemove.Visible = false;
            btnSave.Enabled = flpImages.Controls.Count != 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            _SaveRoomImagesInFolder();
        }

        private void _SaveRoomImagesInFolder()
        {
            if (RoomImagPaths.Count != 0)
            {

                foreach (string ImagePath in RoomImagPaths)
                {
                    //create folder called the 'room-number' add but the images on it.
                    clsFileManager.CopyFile(ImagePath, $"c:\\\\{clsRoom.FindRoomByID(_RoomID).room_number}-roomImages");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flpImages.Controls.Count == 0)
            {

                bunifuSnackbar1.Show(this, " please add images first", BunifuSnackbar.MessageTypes.Information);
                return;
            }

            _RoomImages.roomID = _RoomID;
            _RoomImages.imagePath = string.Join(",", RoomImagPaths);

            if (_RoomImages.Save())
            {
                lblHeader.Text = "Update Room Images";
                bunifuSnackbar1.Show(this, "Data Saved Successfully.", BunifuSnackbar.MessageTypes.Information);

                DataBack?.Invoke(this, enMode.Update);
            }
            else
                bunifuSnackbar1.Show(this, "Error: Data Is not Saved Successfully.", BunifuSnackbar.MessageTypes.Error);
        }

        private void frmAddEditRoomImages_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }
    }
}
