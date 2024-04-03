using HotelData;
using System;
using System.Data;

namespace HotelLogic
{
    public class clsHotel
    {
        public int? hotelID { set; get; }
        public string name { set; get; }
        public decimal? rate { set; get; }
        public string address { set; get; }
        public string description { set; get; }
        public bool? BreakfastIncluded { set; get; }
        enum enMode { AddNew, Update };
        enMode Mode = enMode.AddNew;

        //--Constructure1
        private clsHotel(int hotelID, string name, decimal? rate, string address, string description, bool BreakfastIncluded)
        {
            this.hotelID = hotelID;
            this.name = name;
            this.rate = rate;
            this.address = address;
            this.description = description;
            this.BreakfastIncluded = BreakfastIncluded;
            Mode = enMode.Update;
        }


        //--Constructure2
        public clsHotel()
        {
            this.hotelID = null;
            this.name = null;
            this.rate = null;
            this.address = null;
            this.description = null;
            this.BreakfastIncluded = null;
            Mode = enMode.AddNew;
        }

        public static DataTable GetAllhotels()
        {
            return clsHotelData.GetAllHotels();
        }

        static public clsHotel FindhotelByID(int hotelID)
        {
            DataTable dthotel = clsHotelData.FindHotelByID(hotelID);


            if (dthotel.Rows.Count > 0)
            {
                DataRow rowhotel = dthotel.Rows[0];//get the first row  

                return new clsHotel(
                       (int)rowhotel["hotelID"],
                       (string)rowhotel["name"],
                       Convert.ToDecimal(rowhotel["rate"].ToString()),
                       (string)rowhotel["address"],
                        rowhotel["description"] == DBNull.Value ? null : (string)rowhotel["description"],
                        (bool)rowhotel["BreakfastIncluded"]

                    );
            }
            else
                return null;
        }



        private bool _AddNewhotel()
        {
            //remove the id column
            this.hotelID = clsHotelData.AddNewHotel(
             (string)this.name,
             (decimal)this.rate,
             (string)this.address,
             (string)this.description,
             (bool)this.BreakfastIncluded
             );
            return (this.hotelID != -1);
        }

        private bool _Updatehotel()
        {
            return clsHotelData.UpdateHotel(
             (int)this.hotelID,
             (string)this.name,
             (decimal)this.rate,
             (string)this.address,
             (string)this.description,
             (bool)this.BreakfastIncluded
             );
        }


        public bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                return _AddNewhotel();
            }

            if (Mode == enMode.Update)
            {
                return _Updatehotel();
            }

            return false;
        }
    }
}
