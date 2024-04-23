using HotelData;
using System.Data;

namespace HotelLogic
{
    public class clsRoomImage
    {

        //--PROPARTIES
        public int? id { set; get; }
        public string imagePath { set; get; }
        public int? roomID { set; get; }
        enum enMode { AddNew, Update }
        enMode Mode = enMode.AddNew;

        //--Constructure1
        private clsRoomImage(int id, string imagePath, int roomID)
        {
            this.id = id;
            this.imagePath = imagePath;
            this.roomID = roomID;
            Mode = enMode.Update;
        }

        //--Constructure2
        public clsRoomImage()
        {
            this.id = null;
            this.imagePath = null;
            this.roomID = null;
            Mode = enMode.AddNew;
        }


        //__DELETE
        public static bool DeleteRoomImage(int RoomImageID)
        {
            return clsRoomImagesData.DeleteRoomImageByID(RoomImageID);
        }

        //Add New
        private bool _AddRoomImages()
        {
            return clsRoomImagesData.AddRoomImages
             (
                (int)this.roomID,
                (string)this.imagePath
             );
        }

        public bool Save()
        {
            return _AddRoomImages();

        }

        public static DataTable GetAllImagesForRoomID(int RoomID)
        {
            return clsRoomImagesData.GetAllImagesForRoomID(RoomID);
        }

        public static bool ClearImagesRoom(int RoomID)
        {
            return clsRoomImagesData.ClearImagesRoom(RoomID);
        }



    }
}
