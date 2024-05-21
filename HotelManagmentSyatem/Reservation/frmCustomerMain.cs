using HotelLogic;
using HotelManagmentSyatem.Customer;
using HotelManagmentSyatem.Global_Classes;
using HotelManagmentSyatem.People;
using HotelManagmentSyatem.Reservation.Controls;
using HotelManagmentSyatem.Reservation.Messages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Reservation
{
    public partial class frmCustomerMain : Form
    {
        clsCustomer _Customer = new clsCustomer();
        List<clsRoom> AvailableRooms;
        bool HideFlp = true;
        public frmCustomerMain(clsCustomer Customer)
        {
            InitializeComponent();
            _Customer = Customer;

        }

        private void showAvailableRooms(List<clsRoom> Rooms)
        {
            clsReservation reservation = new clsReservation();
            reservation.check_in_date = dpCheck_in_Date.Value;
            reservation.check_out_date = dpCheck_out.Value;
            flpRoomCards.Controls.Clear();


            foreach (clsRoom room in Rooms)
            {

                ctrlBookingRoomCard roomCard = new ctrlBookingRoomCard();
                roomCard.LoadRoomInfo((int)room.room_id);
                roomCard.ReservationInfo = reservation;
                flpRoomCards.Controls.Add(roomCard);
            }

            lblCountAvailableRooms.Text = flpRoomCards.Controls.Count.ToString();

        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            filtersContainers.Enabled = true;
            AvailableRooms = clsRoom.GetAvailableRooms();
            showAvailableRooms(AvailableRooms);
        }

        private void frmCustomerMain_Load(object sender, System.EventArgs e)
        {

            filtersContainers.Enabled = false;

            lblNumberOFmessages.Text = clsMessage.GetAllMessageForCustomerID((int)clsCurrentCustomer.customerInfo.CustomerID).Rows.Count.ToString();
            lblCustomerName.Text = clsPerson.FindPersonByID((int)clsCurrentCustomer.customerInfo.PersonID).FirstName;

            //date from  now to the end of  this month 
            dpCheck_in_Date.MinDate = DateTime.Now;
            dpCheck_in_Date.MaxDate = DateTime.Now.AddDays(DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - DateTime.Now.Day);

            //date from now to end of  this month to the end of the next month only allowed
            dpCheck_out.MinDate = DateTime.Now;
            dpCheck_out.MaxDate = DateTime.Now.AddDays(DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.AddMonths(1).Month) + (DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - DateTime.Now.Day));

            //load customer messages
            DataTable dtMessages = clsMessage.GetAllMessageForCustomerID((int)clsCurrentCustomer.customerInfo.CustomerID);

            if (dtMessages.Rows.Count > 0)
            {

                foreach (DataRow row in dtMessages.Rows)
                {
                    ctrlMessage message = new ctrlMessage();

                    message.LoadMessageData(row.Field<int>("MsgID"));

                    flpMessages.Controls.Add(message);

                }
            }

            flpMessages.Hide();


        }

        private void showPersonalDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails((int)clsCurrentCustomer.customerInfo.PersonID);

            frm.ShowDialog();

            lblCustomerName.Text = clsCustomer.FindCustomerByID((int)clsCurrentCustomer.customerInfo.CustomerID).PersonInfo.FirstName;

        }

        private void bookingAndTripsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerBookingAndTrip frm = new frmCustomerBookingAndTrip();

            frm.ShowDialog();
        }

        private void paymentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentDetails frm = new frmPaymentDetails(frmPaymentDetails.enMode.AddNew);
            frm.ShowDialog();
        }

        private void btnAccount_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Display the context menu strip at the mouse position
                contextMenuStrip1.Show(btnAccount, e.Location);
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeCustomerPassword frm = new frmChangeCustomerPassword((int)clsCurrentCustomer.customerInfo.PersonID);
            frm.ShowDialog();
        }

        private void btnNotfications_Click(object sender, EventArgs e)
        {
            HideFlp = !HideFlp;
            if (HideFlp)
                flpMessages.Hide();
            else
                flpMessages.Show();

        }

        private void btnAccount_MouseClick_1(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Display the context menu strip at the mouse position
                contextMenuStrip1.Show(btnAccount, e.Location);
            }
        }

        //private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    string Column = cbFilterby.SelectedItem.ToString();
        //    ckNo.Visible = (Column == "smoking allowed") || (Column == "pets friendly");
        //    ckYes.Visible = (Column == "smoking allowed") || (Column == "pets friendly");
        //    txtCustom.Visible = (Column == "Number of Beds") || (Column == "Number of People");
        //    cbCustom.Visible = (Column == "Room Size") || (Column == "Room View") || (Column == "Room Type");
        //    if (Column == "smoking allowed" || Column == "pets friendly")
        //        lblFilterTitle.Visible = false;
        //    else
        //        lblFilterTitle.Visible = true;
        //    FilterPriceContainer.Visible = (Column == "Price");
        //    lblPriceTitle.Visible = (Column == "Price");
        //    txtPriceTo.Visible = (Column == "Price");
        //    txtPriceFrom.Visible = (Column == "Price");

        //    switch (Column)
        //    {

        //        case "None.":
        //            {
        //                cbCustom.Visible = false;
        //                txtCustom.Visible = false;
        //                ckNo.Visible = false;
        //                ckYes.Visible = false;
        //                showAvailableRooms(AvailableRooms);
        //                lblFilterTitle.Text = "";

        //                break;
        //            }
        //        case "Room Size":
        //            {
        //                lblFilterTitle.Text = "Chose the Room Size ";
        //                cbCustom.Items.Clear();
        //                cbCustom.Items.Add("All");
        //                cbCustom.Items.Add("Small");
        //                cbCustom.Items.Add("Middle");
        //                cbCustom.Items.Add("larg");
        //                cbCustom.SelectedIndex = 0;

        //                break;
        //            }
        //        case "Price":
        //            {
        //                lblFilterTitle.Text = "";

        //                break;
        //            }
        //        case "Room View":
        //            {

        //                lblFilterTitle.Text = "Chose the Room view";
        //                cbCustom.Items.Clear();
        //                cbCustom.Items.Add("All");
        //                cbCustom.Items.Add("Balcony");
        //                cbCustom.Items.Add("Garden");
        //                cbCustom.Items.Add("Pool");
        //                cbCustom.Items.Add("City");
        //                cbCustom.SelectedIndex = 0;

        //                break;
        //            }
        //        case "Number of Beds":
        //            {
        //                lblFilterTitle.Text = "Enter The Number";
        //                break;
        //            }
        //        case "Number of People":
        //            {

        //                lblFilterTitle.Text = "Enter The Number";
        //                break;
        //            }

        //        case "Room Type":
        //            {
        //                lblFilterTitle.Text = "Chose the Room Type";

        //                cbCustom.Items.Clear();
        //                cbCustom.Items.Add("All");
        //                DataTable dtRoomType = clsRoomType.GetAllRoomType();
        //                foreach (DataRow row in dtRoomType.Rows)
        //                {
        //                    cbCustom.Items.Add(row.Field<string>("type_name"));
        //                }
        //                cbCustom.SelectedIndex = 0;

        //                break;
        //            }

        //    }
        //}

        //private void ckYes_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (ckYes.Checked)
        //    {
        //        ckYes.Enabled = true;
        //        ckNo.Enabled = false;

        //    }
        //    else
        //    {
        //        ckYes.Enabled = true;
        //        ckNo.Enabled = true;
        //    }

        //}

        //private void ckNo_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (ckNo.Checked)
        //    {

        //        ckNo.Enabled = true;
        //        ckYes.Enabled = false;
        //    }
        //    else
        //    {
        //        ckNo.Enabled = true;
        //        ckYes.Enabled = true;
        //    }
        //}

        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // Check if the pressed key is a digit or the backspace key
        //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        //    {
        //        // If not a digit or backspace, suppress the key press
        //        e.Handled = true;
        //    }

        //}

        //private void btnFindNow_Click(object sender, EventArgs e)
        //{
        //    string FilterBy = cbFilterby.SelectedItem.ToString();
        //    List<clsRoom> FilterdRoom;

        //    switch (FilterBy)
        //    {
        //        case "Room Size":
        //            {

        //                FilterdRoom = AvailableRooms.Where(room => room.room_size == cbCustom.SelectedIndex).ToList();

        //                break;
        //            }
        //        case "Price":
        //            {
        //                decimal from = decimal.Parse(txtPriceFrom.Text.Trim());
        //                decimal To = decimal.Parse(txtPriceTo.Text.Trim());
        //                FilterdRoom = AvailableRooms.Where(room => room.RoomTypeInfo.cost_per_night >= from && room.RoomTypeInfo.cost_per_night <= To).ToList();

        //                break;
        //            }
        //        case "Room View":
        //            {
        //                FilterdRoom = AvailableRooms.Where(room => room.room_view == cbCustom.SelectedIndex).ToList();

        //                break;
        //            }
        //        case "Number of Beds":
        //            {
        //                int NumberOfBeds = int.Parse(txtCustom.Text.ToString());
        //                FilterdRoom = AvailableRooms.Where(room => room.number_of_beds == NumberOfBeds).ToList();


        //                break;
        //            }
        //        case "Number of People":
        //            {
        //                int NumberOfPeople = int.Parse(txtCustom.Text.ToString());
        //                FilterdRoom = AvailableRooms.Where(room => room.number_of_people == NumberOfPeople).ToList();


        //                break;
        //            }
        //        case "pets friendly":
        //            {
        //                bool Allowed = ckYes.Checked;
        //                FilterdRoom = AvailableRooms.Where(room => room.is_pet_friendly == Allowed).ToList();

        //                break;
        //            }
        //        case "smoking allowed":
        //            {
        //                bool Allowed = ckYes.Checked;
        //                FilterdRoom = AvailableRooms.Where(room => room.is_smoking_allowed == Allowed).ToList();

        //                break;
        //            }

        //        case "Room Type":
        //            {
        //                clsRoomType roomtype = clsRoomType.FindRoomTypeByName(cbCustom.SelectedItem.ToString());
        //                FilterdRoom = AvailableRooms.Where(room => room.room_type_id == roomtype.type_id).ToList();

        //                break;
        //            }
        //        default:
        //            {
        //                FilterdRoom = AvailableRooms.Where(room => false).ToList();
        //                break;
        //            }
        //    }
        //    if (FilterdRoom.Count == 0)
        //    {
        //        PictureBox picture = new PictureBox();
        //        picture.Load("C:\\Users\\lenovo\\Downloads\\NoRoomFound.jpg");
        //        picture.Width = 600;
        //        picture.Height = 347;
        //        flpRoomCards.Controls.Clear();
        //        flpRoomCards.Controls.Add(picture);

        //        return;
        //    }
        //    showAvailableRooms(FilterdRoom);


        //}

    }
}


