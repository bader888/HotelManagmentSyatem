using Bunifu.UI.WinForms;
using HotelLogic;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Room_Type
{
    public partial class frmAddEditRoomType : Form
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int RoomTypeID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _RoomTypeID = -1;
        clsRoomType _RoomType = new clsRoomType();

        public frmAddEditRoomType()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditRoomType(int RoomTypeID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _RoomTypeID = RoomTypeID;
        }

        private void _ResetDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblHeader.Text = "Add New Room Type";
                _RoomType = new clsRoomType();
            }
            else
            {
                lblHeader.Text = "Update Room type";
            }

            txtTypeName.Text = string.Empty;
            txtTypeName.Text = string.Empty;

        }

        private void _LoadData()
        {
            _RoomType = clsRoomType.FindRoomTypeByID(_RoomTypeID);

            if (_RoomType == null)
            {
                MaterialMessageBox.Show("No Room Type with ID = " + _RoomTypeID, "Room Type Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            //the following code will not be executed if the person was not found

            txtTypeName.Text = _RoomType.type_name;
            txtCostPerNight.Text = _RoomType.cost_per_night.ToString();
            lblTypeID.Text = _RoomType.type_id.ToString();
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


        private void frmAddEditRoomType_Load(object sender, EventArgs e)
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
                bunifuSnackbar1.Show(this, "Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", BunifuSnackbar.MessageTypes.Error);
                return;

            }

            _RoomType.cost_per_night = decimal.Parse(txtCostPerNight.Text);
            _RoomType.type_name = txtTypeName.Text;



            if (_RoomType.Save())
            {
                lblTypeID.Text = _RoomType.type_id.ToString();

                //change form mode to update.
                _Mode = enMode.Update;
                lblHeader.Text = "Update Room Type";
                bunifuSnackbar1.Show(this, "Data Saved Successfully.", BunifuSnackbar.MessageTypes.Information);

                //Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, (int)_RoomType.type_id);
            }
            else
                bunifuSnackbar1.Show(this, "Error: Data Is not Saved Successfully.", BunifuSnackbar.MessageTypes.Error);
        }

        private void txtCostPerNight_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input (0-9) and control keys like backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Cancel the key press if it's not a digit or control key
                e.Handled = true;
            }
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
