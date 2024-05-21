using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using HotelManagmentSyatem.Properties;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Users
{
    public partial class frmChangeUserPassword : Form
    {
        private int _UserID;
        private clsUser _User;
        bool HidePasswrd = false;
        public frmChangeUserPassword(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void _ResetDefualtValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            };

            if (_User.Password != txtCurrentPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Current password is wrong!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            };
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "New Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            };
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match New Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };
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

            _User.Password = clsEncrypted.HashPassword(txtNewPassword.Text);

            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully.",
                   "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("An Erro Occured, Password did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            _User = clsUser.FinduserByID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("The User Not Found", "Error:Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);


                this.Close();
                return;
            }
            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void txtCurrentPassword_OnIconRightClick(object sender, EventArgs e)
        {

            txtCurrentPassword.UseSystemPasswordChar = HidePasswrd;
            HidePasswrd = !HidePasswrd;
            PictureBox Icon = (PictureBox)sender;
            if (HidePasswrd)
            {
                Icon.Image = Resources.show;
            }
            else
            {
                Icon.Image = Resources.hide;
            }
        }

        private void txtNewPassword_OnIconRightClick(object sender, EventArgs e)
        {

            HidePasswrd = !HidePasswrd;
            PictureBox Icon = (PictureBox)sender;
            if (HidePasswrd)
            {
                Icon.Image = Resources.show;
                txtNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                Icon.Image = Resources.hide;
                txtNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmPassword_OnIconRightClick(object sender, EventArgs e)
        {
            HidePasswrd = !HidePasswrd;
            PictureBox Icon = (PictureBox)sender;
            if (HidePasswrd)
            {
                Icon.Image = Resources.show;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                Icon.Image = Resources.hide;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
