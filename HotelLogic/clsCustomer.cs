using HotelData;
using System.Data;

namespace HotelLogic
{
    public class clsCustomer
    {


        //--PROPARTIES
        public int? CustomerID { set; get; }
        public int? PersonID { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        enum enMode
        {
            AddNew,
            Update
        }

        enMode Mode = enMode.AddNew;

        //--Constructure1
        private clsCustomer(int CustomerID, int PersonID, string Email, string Password)
        {
            this.CustomerID = CustomerID;
            this.PersonID = PersonID;
            this.Email = Email;
            this.Password = Password;
            Mode = enMode.Update;
        }

        //--Constructure2
        public clsCustomer()
        {
            this.CustomerID = null;
            this.PersonID = null;
            this.Email = null;
            this.Password = null;
            Mode = enMode.AddNew;
        }


        private bool _AddNewCustomer()
        {
            //remove the id column
            this.CustomerID = clsCustomerData.AddNewCustomer(
                (int)this.PersonID,
                (string)this.Email,
                (string)this.Password
                );
            return (this.CustomerID != -1);
        }


        private bool _UpdateCustomer()
        {
            return clsCustomerData.UpdateCustomer(
            (int)this.CustomerID,
            (int)this.PersonID,
            (string)this.Email,
            (string)this.Password
            );
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        Mode = enMode.Update;
                        return _AddNewCustomer();
                    }
                case enMode.Update:
                    {
                        return _UpdateCustomer();
                    }
                default:
                    return false;

            }
        }

        public static bool isCustomerExist(int CustomerID)
        {
            return clsCustomerData.IsCustomerExist(CustomerID);
        }

        public static bool isCustomerExist(string Email)
        {
            return clsCustomerData.IsCustomerExist(Email);
        }

        public static bool isCustomerExistForPersonID(int PersonID)
        {
            return clsCustomerData.isCustomerExistForPersonID(PersonID);
        }

        static public clsCustomer FindCustomerByID(int CustomerID)
        {
            DataTable dtCustomer = clsCustomerData.FindCustomerByID(CustomerID);
            if (dtCustomer.Rows.Count > 0)
            {
                DataRow rowCustomer = dtCustomer.Rows[0];//get the first row  

                return new clsCustomer(
                       (int)rowCustomer["CustomerID"],
                            (int)rowCustomer["PersonID"],
                            (string)rowCustomer["Email"],
                            (string)rowCustomer["Password"]
                    );
            }
            else
                return null;
        }


        static public bool CustomerLogin(string Email, string Password)
        {
            return clsCustomerData.CustomerLogin(Email, Password);
        }
    }
}
