using HotelData;
using System.Collections.Generic;
using System.Data;

namespace HotelLogic
{
    public class clsRoomRate
    {


        //--PROPARTIES
        public int? rateID { set; get; }
        public int? roomID { set; get; }
        public int? customerID { set; get; }
        public string description { set; get; }
        public decimal? score { set; get; }

        private clsRoom _Room = new clsRoom();
        private clsCustomer _Csutomer = new clsCustomer();
        public clsRoom roomInfo
        {
            get
            {
                return _Room;

            }
        }

        public clsCustomer CustomerInFo
        {
            get
            {
                return _Csutomer;

            }
        }


        public enum enMode { Update, AddNew }
        public enMode Mode = enMode.AddNew;


        //--Constructure1
        private clsRoomRate(
            int rateID,
            int roomID,
            int customerID,
            string description,
            decimal score)
        {
            this.rateID = rateID;
            this.roomID = roomID;
            this.customerID = customerID;
            this.description = description;
            this.score = score;
            _Csutomer = clsCustomer.FindCustomerByID((int)this.customerID);
            _Room = clsRoom.FindRoomByID((int)this.roomID);

            Mode = enMode.Update;
        }

        //--Constructure2
        public clsRoomRate()
        {
            this.rateID = null;
            this.roomID = null;
            this.customerID = null;
            this.description = null;
            this.score = null;
            Mode = enMode.AddNew;
        }


        //--UPDATE 
        private bool _UpdateRoomRate()
        {
            return clsRoomRateData.UpdateRoomRate(
             (int)this.rateID,
             (int)this.roomID,
             (int)this.customerID,
             (string)this.description,
             (decimal)this.score
             );
        }
        private bool _AddNewRoomRate()
        {
            this.rateID = clsRoomRateData.AddNewRoomRate(
                            (int)this.roomID,
                            (int)this.customerID,
                            (string)this.description,
                            (decimal)this.score
                            );
            return this.rateID != -1;

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewRoomRate())
                        {

                            this.Mode = enMode.Update;

                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.Update:
                    {
                        return _UpdateRoomRate();

                    }
                default:
                    return false;

            }
        }

        //--FIND 
        static public clsRoomRate FindRoomRateByID(int RoomRateID)
        {
            DataTable dtRoomRate = clsRoomRateData.FindRoomRateByID(RoomRateID);
            if (dtRoomRate.Rows.Count > 0)
            {
                DataRow rowRoomRate = dtRoomRate.Rows[0];//get the first row  

                return new clsRoomRate(
                       (int)rowRoomRate["rateID"],
                            (int)rowRoomRate["roomID"],
                            (int)rowRoomRate["customerID"],
                            (string)rowRoomRate["description"],
                            (decimal)rowRoomRate["score"]
                    );
            }
            else
                return null;
        }

        static public clsRoomRate isCustomerRateThisRoom(int CustomerID, int RoomID)
        {
            DataTable dtRoomRate = clsRoomRateData.FindRoomRateByCustomerIDAndRoomID(CustomerID, RoomID);
            if (dtRoomRate.Rows.Count > 0)
            {
                DataRow rowRoomRate = dtRoomRate.Rows[0];//get the first row  

                return new clsRoomRate(
                       (int)rowRoomRate["rateID"],
                            (int)rowRoomRate["roomID"],
                            (int)rowRoomRate["customerID"],
                            (string)rowRoomRate["description"],
                            (decimal)rowRoomRate["score"]
                    );
            }
            else
                return null;
        }



        //--GET ALL 
        public static DataTable GetAllRoomRate()
        {
            return clsRoomRateData.GetAllRoomsRate();
        }

        public static List<clsRoomRate> GetAllRoomRateToList()
        {
            DataTable dtRoomRate = clsRoomRateData.GetAllRoomsRate();
            if (dtRoomRate.Rows.Count == 0)
            {
                return new List<clsRoomRate>();
            }

            List<clsRoomRate> listRoomRate = new List<clsRoomRate>();

            foreach (DataRow row in clsRoomRateData.GetAllRoomsRate().Rows)
            {
                clsRoomRate roomrate = new clsRoomRate();
                roomrate.rateID = row.Field<int>("RateID");
                roomrate.roomID = row.Field<int>("RoomID");
                roomrate.customerID = row.Field<int>("customerID");
                roomrate.description = row.Field<string>("description");
                roomrate.score = row.Field<decimal>("score");

                listRoomRate.Add(roomrate);

            }

            return listRoomRate;

        }

    }
}
