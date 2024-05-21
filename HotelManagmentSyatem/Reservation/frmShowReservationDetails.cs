using System;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Reservation
{
    public partial class frmShowReservationDetails : Form
    {
        int _reservationID = default;//0

        public frmShowReservationDetails(int ReservationID)
        {
            InitializeComponent();
            _reservationID = ReservationID;


        }



        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowReservationDetails_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.LoadPersonInfo(_reservationID);
            ctrlReservationCArd1.LoadReservationInfo(_reservationID);

        }
    }
}
