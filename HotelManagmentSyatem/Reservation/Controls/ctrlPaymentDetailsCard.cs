using HotelLogic;
using System;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Reservation.Controls
{
    public partial class ctrlPaymentDetailsCard : UserControl
    {
        public ctrlPaymentDetailsCard()
        {
            InitializeComponent();
        }


        public delegate void PaymentHandler(decimal NewTotoalAmount);
        public event PaymentHandler OnPaymentDone;

        public enum enMode
        {
            AddNewPaymeny,
            Payment
        }

        private decimal _ReservationCost = 0;
        public decimal ReservationCost
        {
            set
            {
                _ReservationCost = value;
            }
        }

        enMode _Mode;

        public enMode Mode
        {
            get
            {
                return _Mode;
            }
            set
            {
                _Mode = value;
                btnSave.Visible = (_Mode == enMode.AddNewPaymeny);
                btnPayment.Visible = (_Mode == enMode.Payment);

            }
        }



        private void btnPayment_Click(object sender, System.EventArgs e)
        {


            OnPaymentDone.Invoke(10000);


        }

        public void LoadCardData()
        {


            clsPaymentCard paymentCard = clsPaymentCard.GetPaymentCardDetailsForCurrentCustomer();
            txtCardHolderName.Text = paymentCard.CardHolderName;
            txtCardNumber.Text = paymentCard.CardNumber;
            txtCVC.Text = paymentCard.CVC;
            dtpExpieryDate.Value = (DateTime)paymentCard.expieryDate;


        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            clsPaymentCard PaymentCard = new clsPaymentCard();
            PaymentCard.CardHolderName = txtCardHolderName.Text.Trim();
            PaymentCard.CardNumber = txtCardNumber.Text.Trim();
            PaymentCard.CVC = txtCVC.Text.Trim();
            PaymentCard.expieryDate = dtpExpieryDate.Value;
            PaymentCard.TotalAmount = 1000000;

            try
            {
                PaymentCard.Save();
                MessageBox.Show("Save Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Fails " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
