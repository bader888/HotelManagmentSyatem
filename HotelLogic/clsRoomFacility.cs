using HotelData;
using System.Data;

namespace HotelLogic
{
    public class clsRoomFacility
    {
        //--PROPARTIES
        private int? id { set; get; }
        public int? room_id { set; get; }
        public string facilitites_ids { set; get; }

        enum enMode { AddNew, Update }
        enMode Mode = enMode.AddNew;

        //--Constructure1
        //private clsRoomFacility(int id, int room_id, int facility_id)
        //{
        //    this.id = id;
        //    this.room_id = room_id;
        //    this.facility_id = facility_id;
        //    Mode = enMode.Update;
        //}

        //--Constructure2
        public clsRoomFacility()
        {
            this.id = null;
            this.room_id = null;
            this.facilitites_ids = null;
            Mode = enMode.AddNew;
        }


        //__DELETE
        public static bool DeleteRoomFacility(int RoomFailityID)
        {
            return clsRoomFacilityData.DeleteRoomFacility(RoomFailityID);
        }

        //--UPDATE 
        //private bool _UpdateRoomFacility()
        //{
        //    return clsRoomFacilityData.UpdateRoomFacilityByID(
        //     (int)this.id,
        //     (int)this.room_id,
        //     (string)this.facilitites_ids);
        //}

        private bool _AddNewRoomFacility()
        {

            return
            clsRoomFacilityData.AddNewRoomFacility(
               (int)this.room_id,
            this.facilitites_ids);

        }

        public bool Save()
        {

            return _AddNewRoomFacility();

        }

        //--GET ALL 
        public static DataTable GetAllFacilitiesForRoomID(int RoomID)
        {
            return clsRoomFacilityData.GetAllFacilitiesForRoomID(RoomID);
        }


        //--IS EXISTS 
        public static bool isFacilityExistForRoomID(int RoomID, int FacilityID)
        {
            return clsRoomFacilityData.IsFacilityExistForRoomID(FacilityID, RoomID);
        }

    }
}
