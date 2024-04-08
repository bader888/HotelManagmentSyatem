using HotelData;
using System.Collections.Generic;
using System.Data;

namespace HotelLogic
{
    public class clsUser
    {

        //--PROPARTIES
        public static Dictionary<int, string> UserRoleMapping = new Dictionary<int, string>
        {

            {1,"Admin" },
            {2,"Manager" },
            {3,"Reciption" },
            {4,"Accounting" },
            {5,"Customer" }
        };


        public int? UserID { set; get; }
        public int? PersonID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool? IsActive { set; get; }
        public byte? Role { set; get; }
        enum enMode { AddNew, Update }
        enMode Mode = enMode.AddNew;

        clsPerson _Person = new clsPerson();
        public clsPerson PersonInfo
        {
            get
            {
                return _Person;
            }
        }


        //--Constructure1
        private clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive, byte Role)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.Role = Role;
            _Person = clsPerson.FindPersonByID((int)this.PersonID);
            Mode = enMode.Update;
        }

        //--Constructure2
        public clsUser()
        {
            this.UserID = null;
            this.PersonID = null;
            this.UserName = null;
            this.Password = null;
            this.IsActive = null;
            this.Role = null;
            Mode = enMode.AddNew;
        }

        //--AddNewUser
        private bool _AddNewUser()
        {
            //remove the id column
            this.UserID = clsUserData.AddNewUser(
            (int)this.PersonID,
            (string)this.UserName,
            (string)this.Password,
            (bool)this.IsActive,
            (byte)this.Role
            );
            return (this.UserID != -1);
        }

        //--UPDATE 
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(
             (int)this.UserID,
             (int)this.PersonID,
             (string)this.UserName,
             (string)this.Password,
             (bool)this.IsActive,
             (byte)this.Role
             );
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        Mode = enMode.Update;
                        return _AddNewUser();
                    }
                case enMode.Update:
                    {
                        return _UpdateUser();
                    }
                default:
                    return false;

            }
        }

        //--DELETE 
        public static bool DeleteUserbyID(int userID)
        {
            return clsUserData.DeleteUserbyID(userID);
        }

        //--FIND 
        static public clsUser FinduserByID(int userID)
        {
            DataTable dtuser = clsUserData.FindUserbyID(userID);
            if (dtuser.Rows.Count > 0)
            {
                DataRow rowuser = dtuser.Rows[0];//get the first row  

                return new clsUser(
                       (int)rowuser["UserID"],
                            (int)rowuser["PersonID"],
                            (string)rowuser["UserName"],
                            (string)rowuser["Password"],
                            (bool)rowuser["IsActive"],
                            (byte)rowuser["Role"]
                    );
            }
            else
                return null;
        }

        //--GET ALL 
        public static DataTable GetAlluser()
        {
            return clsUserData.GetAllUsers();
        }

        //--IS EXISTS 
        public static bool isuserExist(int userID)
        {
            return clsUserData.IsUserExist(userID);
        }

        public static bool isuserExist(string userName)
        {
            return clsUserData.IsUserExist(userName);
        }

        public static bool isUserExistForPersonID(int PersonID)
        {
            return clsUserData.IsUserExistsForPersonID(PersonID);
        }

        public static bool UserLogin(string UaserName, string Password)
        {
            return clsUserData.UserLogin(UaserName, Password);
        }
    }
}
