using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using HotelManagmentSyatem.Reservation.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Reservation
{
    public partial class frmCustomerBookingAndTrip : Form
    {
        public frmCustomerBookingAndTrip()
        {
            InitializeComponent();
        }

        private void frmCustomerBookingAndTrip_Load(object sender, EventArgs e)
        {
            DataTable dtAllReservationsForCustomer = clsReservation.GetAllReservationForCustomer((int)clsCurrentCustomer.customerInfo.CustomerID);

            if (dtAllReservationsForCustomer.Rows.Count > 0)
            {
                foreach (DataRow row in dtAllReservationsForCustomer.Rows)
                {
                    ctrlCustomerBookingRoomCard customerBookingRoomCard = CreateCtrlCustomerBookingRoomCard((int)row["ReservationID"]);
                    flowLayoutPanel1.Controls.Add(customerBookingRoomCard);
                }
            }
        }

        private void RemoveReservationFromFlp(int ReservationID)
        {
            //remove the control from the flp
            Control[] cbr = flowLayoutPanel1.Controls.Find(ReservationID.ToString(), true);
            flowLayoutPanel1.Controls.Remove(cbr[0]);
        }

        private ctrlCustomerBookingRoomCard CreateCtrlCustomerBookingRoomCard(int ReservationID)
        {
            ctrlCustomerBookingRoomCard customerBookingRoomCard = new ctrlCustomerBookingRoomCard();
            customerBookingRoomCard.OnCancelDone += ReservationCancel;
            customerBookingRoomCard.OnRemoveDone += ReservationRemove;
            customerBookingRoomCard.OnBookingAgainDone += ReservationBookingAgain;
            customerBookingRoomCard.LoadReservationData(ReservationID);
            customerBookingRoomCard.Name = ReservationID.ToString();
            return customerBookingRoomCard;
        }

        private void ReservationCancel(int ReservationID)
        {

            //remove the control from the flp
            RemoveReservationFromFlp(ReservationID);

            //add the control to the flp with new status  
            ctrlCustomerBookingRoomCard customerBookingRoomCard = CreateCtrlCustomerBookingRoomCard(ReservationID);
            flowLayoutPanel1.Controls.Add(customerBookingRoomCard);
            bunifuSnackbar1.Show(this, "booking Cancel Successfuly", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);

        }

        private void ReservationRemove(int ReservationID)
        {
            RemoveReservationFromFlp(ReservationID);

            bunifuSnackbar1.Show(this, "booking Remove Successfuly", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);

        }

        private void ReservationBookingAgain(int ReservationID)
        {
            RemoveReservationFromFlp(ReservationID);

            //add the control to the flp with new status  
            ctrlCustomerBookingRoomCard customerBookingRoomCard = CreateCtrlCustomerBookingRoomCard(ReservationID);
            flowLayoutPanel1.Controls.Add(customerBookingRoomCard);

            bunifuSnackbar1.Show(this, "booking Again Done Successfuly", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);

        }
    }
}
