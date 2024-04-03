using Bunifu.UI.WinForms;
using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using HotelManagmentSyatem.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace HotelManagmentSyatem.People
{
    public partial class frmAddEditPerson : Form
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1 };

        private enMode _Mode;
        private int _PersonID = -1;
        clsPerson _Person;


        public frmAddEditPerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _PersonID = PersonID;
        }
        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            _FillCountriesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                lblHeader.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                lblHeader.Text = "Update Person";
            }

            //set default image for the person.
            if (rbMale.Checked)
                pbPerson.Image = Resources.Male_512;
            else
                pbPerson.Image = Resources.Female_512;

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (pbPerson.ImageLocation != null);

            //we set the max date to 18 years from today, and set the default value the same.
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            //should not allow adding age more than 100 years
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            //this will set default country to jordan.
            cbCountry.SelectedIndex = cbCountry.FindString("Jordan");

            txtfName.Text = "";
            txtSname.Text = "";
            txtTname.Text = "";
            txtLname.Text = "";
            txtnationalNo.Text = "";
            rbMale.Checked = true;
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";


        }

        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }

        private void _LoadData()
        {

            _Person = clsPerson.FindPersonByID(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            //the following code will not be executed if the person was not found
            lblPersonID.Text = _PersonID.ToString();
            txtfName.Text = _Person.FirstName;
            txtSname.Text = _Person.SecondName;
            txtTname.Text = _Person.ThirdName;
            txtLname.Text = _Person.LastName;
            txtnationalNo.Text = _Person.NationalNo;
            dtpDateOfBirth.Value = (DateTime)_Person.DateOfBirth;

            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtAddress.Text = _Person.Address;
            txtPhoneNumber.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountyInfo.CountryName);


            //load person image incase it was set.
            if (_Person.ImagePath != "")
            {
                pbPerson.ImageLocation = _Person.ImagePath;

            }

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (_Person.ImagePath != "");

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            //handle image person

            int NationalityCountryID = (int)clsCountry.FindCountry(cbCountry.Text).CountryID;

            _Person.FirstName = txtfName.Text.Trim();
            _Person.SecondName = txtSname.Text.Trim();
            _Person.ThirdName = txtTname.Text.Trim();
            _Person.LastName = txtLname.Text.Trim();
            _Person.NationalNo = txtnationalNo.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhoneNumber.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                _Person.Gender = (byte)enGendor.Male;
            else
                _Person.Gender = (byte)enGendor.Female;

            _Person.NationalityCountryID = NationalityCountryID;

            if (pbPerson.ImageLocation != null)
                _Person.ImagePath = pbPerson.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblHeader.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, (int)_Person.PersonID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void ValidateEmptyText(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            BunifuTextBox Temp = ((BunifuTextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (txtEmail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidatoin.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            };
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtnationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtnationalNo, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtnationalNo, null);
            }

            //Make sure the national number is not used by another person
            if (txtnationalNo.Text.Trim() != _Person.NationalNo && clsPerson.isPersonExist(txtnationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtnationalNo, "National Number is used for another person!");

            }
            else
            {
                errorProvider1.SetError(txtnationalNo, null);
            }
        }

        private void llSetImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPerson.Load(selectedFilePath);

                llRemoveImage.Visible = true;
                // ...
            }
        }


        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPerson.ImageLocation = null;



            if (rbMale.Checked)
                pbPerson.Image = Resources.Male_512;
            else
                pbPerson.Image = Resources.Female_512;

            llRemoveImage.Visible = false;

        }


    }
}