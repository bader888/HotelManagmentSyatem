using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using HotelManagmentSyatem.Room;
using HotelManagmentSyatem.Room.Room_Rate;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Reservation.Controls
{
    public partial class ctrlCustomerBookingRoomCard : UserControl
    {
        public ctrlCustomerBookingRoomCard()
        {
            InitializeComponent();
        }

        public delegate void CancelHandler(int ReservationID);
        public delegate void RemoveHandler(int ReservationID);
        public delegate void BookingAgainHandler(int ReservationID);

        public event CancelHandler OnCancelDone;
        public event CancelHandler OnRemoveDone;
        public event CancelHandler OnBookingAgainDone;




        clsReservation reservation = new clsReservation();
        private void _resetDefualtValues()
        {
            lblCheckInCheckOut.Text = "[???] - [???]";
            lblReservationCost.Text = "[???]";
            lblReservationDate.Text = "[???]";
            lblReservationStatus.Text = "[???]";
            lblRoomNumber.Text = "[???]";
            lblRoomType.Text = "[???]";
        }

        public void _loadRoomImage()
        {
            DataTable RoomImages = clsRoomImage.GetAllImagesForRoomID((int)reservation.room_id);
            if (RoomImages.Rows.Count > 0)
            {
                try
                {
                    picRoom.Load(RoomImages.Rows[0]["imagePath"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error: image not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LoadReservationData(int ReservationID)
        {
            reservation = clsReservation.FindReservationByID(ReservationID);

            if (reservation != null)
            {
                lblCheckInCheckOut.Text = $"{clsFormat.DateCustomFormate((DateTime)reservation.check_in_date, "MMMM - dd")} - {clsFormat.DateCustomFormate((DateTime)reservation.check_out_date, "MMMM - dd")}";
                lblReservationCost.Text = "US $" + reservation.reservation_cost.ToString();
                lblReservationDate.Text = clsFormat.DateToFullDetailsWithOutTime((DateTime)reservation.reservation_date);
                lblReservationStatus.Text = clsReservation.dicReservationStatus[(int)reservation.reservation_status];
                lblRoomNumber.Text = reservation.RoomInfo.room_number.ToString();
                lblRoomType.Text = reservation.RoomInfo.RoomTypeInfo.type_name;

                _loadRoomImage();
                return;
            }

            _resetDefualtValues();

        }

        private void llRoomDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowRoomDetails frm = new frmShowRoomDetails((int)reservation.room_id);
            frm.HideBtnFromCustomer();
            frm.ShowDialog();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to Cancel the reservation with id = " + this.reservation.reservationID, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                reservation = clsReservation.FindReservationByID((int)reservation.reservationID);
                reservation.reservation_status = (int)clsReservation.enReservationStatus.Cancel;

                if (reservation.Save())
                {
                    OnCancelDone.Invoke((int)this.reservation.reservationID);

                }
            }
        }

        private void bookingAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to Booking Again the reservation with id = " + this.reservation.reservationID,
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                reservation = clsReservation.FindReservationByID((int)reservation.reservationID);
                reservation.reservation_status = (int)clsReservation.enReservationStatus.Pending;
                if (reservation.Save())
                {
                    OnBookingAgainDone.Invoke((int)this.reservation.reservationID);

                }

            }

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure to Remove the reservation with id = " + this.reservation.reservationID,
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                bool delete = clsReservation.DeleteReservation((int)this.reservation.reservationID);
                if (delete)
                    OnRemoveDone.Invoke((int)this.reservation.reservationID);

            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            removeToolStripMenuItem.Enabled = (reservation.reservation_status == (int)clsReservation.enReservationStatus.Cancel);
            bookingAgainToolStripMenuItem.Enabled = (reservation.reservation_status == (int)clsReservation.enReservationStatus.Cancel);
            cancelToolStripMenuItem.Enabled = (reservation.reservation_status == (int)clsReservation.enReservationStatus.Pending);

        }

        private void bunifuImageButton1_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Display the context menu strip at the mouse position
                contextMenuStrip1.Show(bunifuImageButton1, e.Location);
            }
        }

        private void rateRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {

            clsRoomRate roomRate = clsRoomRate.isCustomerRateThisRoom((int)clsCurrentCustomer.customerInfo.CustomerID,
            (int)reservation.room_id);
            if (roomRate == null)
            {
                frmCustomerRateRoom frm = new frmCustomerRateRoom(
                             (int)clsCurrentCustomer.customerInfo.CustomerID,
                             (int)reservation.room_id);
                frm.ShowDialog();
            }
            else
            {
                frmCustomerRateRoom frm = new frmCustomerRateRoom(
                        (int)roomRate.rateID,
                        (int)clsCurrentCustomer.customerInfo.CustomerID,
                        (int)reservation.room_id);
                frm.ShowDialog();
            }



        }
    }
}
