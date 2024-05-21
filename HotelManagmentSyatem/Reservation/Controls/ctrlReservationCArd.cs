using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using HotelManagmentSyatem.Properties;
using HotelManagmentSyatem.Room;
using System;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Reservation.Controls
{
    public partial class ctrlReservationCArd : UserControl
    {


        private clsReservation _Reservation;
        private int __ReservationID = -1;
        public int ReservationID
        {
            get { return __ReservationID; }
        }

        public clsReservation SelectedReservationInfo
        {
            get { return _Reservation; }
        }



        public ctrlReservationCArd()
        {
            InitializeComponent();
        }


        public void LoadReservationInfo(int ReservationID)
        {
            _Reservation = clsReservation.FindReservationByID(ReservationID);
            if (_Reservation == null)
            {
                ResetReservationInfo();
                MessageBox.Show("No Reservation with ReservationID = " + ReservationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return;
            }

            _FillReservationInfo();
        }



        private void _FillReservationInfo()
        {
            __ReservationID = (int)_Reservation.reservationID;
            lblArriveTIme.Text = _Reservation.arrived_time.ToString();
            lblCheckinDate.Text = clsFormat.DateToFullDetailsWithOutTime((DateTime)_Reservation.check_in_date);
            lblCheckOutDate.Text = clsFormat.DateToFullDetailsWithOutTime((DateTime)_Reservation.check_out_date);
            lblCost.Text = "US $ " + _Reservation.reservation_cost;
            lblNumberOFNight.Text = _Reservation.number_of_nights.ToString();
            lblReservationDate.Text = clsFormat.DateToFullDetailsWithOutTime((DateTime)_Reservation.reservation_date);
            lblReservationID.Text = _Reservation.reservationID.ToString();
            lblRoomID.Text = _Reservation.room_id.ToString();
            lblSpecialRequest.Text = _Reservation.special_request ?? "None";
            lblStatus.Text = clsReservation.dicReservationStatus[(int)_Reservation.reservation_status];

            if (_Reservation.reservation_status == (byte)clsReservation.enReservationStatus.Cancel)
            {
                picStatus.Image = Resources.CancelBooking;
            }
            else if (_Reservation.reservation_status == (byte)clsReservation.enReservationStatus.Confirmed)
            {
                picStatus.Image = Resources.correct;
            }
            else if (_Reservation.reservation_status == (byte)clsReservation.enReservationStatus.Pending)
            {
                picStatus.Image = Resources.time;

            }
            else
            {
                picStatus.Image = Resources.questions;

            }
        }

        public void ResetReservationInfo()
        {
            __ReservationID = -1;
            lblArriveTIme.Text = "[????]";
            lblCheckinDate.Text = "[????]";
            lblCheckOutDate.Text = "[????]";
            lblCost.Text = "[????]";
            lblNumberOFNight.Text = "[????]";
            lblReservationDate.Text = "[????]";
            lblReservationID.Text = "[????]";
            lblRoomID.Text = "[????]";
            lblSpecialRequest.Text = "[????]";
            lblStatus.Text = "[????]";

        }

        private void llRoomID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowRoomDetails frm = new frmShowRoomDetails((int)_Reservation.room_id);
            frm.ShowDialog();

        }
    }
}
