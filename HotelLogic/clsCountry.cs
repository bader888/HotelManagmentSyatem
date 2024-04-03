using HotelData;
using System;
using System.Data;

namespace HotelLogic
{
    public class clsCountry
    {

        //--PROPARTIES
        public int? CountryID { set; get; }
        public string CountryName { set; get; }



        //--Constructure1
        private clsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;

        }

        //--Constructure2
        public clsCountry()
        {
            this.CountryID = null;
            this.CountryName = null;
        }

        static public clsCountry FindCountryByID(int CountryID)
        {
            DataTable dtCountry = clsCountryData.FindCountryByID(CountryID);
            if (dtCountry.Rows.Count > 0)
            {
                DataRow rowCountry = dtCountry.Rows[0];//get the first row  

                return new clsCountry(
                       (int)rowCountry["CountryID"],
                            rowCountry["CountryName"] == DBNull.Value ? null : (string)rowCountry["CountryName"]
                    );
            }
            else
                return null;
        }

        static public clsCountry FindCountry(string CountryName)
        {
            DataTable dtCountry = clsCountryData.FindCountryByName(CountryName);
            if (dtCountry.Rows.Count > 0)
            {
                DataRow rowCountry = dtCountry.Rows[0];//get the first row  

                return new clsCountry(
                       (int)rowCountry["CountryID"],
                            rowCountry["CountryName"] == DBNull.Value ? null : (string)rowCountry["CountryName"]
                    );
            }
            else
                return null;
        }


        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }

    }
}
