using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using HotelManagmentSyatem.Room;
using System;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Reservation
{
    public partial class frmPaymentForBookingRoom : Form
    {
        private clsRoom _Room;
        private clsReservation _Reservation;
        decimal CostPerNight = 0;


        public frmPaymentForBookingRoom(clsRoom Room, clsReservation Reservation)
        {
            InitializeComponent();
            _Room = Room;
            _Reservation = Reservation;
            CostPerNight = (decimal)clsRoomType.FindRoomTypeByID((int)_Room.room_type_id).cost_per_night;


        }

        private void llAddCardInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmPaymentDetails frm = new frmPaymentDetails(frmPaymentDetails.enMode.AddNew);
            frm.ShowDialog();

        }


        private void frmPaymentForBookingRoom_Load(object sender, System.EventArgs e)
        {
            lblCheckInDate.Text = clsFormat.DateToFullDetailsWithOutTime((DateTime)_Reservation.check_in_date);
            lblCheckOutDate.Text = clsFormat.DateToFullDetailsWithOutTime((DateTime)_Reservation.check_out_date);
            lblTotalPrice.Text = "US $ " + (CostPerNight).ToString();
            ctrlPaymentDetailsCard1.LoadCardData();


            DateTime checkInDate = Convert.ToDateTime(_Reservation.check_in_date);
            DateTime checkOutDate = Convert.ToDateTime(_Reservation.check_out_date);

            nupNumberOfNight.Value = (checkOutDate.Day - checkInDate.Day);

            lblTotalPrice.Text = "US $ " + (nupNumberOfNight.Value * CostPerNight).ToString();

            nupNumberOfNight.Enabled = false;

        }


        private void llAddPaymentCard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPaymentDetails frm = new frmPaymentDetails(frmPaymentDetails.enMode.AddNew);
            frm.ShowDialog();

        }


        private void llRoomDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowRoomDetails frm = new frmShowRoomDetails((int)_Room.room_id);
            frm.HideBtnFromCustomer();
            frm.ShowDialog();

        }


        private void numericInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allowing only numeric input
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ctrlPaymentDetailsCard1_OnPaymentDone(decimal NewTotoalAmount)
        {
            //create reservation
            if (!this.ValidateChildren())
            {
                bunifuSnackbar1.Show(this, "Something wrong check the filed and but valid data", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);

                return;
            }

            try
            {

                if (!string.IsNullOrEmpty(txtHour.Text.Trim()) && !string.IsNullOrEmpty(txtHour.Text.Trim()))
                {
                    _Reservation.arrived_time = new TimeSpan(int.Parse(txtHour.Text.Trim()), int.Parse(txtminut.Text.Trim()), 0);
                }
                else
                {
                    _Reservation.arrived_time = new TimeSpan(0, 0, 0);

                }
                _Reservation.number_of_nights = (int)nupNumberOfNight.Value;
                _Reservation.reservation_status = (int)clsReservation.enReservationStatus.Pending;
                _Reservation.special_request = txtSpecialRequest.Text.Trim();
                _Reservation.customer_id = clsCurrentCustomer.customerInfo.CustomerID;
                _Reservation.reservation_date = DateTime.Now;
                _Reservation.room_id = _Room.room_id;
                _Reservation.reservation_cost = (clsRoomType.FindRoomTypeByID((int)clsRoom.FindRoomByID((int)_Reservation.room_id).room_type_id).cost_per_night * nupNumberOfNight.Value);

                if (_Reservation.Save())
                    bunifuSnackbar1.Show(this, "Reservation done successfully, we will send you a message to confirm it", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                else
                    bunifuSnackbar1.Show(this, "Reservation Fails , something wrong", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
            catch (Exception ex)
            {
                bunifuSnackbar1.Show(this, "Reservation faild Because -" + ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }

        private void txtHour_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtHour.Text.Trim().Length >= 2 && int.Parse(txtHour.Text.Trim()) <= 12 && int.Parse(txtHour.Text.Trim()) > 0)
            {
                errorProvider1.SetError(txtHour, "enter valid time less than 12 hour");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtHour, null);
        }

        private void txtminut_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtminut.Text.Trim().Length >= 2 && int.Parse(txtminut.Text.Trim()) <= 60 && int.Parse(txtminut.Text.Trim()) > 0)
            {
                errorProvider1.SetError(txtminut, "enter valid time less than 60 min");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(txtminut, null);
        }
    }
}
