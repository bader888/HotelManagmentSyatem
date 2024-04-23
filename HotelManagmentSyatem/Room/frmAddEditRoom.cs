using Bunifu.UI.WinForms;
using HotelLogic;
using HotelManagmentSyatem.Room_Type;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Room
{
    public partial class frmAddEditRoom : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _RoomID = -1;
        clsRoom _Room = new clsRoom();

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int RoomID, enMode Mode);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        public frmAddEditRoom()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditRoom(int RoomID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _RoomID = RoomID;
        }

        private void _ResetDefualtValues()
        {

            _FillRoomTypeInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                lblHeader.Text = "Add New Room";
                _Room = new clsRoom();
            }
            else
            {
                lblHeader.Text = "Update Room";
            }

            txtDescription.Text = string.Empty;
            txtRoomNumber.Text = string.Empty;
            cbRoomSize.SelectedIndex = 0;
            cbRoomView.SelectedIndex = 0;
            cbRoomType.SelectedIndex = 0;
            ckIsPetsFriendlly.Checked = false;
            ckSmokingAllowed.Checked = false;
            nupNumberOFpeople.Value = 1;
            nupNumberOFBeds.Value = 1;

        }

        private void _FillRoomTypeInComoboBox()
        {
            DataTable dtCountries = clsRoomType.GetAllRoomType();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbRoomType.Items.Add(row["type_name"]);
            }

        }

        private void _LoadData()
        {
            _Room = clsRoom.FindRoomByID(_RoomID);

            if (_Room == null)
            {
                MaterialMessageBox.Show("No Room with ID = " + _Room, "Room Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            //the following code will not be executed if the person was not found

            lblRoomID.Text = _RoomID.ToString();
            txtDescription.Text = _Room.room_description;
            txtRoomNumber.Text = _Room.room_number.ToString();
            cbRoomSize.SelectedIndex = (int)_Room.room_size;
            cbRoomView.SelectedIndex = (int)_Room.room_view;
            nupNumberOFBeds.Value = (int)_Room.number_of_beds;
            nupNumberOFpeople.Value = (int)_Room.number_of_people;
            ckIsPetsFriendlly.Checked = (bool)_Room.is_pet_friendly;
            ckSmokingAllowed.Checked = (bool)_Room.is_smoking_allowed;
            cbRoomType.SelectedIndex = (int)_Room.room_type_id - 1;
        }

        private void ValidateEmptyText(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            BunifuTextBox Temp = ((BunifuTextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditRoom_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _Room.room_description = txtDescription.Text.Trim();
            _Room.room_number = int.Parse(txtRoomNumber.Text.Trim());
            _Room.room_view = (byte)(cbRoomView.SelectedIndex + 1);
            _Room.room_size = (byte)(cbRoomSize.SelectedIndex + 1);
            _Room.room_type_id = (int)cbRoomType.SelectedIndex + 1;
            _Room.number_of_beds = (int)nupNumberOFBeds.Value;
            _Room.number_of_people = (int)nupNumberOFpeople.Value;
            _Room.is_pet_friendly = ckIsPetsFriendlly.Checked == true;
            _Room.is_smoking_allowed = ckSmokingAllowed.Checked == true;


            if (_Room.Save())
            {
                lblRoomID.Text = _Room.room_id.ToString();

                //change form mode to update.
                _Mode = enMode.Update;
                lblHeader.Text = "Update Room";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, (int)_Room.room_id, _Mode);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAddNewRoomType_Click(object sender, EventArgs e)
        {
            frmAddEditRoomType frm = new frmAddEditRoomType();
            frm.ShowDialog();
            _FillRoomTypeInComoboBox();

        }
    }
}
