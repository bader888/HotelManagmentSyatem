using HotelData;
using System.Collections.Generic;
using System.Data;

namespace HotelLogic
{
    public class clsRoom
    {
        //--PROPARTIES
        public int? room_id { set; get; }
        public int? room_type_id { set; get; }
        public byte? room_status { set; get; }
        public decimal? room_rate { set; get; }
        public string room_description { set; get; }
        public byte? room_size { set; get; }
        public bool? is_pet_friendly { set; get; }
        public bool? is_smoking_allowed { set; get; }
        public int? number_of_people { set; get; }
        public byte? room_view { set; get; }
        public int? room_number { set; get; }
        public int? number_of_beds { set; get; }

        static public Dictionary<int, string> RoomView = new Dictionary<int, string>
        {
            {1,"Balcony" },
            {2,"Garden" },
            {3,"Pool" },
            {4,"City" },
        };

        public enum enRoomView
        {
            Balcony,
            Garden,
            Pool,
            City
        }


        static public Dictionary<int, string> RoomSize = new Dictionary<int, string>
        {
            {1,"small" },
            {2,"medium" },
            {3,"large" }
        };

        public enum enRoomSize
        {
            small,
            medium,
            large
        }

        static public Dictionary<int, string> RoomStatus = new Dictionary<int, string>
        {
            {1,"Available" },
            {2,"Occupied" },
            {3,"Reserved" },
            {4,"OutofService" },
            {5,"UnderMaintenance" },
            {6,"CleanUp" }
        };

        public enum enRoomStatus
        {
            Available,
            Occupied,
            Reserved,
            OutofService,
            UnderMaintenance,
            CleanUp,

        }

        enum enMode { AddNew, Update }

        enMode Mode = enMode.AddNew;

        //--Constructure1
        private clsRoom(int room_id,
            int room_type_id,
            byte? room_status,
            decimal? room_rate,
            string room_description,
            byte? room_size,
            bool is_pet_friendly,
            bool is_smoking_allowed,
            int number_of_people,
            byte? room_view,
            int room_number,
            int number_of_beds)
        {
            this.room_id = room_id;
            this.room_type_id = room_type_id;
            this.room_status = room_status;
            this.room_rate = room_rate;
            this.room_description = room_description;
            this.room_size = room_size;
            this.is_pet_friendly = is_pet_friendly;
            this.is_smoking_allowed = is_smoking_allowed;
            this.number_of_people = number_of_people;
            this.room_view = room_view;
            this.room_number = room_number;
            this.number_of_beds = number_of_beds;
            Mode = enMode.Update;
        }

        //--Constructure2
        public clsRoom()
        {
            this.room_id = null;
            this.room_type_id = null;
            this.room_status = null;
            this.room_rate = null;
            this.room_description = null;
            this.room_size = null;
            this.is_pet_friendly = null;
            this.is_smoking_allowed = null;
            this.number_of_people = null;
            this.room_view = null;
            this.room_number = null;
            this.number_of_beds = null;
            Mode = enMode.AddNew;
        }

        //__DELETE
        public static bool DeleteRoom(int RoomID)
        {
            return clsRoomData.DeleteRoom(RoomID);
        }

        //--UPDATE 
        private bool _UpdateRoom()
        {
            return clsRoomData.UpdateRoom(
             (int)this.room_id,
             (int)this.room_type_id,
              1,
             this.room_rate,
             (string)this.room_description,
             (byte)this.room_size,
             (bool)this.is_pet_friendly,
             (bool)this.is_smoking_allowed,
             (int)this.number_of_people,
             (byte)this.room_view,
             (int)this.room_number,
             (int)this.number_of_beds
             );
        }

        //--ADD NEW 
        private bool _AddNewRoom()
        {
            this.room_id = clsRoomData.AddNewRoom(
             (int)this.room_type_id,
             this.room_status,
             this.room_rate,
             (string)this.room_description,
             (byte)this.room_size,
             (bool)this.is_pet_friendly,
             (bool)this.is_smoking_allowed,
             (int)this.number_of_people,
             (byte)this.room_view,
             (int)this.room_number,
             (int)this.number_of_beds
             );

            return this.room_id != -1;
        }

        //-SAVE
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        Mode = enMode.Update;
                        return _AddNewRoom();
                    }
                case enMode.Update:
                    {
                        return _UpdateRoom();
                    }
                default:
                    return false;
            }
        }

        //--FIND 
        static public clsRoom FindRoomByID(int RoomID)
        {
            DataTable dtRoom = clsRoomData.FindRoomByID(RoomID);
            if (dtRoom.Rows.Count > 0)
            {
                DataRow row = dtRoom.Rows[0];//get the first row  

                return new clsRoom(
                   row.Field<int>("room_id"),
                   row.Field<int>("room_type_id"),
                   row.Field<byte?>("room_status"),
                   row.Field<decimal?>("room_rate"),
                   row.Field<string>("room_description"),
                   row.Field<byte?>("room_size"),
                   row.Field<bool>("is_pet_friendly"),
                   row.Field<bool>("is_smoking_allowed"),
                   row.Field<int>("number_of_people"),
                   row.Field<byte>("room_view"),
                   row.Field<int>("room_number"),
                   row.Field<int>("number_of_beds")
                );
            }
            else
                return null;
        }

        //--GET ALL 
        public static DataTable GetAllRoom()
        {
            return clsRoomData.GetAllRooms();
        }

        //--IS EXISTS 
        public bool IsRoomAvailable()
        {
            return clsRoomData.IsRoomAvailable((int)this.room_id);
        }
    }
}
