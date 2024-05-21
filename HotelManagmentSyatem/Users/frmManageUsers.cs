using HotelLogic;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Users
{
    public partial class frmManageUsers : Form
    {
        FrmMain _frmMain;
        public frmManageUsers(FrmMain frmMain)
        {
            InitializeComponent();
            _frmMain = frmMain;
        }

        private static DataTable _dtAllUsers;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsUser.GetAlluser();

            dgvUsers.DataSource = _dtAllUsers;

            cbFilterBy.SelectedIndex = 0;

            lblCount.Text = dgvUsers.Rows.Count.ToString();

            cbActivationFilter.Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == string.Empty)
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblCount.Text = dgvUsers.Rows.Count.ToString();

                return;
            }

            string FilterColumn = null;

            switch (cbFilterBy.SelectedItem.ToString())
            {
                case "Is Active":
                    {
                        FilterColumn = "IsActive";
                        break;
                    }
                case "Full Name":
                    {
                        FilterColumn = "FullName";
                        break;

                    }
                case "User Name":
                    {
                        FilterColumn = "UserName";
                        break;

                    }
                case "ID":
                    {
                        FilterColumn = "ID";
                        break;

                    }
                default:
                    {
                        FilterColumn = "None";
                        break;
                    }
            }
            if (FilterColumn != "ID")
                _dtAllUsers.DefaultView.RowFilter = string.Format("{0} like '{1}%'", FilterColumn, txtSearch.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("{0} = {1} ", FilterColumn, txtSearch.Text.Trim());

            lblCount.Text = dgvUsers.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() == "Is Active")
            {
                txtSearch.Visible = false;
                cbActivationFilter.Visible = true;
                cbActivationFilter.SelectedIndex = 0;
            }
            else
            {
                txtSearch.Visible = true;
                cbActivationFilter.Visible = false;
            }

            if (cbFilterBy.SelectedItem.ToString() == "None")
            {
                txtSearch.Enabled = false;
                txtSearch.Clear();
                _dtAllUsers.DefaultView.RowFilter = "";

                return;
            }
            else
            {
                txtSearch.Clear();
                txtSearch.Enabled = true;
            }

            lblCount.Text = dgvUsers.Rows.Count.ToString();
        }

        private void cbActivationFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbActivationFilter.SelectedItem.ToString() == "All")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }
            string FilterValue = cbActivationFilter.SelectedItem.ToString() == "Active" ? "Active" : "not active";
            _dtAllUsers.DefaultView.RowFilter = string.Format(" IsActive = '{0}'", FilterValue);

            lblCount.Text = dgvUsers.Rows.Count.ToString();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            _frmMain.Show();
            this.Close();

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditeUser frm = new frmAddEditeUser();
            frm.ShowDialog();
            frmListUsers_Load(null, null);


        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (clsUser.DeleteUserbyID((int)dgvUsers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListUsers_Load(null, null);
            }

            else
                MessageBox.Show("User is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddEditeUser frm = new frmAddEditeUser();
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword frm = new frmChangeUserPassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void btnMin_Click(object sender, EventArgs e)
        {

        }
    }
}
