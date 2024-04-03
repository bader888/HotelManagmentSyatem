﻿using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using HotelManagmentSyatem.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace HotelManagmentSyatem.People.Controls
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person;

        private int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.FindPersonByID(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        //public void LoadPersonInfo(string NationalNo)
        //{
        //    _Person = clsPerson.FindPersonByID(NationalNo);
        //    if (_Person == null)
        //    {
        //        ResetPersonInfo();
        //        MessageBox.Show("No Person with National No. = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    _FillPersonInfo();
        //}

        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            _PersonID = (int)_Person.PersonID;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblNationalNo.Text = _Person.NationalNo;
            lblFullName.Text = _Person.FirstName;
            lblGendor.Text = _Person.Gender == 0 ? "Male" : "Female";
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblDateOfBirth.Text = clsFormat.DateToShort((DateTime)_Person.DateOfBirth);
            lblCountry.Text = clsCountry.FindCountryByID((int)_Person.NationalityCountryID).CountryName;
            lblAddress.Text = _Person.Address;
            _LoadPersonImage();




        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblFullName.Text = "[????]";
            pbGendor.Image = Resources.Man_32;
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonImage.Image = Resources.Male_512;

        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(_PersonID);
            frm.ShowDialog();

            //refresh
            LoadPersonInfo(_PersonID);
        }
    }
}
