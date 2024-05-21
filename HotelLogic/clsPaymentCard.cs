using HotelData;
using System;

namespace HotelLogic
{
    public class clsPaymentCard
    {
        public string CardHolderName
        {
            get; set;
        }
        public string CardNumber
        {
            get; set;
        }
        public string CVC
        {
            get; set;
        }

        public decimal TotalAmount
        {
            get; set;

        }

        public DateTime? expieryDate
        {
            get; set;

        }

        public clsPaymentCard()
        {
            CardHolderName = null;
            CardNumber = null;
            CVC = null;
            TotalAmount = -1;
            expieryDate = null;
        }
        public clsPaymentCard(string CardHolderName, string CardNumber, string CVC, decimal TotalAmount, DateTime expieryDate)
        {
            this.CardHolderName = CardHolderName;
            this.CardNumber = CardNumber;
            this.CVC = CVC;
            this.TotalAmount = TotalAmount;
            this.expieryDate = expieryDate;

        }


        public void Save()
        {
            clsPaymentCardData.SavePaymentCardForCurrentUser(this.CardHolderName, this.CardNumber, this.CVC, this.TotalAmount.ToString(), this.expieryDate.ToString());
        }

        static public clsPaymentCard GetPaymentCardDetailsForCurrentCustomer()
        {
            string CardHolderName = null;
            string CardNumber = null;
            string cvc = null;
            decimal totalAmount = 0;
            DateTime expieryDate = DateTime.Now;
            clsPaymentCardData.GetPaymentCardFromRegistry(ref CardHolderName, ref CardNumber, ref cvc, ref totalAmount, ref expieryDate);

            return new clsPaymentCard(CardHolderName, CardNumber, cvc, totalAmount, expieryDate);

        }


    }
}
