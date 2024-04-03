using HotelData;
using System;
using System.Data;

namespace HotelLogic
{
    public class clsPerson
    {


        //--PROPARTIES
        public int? PersonID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public DateTime? DateOfBirth { set; get; }
        public byte? Gender { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int? NationalityCountryID { set; get; }
        public string ImagePath { set; get; }
        enum enMode { AddNew, Update }
        enMode Mode = enMode.AddNew;

        public clsCountry _Country = new clsCountry();
        public clsCountry CountyInfo
        {
            get
            {
                return _Country;
            }
        }

        //--Constructure1
        private clsPerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, byte Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            _Country = clsCountry.FindCountryByID(NationalityCountryID);
            Mode = enMode.Update;
        }

        //--Constructure2
        public clsPerson()
        {
            this.PersonID = null;
            this.NationalNo = null;
            this.FirstName = null;
            this.SecondName = null;
            this.ThirdName = null;
            this.LastName = null;
            this.DateOfBirth = null;
            this.Gender = null;
            this.Address = null;
            this.Phone = null;
            this.Email = null;
            this.NationalityCountryID = null;
            this.ImagePath = null;
            Mode = enMode.AddNew;
        }


        //__DELETE
        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }

        //--ADD PERSON
        private bool _AddNewPerson()
        {

            this.PersonID = clsPersonData.AddNewPerson(
                            (string)this.NationalNo,
                            (string)this.FirstName,
                            (string)this.SecondName,
                            (string)this.ThirdName,
                            (string)this.LastName,
                            (DateTime)this.DateOfBirth,
                            (byte)this.Gender,
                            (string)this.Address,
                            (string)this.Phone,
                            (string)this.Email,
                            (int)this.NationalityCountryID,
                            (string)this.ImagePath
                            );
            return (this.PersonID != -1);
        }

        //--UPDATE 
        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(
             (int)this.PersonID,
             (string)this.NationalNo,
             (string)this.FirstName,
             (string)this.SecondName,
             (string)this.ThirdName,
             (string)this.LastName,
             (DateTime)this.DateOfBirth,
             (byte)this.Gender,
             (string)this.Address,
             (string)this.Phone,
             (string)this.Email,
             (int)this.NationalityCountryID,
             (string)this.ImagePath
             );
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        Mode = enMode.Update;
                        return _AddNewPerson();
                    }
                case enMode.Update:
                    {
                        return _UpdatePerson();
                    }
                default:
                    return false;

            }
        }

        //--FIND 
        static public clsPerson FindPersonByID(int PersonID)
        {
            DataTable dtPerson = clsPersonData.FindPersonByID(PersonID);
            if (dtPerson.Rows.Count > 0)
            {
                DataRow rowPerson = dtPerson.Rows[0];//get the first row  

                return new clsPerson(
                       (int)rowPerson["PersonID"],
                            (string)rowPerson["NationalNo"],
                            (string)rowPerson["FirstName"],
                            (string)rowPerson["SecondName"],
                            (string)rowPerson["ThirdName"],
                            rowPerson["LastName"] == DBNull.Value ? null : (string)rowPerson["LastName"],
                            (DateTime)rowPerson["DateOfBirth"],
                            (byte)rowPerson["Gender"],
                            (string)rowPerson["Address"],
                            (string)rowPerson["Phone"],
                            rowPerson["Email"] == DBNull.Value ? null : (string)rowPerson["Email"],
                            (int)rowPerson["NationalityCountryID"],
                            (string)rowPerson["ImagePath"]
                    );
            }
            else
                return null;
        }

        //--GET ALL 
        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        //--IS EXISTS 
        public static bool isPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }


        public static bool isPersonExist(string NationalNo)
        {
            return clsPersonData.IsPersonExist(NationalNo);
        }
    }
}
