using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using HotelManagmentSyatem.Properties;
using System;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Customer
{
    public partial class frmChangeCustomerPassword : Form
    {
        int _PersonID = -1;

        public frmChangeCustomerPassword(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            txtOldPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {

                MessageBox.Show("Error: Something Wrong, please put the mouse on the red icon's ",
                    "Error: Empty Failds",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            clsCurrentCustomer.customerInfo.Password = clsEncrypted.HashPassword(txtNewPassword.Text.Trim());
            if (clsCurrentCustomer.customerInfo.Save())
            {

                bunifuSnackbar1.Show(this,
                    "password Chagne Successfully",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);

                clsCurrentCustomer.customerInfo = clsCustomer.FindCustomerByID((int)clsCurrentCustomer.customerInfo.CustomerID);

            }
            else
                bunifuSnackbar1.Show(this,
                    "Error: Faild to Chagne Password",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
        }

        private void frmChangeCustomerPassword_Load(object sender, EventArgs e)
        {

            ctrlPersonCard1.LoadPersonInfo(_PersonID);

        }

        private void txtOldPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtOldPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtOldPassword, "the faild can't by empty");
            }
            else
                errorProvider1.SetError(txtOldPassword, null);


            if (clsEncrypted.HashPassword(txtOldPassword.Text.Trim()) != clsCurrentCustomer.customerInfo.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtOldPassword, "The Password Wrong, please Enter Correct Password");
            }
            else
                errorProvider1.SetError(txtOldPassword, null);

        }

        private void txtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtOldPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "the faild can't by empty");
            }
            else
                errorProvider1.SetError(txtConfirmPassword, null);



            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "The Password does not match the New Password");
            }
            else
                errorProvider1.SetError(txtConfirmPassword, null);
        }

        private void txtValidating_EmptyText(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "the faild can't by empty");
            }
            else
                errorProvider1.SetError(txtNewPassword, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtOldPassword_OnIconRightClick(object sender, EventArgs e)
        {
            txtOldPassword.UseSystemPasswordChar = txtOldPassword.Tag.ToString() != "Hide";

            if (txtOldPassword.Tag.ToString() == "Hide")
            {
                txtOldPassword.RightIcon.Image = Resources.show;
                txtOldPassword.Tag = "Show";
            }
            else
            {
                txtOldPassword.RightIcon.Image = Resources.hide;
                txtOldPassword.Tag = "Hide";

            }
        }

        private void txtNewPassword_OnIconRightClick(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = txtNewPassword.Tag.ToString() != "Hide";

            if (txtOldPassword.Tag.ToString() == "Hide")
            {
                txtNewPassword.RightIcon.Image = Resources.show;
                txtNewPassword.Tag = "Show";
            }
            else
            {
                txtNewPassword.RightIcon.Image = Resources.hide;
                txtNewPassword.Tag = "Hide";

            }
        }

        private void txtConfirmPassword_OnIconRightClick(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = txtConfirmPassword.Tag.ToString() != "Hide";

            if (txtConfirmPassword.Tag.ToString() == "Hide")
            {
                txtConfirmPassword.RightIcon.Image = Resources.show;
                txtConfirmPassword.Tag = "Show";
            }
            else
            {
                txtConfirmPassword.RightIcon.Image = Resources.hide;
                txtConfirmPassword.Tag = "Hide";

            }
        }
    }
}
