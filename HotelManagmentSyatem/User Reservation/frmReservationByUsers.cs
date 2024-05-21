using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HotelManagmentSyatem.User_Reservation
{
    public partial class frmReservationByUsers : Form
    {
        public frmReservationByUsers()
        {
            InitializeComponent();
        }

        int _CustomerID = -1;
        int _PersonID = -1;
        int _RoomID = -1;

        private void btnRooms_Click(object sender, System.EventArgs e)
        {

            if (_PersonID == -1)
            {
                bunifuSnackbar1.Show(this,
                    "Error: Select Person First",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);

                return;
            }

            pages.PageName = "tpAvailableRooms";//move to this page
            List<clsRoom> listAvailableRooms = clsRoom.GetAvailableRooms();
            DataTable dtnew = new DataTable();
            dtnew.Columns.Add("Room ID"); dtnew.Columns.Add("Room Number");
            dtnew.Columns.Add("Room Type"); dtnew.Columns.Add("Cost Per Night");
            foreach (clsRoom Room in listAvailableRooms)
            {
                DataRow newRow = dtnew.NewRow();
                newRow["Room ID"] = Room.room_id; newRow["Room Number"] = Room.room_number;
                newRow["Room Type"] = Room.RoomTypeInfo.type_name;
                newRow["Cost Per Night"] = Room.RoomTypeInfo.cost_per_night;
                dtnew.Rows.Add(newRow);
            }

            dgvRooms.DataSource = dtnew;
            lblAvailableRoomsNumber.Text = listAvailableRooms.Count.ToString();
        }


        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                lblSelectRoomNumber.Text = dgvRooms.Rows[e.RowIndex].Cells[1].Value.ToString();
                _RoomID = int.Parse(dgvRooms.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void btnReservation_Click(object sender, System.EventArgs e)
        {
            if (_RoomID == -1)
            {
                bunifuSnackbar1.Show(this,
                    "Error: Select Room First",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);

                return;
            }

            pages.PageName = "tpReservation"; //move to this page
        }


        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnCustomer_Click(object sender, System.EventArgs e)
        {
            pages.PageName = "tpCustomer";
        }


        private void btnSave_Click(object sender, System.EventArgs e)
        {


            //create customer and save it to the data base 
            clsCustomer customer = new clsCustomer();
            customer.Email = clsPerson.FindPersonByID(_PersonID).Email;
            customer.Password = clsEncrypted.HashPassword("0000");
            customer.PersonID = _PersonID;

            if (!customer.Save())
            {
                bunifuSnackbar1.Show(this, "Faild To Save Customer", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }



            clsReservation Reservation = new clsReservation();
            Reservation.check_in_date = dpCheckInDate.Value;
            Reservation.check_out_date = dpCheckOutDate.Value;
            Reservation.room_id = _RoomID;
            Reservation.customer_id = customer.CustomerID;
            Reservation.number_of_nights = int.Parse(nupNumberOfNight.Value.ToString());
            Reservation.special_request = (string.IsNullOrEmpty(txtSpecialRequest.Text.Trim()) ?
                " " :
                txtSpecialRequest.Text.Trim());
            Reservation.reservation_cost = decimal.Parse(lblTotalPrice.Text);
            Reservation.arrived_time = string.IsNullOrEmpty(txtHour.Text) && string.IsNullOrEmpty(txtminut.Text) ?
                new TimeSpan(0, 0, 0) :
                new TimeSpan(int.Parse(txtHour.Text), int.Parse(txtminut.Text), 0);
            Reservation.reservation_status = (int)clsReservation.enReservationStatus.Pending;
            if (Reservation.Save())
                bunifuSnackbar1.Show(this, "reservation save Successfuly", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);

            else
                bunifuSnackbar1.Show(this, "Error: reservation save Faild", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
        }

        private void dpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {

            if (dpCheckOutDate.Value.Day - dpCheckInDate.Value.Day <= 0)
            {

                bunifuSnackbar1.Show(this, "Please select valid date", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                btnSave.Enabled = false;
                return;

            }
            btnSave.Enabled = true;

            nupNumberOfNight.Value = (dpCheckOutDate.Value.Day - dpCheckInDate.Value.Day);

            lblTotalPrice.Text = ((decimal)clsRoomType.FindRoomTypeByID((int)clsRoom.FindRoomByID((int)_RoomID).room_type_id).cost_per_night * (dpCheckOutDate.Value.Day - dpCheckInDate.Value.Day)).ToString();


        }

        private void ctrlAddNewCustomer1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
        }
    }
}
