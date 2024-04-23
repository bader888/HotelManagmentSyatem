using HotelData;
using System;
using System.Data;

namespace HotelLogic
{
    public class clsReservation
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode Mode = enMode.AddNew;

        enum enReservationStatus
        {
            Pending = 1,
            Confirmed = 2,
            Cancel = 3,
            Completed = 4
        }

        //--PROPARTIES 
        public int? reservationID { set; get; }

        public int? customer_id { set; get; }

        public int? room_id { set; get; }

        public DateTime? check_in_date { set; get; }

        public DateTime? check_out_date { set; get; }

        public int? number_of_nights { set; get; }

        public string special_request { set; get; }

        public TimeSpan? arrived_time { set; get; }

        public byte? reservation_status { set; get; }

        public DateTime? reservation_date { set; get; }

        private clsCustomer _CustomerInfo = new clsCustomer();

        public clsCustomer CustomerInfo
        {
            get
            {
                return _CustomerInfo;
            }
        }

        private clsRoom _RoomInfo = new clsRoom();

        public clsRoom RoomInfo
        {
            get
            {
                return _RoomInfo;
            }
        }

        //--Constructure1
        private clsReservation(int reservationID, int customer_id, int room_id, DateTime check_in_date, DateTime check_out_date, int number_of_nights, string special_request, TimeSpan? arrived_time, byte reservation_status, DateTime reservation_date)
        {
            this.reservationID = reservationID;
            this.customer_id = customer_id;
            this.room_id = room_id;
            this.check_in_date = check_in_date;
            this.check_out_date = check_out_date;
            this.number_of_nights = number_of_nights;
            this.special_request = special_request;
            this.arrived_time = arrived_time;
            this.reservation_status = reservation_status;
            this.reservation_date = reservation_date;
            this._CustomerInfo = clsCustomer.FindCustomerByID((int)this.customer_id);
            this._RoomInfo = clsRoom.FindRoomByID((int)this.room_id);
            Mode = enMode.Update;
        }

        //--Constructure2
        public clsReservation()
        {
            this.reservationID = null;
            this.customer_id = null;
            this.room_id = null;
            this.check_in_date = null;
            this.check_out_date = null;
            this.number_of_nights = null;
            this.special_request = null;
            this.arrived_time = null;
            this.reservation_status = null;
            this.reservation_date = null;
            Mode = enMode.AddNew;
        }

        //__DELETE
        public static bool DeleteReservation(int ReservationID)
        {
            return clsReservationData.DeleteReservations(ReservationID);
        }

        //--UPDATE 
        private bool _UpdateReservation()
        {
            return clsReservationData.UpdateReservation(
             (int)this.reservationID,
             (int)this.customer_id,
             (int)this.room_id,
             (DateTime)this.check_in_date,
             (DateTime)this.check_out_date,
             (int)this.number_of_nights,
             (string)this.special_request,
             (TimeSpan)this.arrived_time,
             (byte)this.reservation_status
             );
        }

        //--ADD  
        private bool _AddNewReservation()
        {
            this.reservationID = clsReservationData.AddNewReservation(
             (int)this.customer_id,
             (int)this.room_id,
             (DateTime)this.check_in_date,
             (DateTime)this.check_out_date,
             (int)this.number_of_nights,
             (string)this.special_request,
             (TimeSpan)this.arrived_time,
             (byte)this.reservation_status
             );

            return this.reservationID != -1;
        }

        //--FIND 
        static public clsReservation FindReservationByID(int ReservationID)
        {
            DataTable dtReservation = clsReservationData.FindReservationsByID(ReservationID);
            if (dtReservation.Rows.Count > 0)
            {
                DataRow rowReservation = dtReservation.Rows[0];//get the first row  


                return new clsReservation(
                       (int)rowReservation.Field<int>("reservationID"),
                            (int)rowReservation["customer_id"],
                            (int)rowReservation["room_id"],
                            (DateTime)rowReservation["check_in_date"],
                            (DateTime)rowReservation["check_out_date"],
                            (int)rowReservation["number_of_nights"],
                            rowReservation.Field<string>("special_request"),
                            rowReservation.Field<TimeSpan>("arrived_time"),
                            (byte)rowReservation["reservation_status"],
                            (DateTime)rowReservation["reservation_date"]
                    );
            }
            else
                return null;
        }

        //--GET ALL 
        public static DataTable GetAllReservation()
        {
            return clsReservationData.GetAllreservations();
        }

        //--IS EXISTS 
        public static bool IsCustomerHavePendingReservationForRoomNumber(int RoomNumber, int CustomerID)
        {
            return clsReservationData.IsCustomerHavePendingReservationForRoomNumber(RoomNumber, CustomerID);
        }

        //-SAVE
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        Mode = enMode.Update;
                        return _AddNewReservation();
                    }
                case enMode.Update:
                    {
                        return _UpdateReservation();
                    }
                default:
                    return false;
            }
        }
    }
}
