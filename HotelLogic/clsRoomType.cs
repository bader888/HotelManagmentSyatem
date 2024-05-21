using HotelData;
using System.Data;

namespace HotelLogic
{
    public class clsRoomType
    {


        //--PROPARTIES
        public int? type_id { set; get; }
        public string type_name { set; get; }
        public decimal? cost_per_night { set; get; }
        enum enMode
        {
            AddNew,
            Update
        }
        enMode Mode = enMode.AddNew;

        //--Constructure1
        private clsRoomType(int type_id, string type_name, decimal cost_per_night)
        {
            this.type_id = type_id;
            this.type_name = type_name;
            this.cost_per_night = cost_per_night;
            Mode = enMode.Update;
        }

        //--Constructure2
        public clsRoomType()
        {
            this.type_id = null;
            this.type_name = null;
            this.cost_per_night = null;
            Mode = enMode.AddNew;
        }


        //__DELETE
        public static bool DeleteRoomType(int RoomTypeID)
        {
            return clsRoomTypeData.DeleteRoomType(RoomTypeID);
        }

        //--UPDATE 
        private bool _UpdateRoomType()
        {
            return clsRoomTypeData.UpdateRoomType(
             (int)this.type_id,
             (string)this.type_name,
             (decimal)this.cost_per_night);
        }

        //--UPDATE 
        private bool _AddNeweRoomType()
        {
            this.type_id = clsRoomTypeData.AddNewRoomType(
             (string)this.type_name,
             (decimal)this.cost_per_night);

            return this.type_id != -1;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        Mode = enMode.Update;
                        return _AddNeweRoomType();
                    }
                case enMode.Update:
                    {
                        return _UpdateRoomType();
                    }
                default:
                    return false;
            }
        }


        //--GET ALL 
        public static DataTable GetAllRoomType()
        {
            return clsRoomTypeData.GetAllRoomTypes();
        }

        //-FIND BY ID 
        static public clsRoomType FindRoomTypeByID(int RoomTypeID)
        {
            DataTable dtRoomType = clsRoomTypeData.FindRoomTypeByID(RoomTypeID);
            if (dtRoomType.Rows.Count > 0)
            {
                DataRow rowRoomType = dtRoomType.Rows[0];//get the first row  

                return new clsRoomType(
                       (int)rowRoomType["type_id"],
                            (string)rowRoomType["type_name"],
                            (decimal)rowRoomType["cost_per_night"]
                    );
            }
            else
                return null;
        }

        static public clsRoomType FindRoomTypeByName(string Name)
        {
            DataTable dtRoomType = clsRoomTypeData.FindRoomTypeName(Name);
            if (dtRoomType.Rows.Count > 0)
            {
                DataRow rowRoomType = dtRoomType.Rows[0];//get the first row  

                return new clsRoomType(
                       (int)rowRoomType["type_id"],
                            (string)rowRoomType["type_name"],
                            (decimal)rowRoomType["cost_per_night"]
                    );
            }
            else
                return null;
        }

    }
}
