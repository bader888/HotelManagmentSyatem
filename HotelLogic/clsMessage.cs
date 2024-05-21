using HotelData;
using System;
using System.Data;

namespace HotelLogic
{
    public class clsMessage
    {

        //--PROPARTIES
        public int? messageID { set; get; }
        public int? UserID { set; get; }
        public int? CustomerID { set; get; }
        public string MsgSubject { set; get; }
        public string MsgBody { set; get; }
        public DateTime? MsgDate { set; get; }

        public enum enMode
        {
            AddNew,
            Update
        }

        enMode Mode = enMode.AddNew;
        //--Constructure1
        private clsMessage(int messageID, string MsgSubject, string MsgBody, DateTime? MsgDate)
        {
            this.messageID = messageID;
            this.MsgSubject = MsgSubject;
            this.MsgBody = MsgBody;
            this.MsgDate = MsgDate;
            Mode = enMode.Update;
        }

        //--Constructure2
        public clsMessage()
        {
            this.messageID = null;
            this.MsgSubject = null;
            this.MsgBody = null;
            this.MsgDate = null;
            this.UserID = null;
            this.CustomerID = null;
            Mode = enMode.AddNew;
        }



        public bool Send()
        {
            this.messageID =
                clsMessageData.AddNewMessage(this.MsgSubject, this.MsgBody, this.MsgDate, this.UserID, this.CustomerID);

            return this.messageID != -1;
        }


        //--FIND 
        static public clsMessage FindMessageByID(int MessageID)
        {
            DataTable dtMessage = clsMessageData.FindMessageByID(MessageID);
            if (dtMessage.Rows.Count > 0)
            {
                DataRow rowMessage = dtMessage.Rows[0];//get the first row  

                return new clsMessage(
                       rowMessage.Field<int>("MessageID"),
                       rowMessage.Field<string>("msgSubject"),
                       rowMessage.Field<string>("MsgBody"),
                       rowMessage.Field<DateTime>("MsgDate")
                    );
            }
            else
                return null;
        }

        //--GET ALL 
        public static DataTable GetAllMessageForCustomerID(int CustomerID)
        {
            return clsMessageData.GetAllMessagesForCustomerByID(CustomerID);
        }

        //--IS EXISTS 
        //public static bool isMessageExist(int MessageID)
        //{
        //    return clsMessageData.IsMessageExist(MessageID);
        //});


        //__DELETE
        //public static bool DeleteMessage(int MessageID)
        //{
        //    return clsMessageData.DeleteMessage(MessageID);
        //}

        //--UPDATE 
        //        private bool _UpdateMessage()
        //        {
        //            return clsMessageData.UpdateMessage(
        //             (int)this.messageID,
        //(string)this.MsgSubject,
        //(string)this.MsgBody,
        //(DateTime)this.MsgDate
        //);
        //        }

        ////--DELETE 
        //public static bool DeleteMessage(int MessageID)
        //{
        //    return clsMessageData.DeleteMessage(MessageID);
        //}

    }
}
