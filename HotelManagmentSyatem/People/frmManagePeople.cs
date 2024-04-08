using HotelLogic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagmentSyatem.People
{
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }
        DataTable _dtPeople = new DataTable();
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void addNewToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            addNewToolStripMenuItem.BackColor = Color.Red;
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _dtPeople = clsPerson.GetAllPeople();
            dgvPeople.DataSource = _dtPeople;
            txtSearch.Enabled = false;
            cbFilterBy.SelectedIndex = 0;
            lblCount.Text = dgvPeople.Rows.Count.ToString();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();
            frmManagePeople_Load(null, null);

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmManagePeople_Load(null, null);
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManagePeople_Load(null, null);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == string.Empty)
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblCount.Text = dgvPeople.Rows.Count.ToString();

                return;
            }
            string FilterColumn = null;
            switch (cbFilterBy.SelectedItem.ToString())
            {
                case "National No":
                    {
                        FilterColumn = "NationalNO";
                        break;
                    }
                case "Full Name":
                    {
                        FilterColumn = "FullName";
                        break;

                    }
                case "Nationality":
                    {
                        FilterColumn = "CountryName";
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
                _dtPeople.DefaultView.RowFilter = string.Format("{0} like '{1}%'", FilterColumn, txtSearch.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("{0} = {1} ", FilterColumn, txtSearch.Text.Trim());

            lblCount.Text = dgvPeople.Rows.Count.ToString();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() == "None")
            {
                txtSearch.Enabled = false;
                _dtPeople.DefaultView.RowFilter = "";

            }
            else
                txtSearch.Enabled = true;

            lblCount.Text = dgvPeople.Rows.Count.ToString();


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();
            frmManagePeople_Load(null, null);

        }
    }
}
