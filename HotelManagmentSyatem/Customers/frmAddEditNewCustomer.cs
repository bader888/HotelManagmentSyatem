using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using HotelManagmentSyatem.Properties;
using MaterialSkin.Controls;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Customers
{
    public partial class frmAddEditNewCustomer : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _CustomerID = -1;
        clsCustomer _Customer;
        bool ShowPassword = false;
        public frmAddEditNewCustomer()
        {
            InitializeComponent();
            btnNext.Enabled = false;

        }

        public frmAddEditNewCustomer(int CustomerID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _CustomerID = CustomerID;
        }


        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.AddNew)
            {

                _Customer = new clsCustomer();
                lblHeader.Text = "Sign up";

            }
            else
            {
                lblHeader.Text = "Update Customer INFO.";
                btnSave.Enabled = true;


            }

            txtCustomerEmail.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void btnPersonInfo_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;

            bunifuPages1.SelectedIndex = 0; //person info page 
        }


        private void btnLoginInfo_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                bunifuPages1.SelectedIndex = 1;

                return;
            }

            ////incase of add new mode.
            if (ctrlAddNewCustomer2.PersonID != -1)
            {

                if (clsCustomer.isCustomerExistForPersonID(ctrlAddNewCustomer2.PersonID))
                {

                    MaterialMessageBox.Show("Selected Person already has a Customer, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    btnSave.Enabled = true;
                    bunifuPages1.SelectedIndex = 1;//log in info page

                }
            }

            else

            {
                MaterialMessageBox.Show("Please Add Information First", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();



        }

        private void _LoadData()
        {

            _Customer = clsCustomer.FindCustomerByID(_CustomerID);

            if (_Customer == null)
            {
                MaterialMessageBox.Show("No Customer with ID = " + _CustomerID, "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            ////the following code will not be executed if the User was not found
            lblCustomerID.Text = _Customer.CustomerID.ToString();
            txtCustomerEmail.Text = _Customer.Email;
            txtPassword.Text = _Customer.Password;
            txtConfirmPassword.Text = _Customer.Password;
            ctrlAddNewCustomer2.LoadPersonInfo((int)_Customer.PersonID);
            ctrlAddNewCustomer2.hideAddNewBtnAndLable = true;

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MaterialMessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _Customer.PersonID = ctrlAddNewCustomer2.PersonID;
            _Customer.Email = txtCustomerEmail.Text.Trim();
            _Customer.Password = clsEncrypted.HashPassword(txtPassword.Text.Trim());

            if (_Customer.Save())
            {
                lblCustomerID.Text = _Customer.CustomerID.ToString();

                //change form mode to update.
                _Mode = enMode.Update;
                lblHeader.Text = "Update Sign up INFO.";

                MaterialMessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MaterialMessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            };

        }

        private void txtCustomerEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCustomerEmail, "Email cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCustomerEmail, null);
            };

            //validate email format
            if (!clsValidatoin.ValidateEmail(txtCustomerEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCustomerEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtCustomerEmail, null);
            };


            if (_Mode == enMode.AddNew)
            {

                if (clsCustomer.isCustomerExist(txtCustomerEmail.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtCustomerEmail, "Email is used by another Customer");
                }
                else
                {
                    errorProvider1.SetError(txtCustomerEmail, null);
                };
            }
            else
            {
                //incase update make sure not to use anothers Email name
                if (_Customer.Email != txtCustomerEmail.Text.Trim())
                {
                    if (clsUser.isuserExist(txtCustomerEmail.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtCustomerEmail, "Email is used by another Customer");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtCustomerEmail, null);
                    };
                }
            }
        }

        private void ctrlAddNewCustomer1_OnPersonSelected(int obj)

        {
            btnNext.Enabled = true;
            ctrlAddNewCustomer2.hideAddNewBtnAndLable = false;

        }

        private void frmAddEditNewCustomer_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();

        }


        private void txtPassword_OnIconRightClick(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = ShowPassword;
            ShowPassword = !ShowPassword;
            if (ShowPassword)
                txtPassword.RightIcon.Image = Resources.show;
            else
                txtPassword.RightIcon.Image = Resources.hide;
        }

        private void txtConfirmPassword_OnIconRightClick(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = ShowPassword;
            ShowPassword = !ShowPassword;
            if (ShowPassword)
                txtConfirmPassword.RightIcon.Image = Resources.show;
            else
                txtConfirmPassword.RightIcon.Image = Resources.hide;
        }
    }
}
