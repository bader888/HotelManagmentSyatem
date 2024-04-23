using Bunifu.UI.WinForms.BunifuTextbox;
using HotelLogic;
using HotelManagmentSyatem.Customers;
using HotelManagmentSyatem.Global_Classes;
using HotelManagmentSyatem.People;
using HotelManagmentSyatem.Properties;
using System;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Log_in
{
    public partial class frmLogin : Form
    {
        /// <summary>
        /// log in --
        /// user2 
        /// 1234
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
        }

        int _logInTry = -1;

        int _logInTryCustomer = -1;

        bool showPassword = false;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string Username = null;
            string password = null;
            string visitor = null;

            clsUtil.GetCurrentUserFromRegistry(ref Username, ref password, ref visitor);

            if (visitor == "User")
            {
                bunifuPages1.PageName = "tpUserLogin";
                txtPassword.Text = password;
                txtUserName.Text = Username;

            }

            if (visitor == "Customer")
            {
                bunifuPages1.PageName = "tpcustomerLogin";
                txtCustomerPassword.Text = password;
                txtCustomerEmail.Text = Username;

            }

            txtPassword.UseSystemPasswordChar = true;
            txtCustomerPassword.UseSystemPasswordChar = true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 1;
            txtPassword.Text = string.Empty;
            txtUserName.Text = string.Empty;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 2;
            txtCustomerEmail.Text = string.Empty;
            txtCustomerPassword.Text = string.Empty;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 0;
            txtPassword.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtCustomerEmail.Text = string.Empty;
            txtCustomerPassword.Text = string.Empty;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowHidePassword_OnIconLeftClick(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = showPassword;
            txtCustomerPassword.UseSystemPasswordChar = showPassword;

            showPassword = !showPassword;

            if (showPassword)
            {
                txtPassword.LeftIcon.Image = Resources.show;
                txtCustomerPassword.LeftIcon.Image = Resources.show;
            }
            else
            {
                txtPassword.LeftIcon.Image = Resources.hide;
                txtCustomerPassword.LeftIcon.Image = Resources.hide;
            }
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

        private void btnSignInUser_Click(object sender, EventArgs e)
        {
            if (clsUser.UserLogin(txtUserName.Text.Trim(), clsEncrypted.HashPassword(txtPassword.Text.Trim())))
            {

                if (ckbRememberUser.Checked)
                {
                    //save the user name, password, isUser to the register
                    clsUtil.WriteCurrentUserToRegistry(txtUserName.Text.Trim(), txtPassword.Text.Trim(), "User");
                }
                else
                {
                    //remvoe the current user info from the register
                    clsUtil.RemoveCurrentUserFromRegistry();
                }
                this.Hide();
                FrmMain frm = new FrmMain(this);
                frm.ShowDialog();
            }
            else
            {
                _logInTry++;
                lblWrongUserNameAndPassword.Visible = true;
                lblWrongUserNameAndPassword.Text = $"Wrong password/username, {(2 - _logInTry)} try left!";

                if (_logInTry == 2)
                {

                    txtPassword.Enabled = false;
                    txtUserName.Enabled = false;
                    btnSingInUser.Enabled = false;
                    lblWrongUserNameAndPassword.Text = $"the system locked, contact with your admin!";

                }

            }
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            frmAddEditNewCustomer frm = new frmAddEditNewCustomer();
            frm.ShowDialog();
            //add new customer form
        }

        private void llSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditNewCustomer frm = new frmAddEditNewCustomer();
            frm.ShowDialog();
            //add new customer form
        }

        private void btnSignInCustomer_Click(object sender, EventArgs e)
        {
            if (clsCustomer.CustomerLogin(txtCustomerEmail.Text.Trim(), clsEncrypted.HashPassword(txtCustomerPassword.Text.Trim())))
            {

                if (ckbRememberUser.Checked)
                {
                    //save the user name, password, isUser to the register
                    clsUtil.WriteCurrentUserToRegistry(txtCustomerEmail.Text.Trim(), txtCustomerPassword.Text.Trim(), "Customer");
                }
                else
                {
                    //remvoe the current user info from the register
                    clsUtil.RemoveCurrentUserFromRegistry();
                }

                MessageBox.Show("Done");
                //open page to make the customer book a hotel


            }
            else
            {

                _logInTryCustomer++;
                lblCustomerWrongLogin.Visible = true;
                lblCustomerWrongLogin.Text = $"Wrong password/Email, {(2 - _logInTry)} try left!";

                if (_logInTry == 2)
                {

                    txtPassword.Enabled = false;
                    txtUserName.Enabled = false;
                    btnSingInUser.Enabled = false;
                    lblCustomerWrongLogin.Text = $"the system locked, contact with your admin!";

                }

            }
        }

        private void txtCustomerEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        }

        private void ckbRememberUser_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {

        }
    }
}
