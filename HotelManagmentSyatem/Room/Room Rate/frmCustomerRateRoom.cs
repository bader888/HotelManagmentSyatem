using Bunifu.UI.WinForms;
using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using HotelManagmentSyatem.Properties;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Room.Room_Rate
{
    public partial class frmCustomerRateRoom : Form
    {


        private void Rating_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {
            //  MessageBox.Show(Rating.Value.ToString());
        }

        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGender { male = 1, Female = 0 };

        private enMode _Mode;

        private int _RateID = -1;
        int _CustomerID = -1;
        int _RoomID = -1;


        clsRoomRate _RoomRate = new clsRoomRate();
        public frmCustomerRateRoom(int CustoemrID, int RoomID)
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _CustomerID = CustoemrID;
            _RoomID = RoomID;


        }
        public frmCustomerRateRoom(int rateID, int customerID, int roomID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _RateID = rateID;
            _CustomerID = customerID;
            _RoomID = roomID;
        }


        private void _ResetDefualtValues()
        {

            if (_Mode == enMode.AddNew)
            {
                this.Text = "Rate Room";
                _RoomRate = new clsRoomRate();
                txtDescription.Text = string.Empty;
                Rating.Value = 0;
                lblDate.Text = clsFormat.DateToShort(DateTime.UtcNow);
                lblLettersCount.Text = "255/255";
                clsCustomer customer = clsCustomer.FindCustomerByID(_CustomerID);
                if (customer == null)
                {
                    MessageBox.Show("No Customer with ID = " + _CustomerID, "Csuomter Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    return;

                }
                else
                {

                    if (customer.PersonInfo.ImagePath != "")
                        try
                        {
                            pbCustomer.Load(customer.PersonInfo.ImagePath);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error: Wrong URL", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    else
                    {
                        if (customer.PersonInfo.Gender == (int)enGender.male)
                            pbCustomer.Image = Resources.Male_512;
                        else
                            pbCustomer.Image = Resources.Female_512;

                    }
                    lblCustomerName.Text = customer.PersonInfo.FullName;

                }


                clsRoom Room = clsRoom.FindRoomByID(_RoomID);
                if (Room == null)
                {
                    MessageBox.Show("No Room with ID = " + _RoomID, "Room Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    return;

                }
                else
                {

                    lblRoomNumber.Text = Room.room_number.ToString();

                }
            }
            else
                this.Text = "Update Rate Room";

        }



        private void _LoadData()
        {

            _RoomRate = clsRoomRate.FindRoomRateByID(_RateID);

            if (_RoomRate == null)
            {
                MessageBox.Show("No RoomRate with ID = " + _RateID, "Rate Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            txtDescription.Text = _RoomRate.description;
            Rating.Value = int.Parse(Math.Round((double)_RoomRate.score).ToString());
            lblCustomerName.Text = _RoomRate.CustomerInFo.PersonInfo.FullName;
            lblDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblLettersCount.Text = "255 / " + (255 - _RoomRate.description.Length);
            lblRoomNumber.Text = _RoomRate.roomInfo.room_number.ToString();



            if (_RoomRate.CustomerInFo.PersonInfo.ImagePath != "")
                try
                {
                    pbCustomer.Load(_RoomRate.CustomerInFo.PersonInfo.ImagePath);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error: Wrong URL", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            else
            {
                if (_RoomRate.CustomerInFo.PersonInfo.Gender == (int)enGender.male)
                    pbCustomer.Image = Resources.Male_512;
                else
                    pbCustomer.Image = Resources.Female_512;

            }

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCustomerRateRoom_Load(object sender, EventArgs e)
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

            _RoomRate.description = txtDescription.Text.Trim();
            _RoomRate.score = Rating.Value;
            _RoomRate.customerID = _CustomerID;
            _RoomRate.roomID = _RoomID;


            if (_RoomRate.Save())
            {

                //change form mode to update.
                _Mode = enMode.Update;
                this.Text = "Update Room Rate";

                bunifuSnackbar1.Show(this,
                    "Data Saved Successfully.",
                    BunifuSnackbar.MessageTypes.Success);

                if (DataBack != null)
                    // Trigger the event to send data back to the caller form.
                    DataBack?.Invoke(this, (int)_RoomRate.rateID);
            }
            else
                bunifuSnackbar1.Show(this,
                    "Error: Data Is not Saved Successfully.",
                    BunifuSnackbar.MessageTypes.Error);
        }





        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDescription, null);
            }

            if (txtDescription.Text.Length > 255)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "This field  most by less than 255 letters!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDescription, null);
            }


        }

        private void llRoomDeatils_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowRoomDetails frm = new frmShowRoomDetails(_RoomID);
            frm.HideBtnFromCustomer();
            frm.ShowDialog();

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            lblLettersCount.Text = "255 / " + (255 - txtDescription.Text.Length);

        }
    }
}
