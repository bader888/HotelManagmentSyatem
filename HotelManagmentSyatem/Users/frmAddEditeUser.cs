using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using HotelManagmentSyatem.Properties;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Users
{
    public partial class frmAddEditeUser : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _UserID = -1;
        clsUser _User;
        bool ShowPassword = false;
        public frmAddEditeUser()
        {
            InitializeComponent();


        }

        public frmAddEditeUser(int UserID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _UserID = UserID;
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.AddNew)
            {
                lblHeader.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();

                ctrlPersonCardWithFilter1.FilterFocus();
            }
            else
            {
                lblHeader.Text = "Update User";
                this.Text = "Update User";
                btnSave.Enabled = true;


            }

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            //    chkIsActive.Checked = true;
        }

        private void btnPersonInfo_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            tp.PageName = "tpPersonInfo";
        }

        private void btnLoginInfo_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tp.PageName = "tpLoginInfo";

                return;
            }

            //incase of add new mode.
            if (ctrlPersonCardWithFilter1.PersonID != -1)
            {

                if (clsUser.isUserExistForPersonID(ctrlPersonCardWithFilter1.PersonID))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tp.PageName = "tpLoginInfo";

                }
            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();

            }

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
            // _frmManageUsers.Visible = true;


        }

        private void _LoadData()
        {

            _User = clsUser.FinduserByID(_UserID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            //the following code will not be executed if the User was not found
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            // chkIsActive.Checked = (bool)_User.IsActive;
            ctrlPersonCardWithFilter1.LoadPersonInfo((int)_User.PersonID);


        }

        private void _FillCbUserRole()
        {
            foreach (var Role in clsUser.UserRoleMapping)
            {
                //              cbUserRole.Items.Add(Role);
            }

            //            cbUserRole.SelectedIndex = 0;
        }

        private void frmAddEditeUser_Load(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtPassword.UseSystemPasswordChar = true;
            _ResetDefualtValues();
            _FillCbUserRole();


            if (_Mode == enMode.Update)
                _LoadData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _User.UserName = txtUserName.Text.Trim();
            _User.Password = clsEncrypted.HashPassword(txtPassword.Text.Trim());
            //      _User.IsActive = chkIsActive.Checked;

            //////this will be get from the combo box 
            //  _User.Role = (byte)clsUser.UserRoleMapping.FirstOrDefault(role => role.Value == cbUserRole.SelectedItem.ToString()).Key;


            if (_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();

                //change form mode to update.
                _Mode = enMode.Update;
                lblHeader.Text = "Update User";
                this.Text = "Update User";
                bunifuSnackbar1.Show(this, "Data Saved Successfully.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
            }
            else
                bunifuSnackbar1.Show(this, "Error: Data Is not Saved Successfully.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);

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

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            };


            if (_Mode == enMode.AddNew)
            {

                if (clsUser.isuserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                };
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_User.UserName != txtUserName.Text.Trim())
                {
                    if (clsUser.isuserExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    };
                }
            }
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
