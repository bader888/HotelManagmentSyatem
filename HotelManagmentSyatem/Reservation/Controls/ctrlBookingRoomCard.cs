using HotelLogic;
using HotelManagmentSyatem.Room;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Reservation.Controls
{
    public partial class ctrlBookingRoomCard : UserControl
    {
        private clsRoom _Room;
        private clsReservation _Reservation = new clsReservation();
        private int _RoomID = -1;
        public int RoomID
        {
            get { return _RoomID; }
        }

        public clsReservation ReservationInfo
        {
            get
            {
                return _Reservation;
            }

            set
            {
                _Reservation = value;
            }
        }

        public clsRoom SelectedRoomInfo
        {
            get { return _Room; }
        }

        public ctrlBookingRoomCard(int RoomID)
        {
            InitializeComponent();
            _RoomID = RoomID;

        }
        public ctrlBookingRoomCard()
        {
            InitializeComponent();

        }

        public void LoadRoomInfo(int RoomID)
        {
            _Room = clsRoom.FindRoomByID(RoomID);
            if (_Room == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Room with RoomID = " + RoomID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillRoomInfo();
        }

        private void _FillRoomInfo()
        {
            _RoomID = (int)_Room.room_id;

            lblBedNumber.Text = _Room.number_of_beds.ToString();
            lblisPetsFriendly.Text = _Room.is_pet_friendly == true ? "Yes" : "No";
            lblSmokingAllowed.Text = _Room.is_smoking_allowed == true ? "Yes" : "No";
            lblPrice.Text = "US $ " + _Room.RoomTypeInfo.cost_per_night.ToString();
            lblRoomType.Text = _Room.RoomTypeInfo.type_name;
            lblRoomNumber.Text = _Room.room_number.ToString();
            if (_Room.room_rate != null)
                roomRating.Value = Convert.ToInt32(_Room.room_rate);
            //fill room image

            DataTable dtRoomImages = clsRoomImage.GetAllImagesForRoomID(_RoomID);
            if (dtRoomImages.Rows.Count > 0)
                picRoomImage.Load(dtRoomImages.Rows[0]["imagePath"].ToString());

        }

        public void ResetPersonInfo()
        {
            _RoomID = -1;
            lblBedNumber.Text = "[????]";
            lblisPetsFriendly.Text = "[????]";
            lblPrice.Text = "[????]";
            lblRoomType.Text = "[????]";
            lblSmokingAllowed.Text = "[????]";
            roomRating.Value = 0;
            lblRoomNumber.Text = "[????]";

            //resert room images

        }

        private void llSeeMoreDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowRoomDetails frm = new frmShowRoomDetails((int)this._Room.room_id);
            frm.ShowDialog();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmPaymentForBookingRoom frm = new frmPaymentForBookingRoom(_Room, _Reservation);
            frm.ShowDialog();


        }
    }
}
