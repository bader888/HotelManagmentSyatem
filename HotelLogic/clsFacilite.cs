using HotelData;
using System;
using System.Collections.Generic;
using System.Data;

namespace HotelLogic
{
    public class clsFacilite
    {

        //--PROPARTIES
        public int? ID { set; get; }
        public string Name { set; get; }
        public string IconUrl { set; get; }
        enum enMode
        {
            AddNew,
            Update
        }

        enMode Mode = enMode.AddNew;

        //--Constructure1
        private clsFacilite(int ID, string Name, string IconUrl)
        {
            this.ID = ID;
            this.Name = Name;
            this.IconUrl = IconUrl;
            Mode = enMode.Update;
        }

        //--Constructure2
        public clsFacilite()
        {
            this.ID = null;
            this.Name = null;
            this.IconUrl = null;
            Mode = enMode.AddNew;
        }

        public static DataTable GetAllFacilitie()
        {
            return clsFacilitieData.GetAllFacilities();
        }

        public static List<clsFacilite> GetClsFacilites()
        {
            DataTable dt = clsFacilitieData.GetAllFacilities();
            List<clsFacilite> List = new List<clsFacilite>();

            foreach (DataRow row in dt.Rows)
            {
                clsFacilite facilite = new clsFacilite();
                facilite.ID = (int)row["ID"];
                facilite.Name = (string)row["Name"];
                facilite.IconUrl = row["IconUrl"] == DBNull.Value ? string.Empty : (string)row["IconUrl"];
                List.Add(facilite);
            }

            return List;
        }

        private bool _AddNewFacilitie()
        {

            this.ID = clsFacilitieData.AddNewFacilitie(
            (string)this.Name,
            (string)this.IconUrl
            );
            return (this.ID != -1);
        }

        private bool _UpdateFacilitie()
        {
            return clsFacilitieData.UpdateFacilitie(
             (int)this.ID,
             (string)this.Name,
             (string)this.IconUrl
             );
        }

        public bool save()
        {
            if (Mode == enMode.AddNew)
            {
                Mode = enMode.Update;
                return _AddNewFacilitie();
            }
            else
            {
                return _UpdateFacilitie();
            }


        }

        static public clsFacilite FindFacilitieByID(int FacilitieID)
        {
            DataTable dtFacilitie = clsFacilitieData.FindFacilitieByID(FacilitieID);
            if (dtFacilitie.Rows.Count > 0)
            {
                DataRow rowFacilitie = dtFacilitie.Rows[0];//get the first row  

                return new clsFacilite(
                       (int)rowFacilitie["ID"],
                            (string)rowFacilitie["Name"],
                            rowFacilitie["IconUrl"] == DBNull.Value ? null : (string)rowFacilitie["IconUrl"]
                    );
            }
            else
                return null;
        }

        public static bool DeleteFacilitie(int FacilitieID)
        {
            return clsFacilitieData.DeleteFacilitie(FacilitieID);
        }
    }
}
