using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using HotelManagmentSyatem.hotel;
using System.Data;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Hotel_Facilities
{
    public partial class frmManageFacilities : Form
    {
        public frmManageFacilities()
        {
            InitializeComponent();
        }
        DataTable _dtFacilities = new DataTable();

        private void frmManageFacilities_Load(object sender, System.EventArgs e)
        {
            _dtFacilities = clsFacilite.GetAllFacilitie();
            dgvFacilities.DataSource = _dtFacilities;
            lblCount.Text = _dtFacilities.Rows.Count.ToString();
        }

        private void btnCloseForm_Click_1(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            clsFacilite facilite = clsFacilite.FindFacilitieByID((int)dgvFacilities.SelectedRows[0].Cells[0].Value);
            if (facilite == null)
            {
                MessageBox.Show("facilitie not found", "Error: Wrong id", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            if (MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (clsFacilite.DeleteFacilitie((int)dgvFacilities.SelectedRows[0].Cells[0].Value))
                {

                    MessageBox.Show("Delete successfully", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clsFileManager.DeleteFile(facilite.IconUrl);

                    frmManageFacilities_Load(null, null);
                }
                else
                    MessageBox.Show("Delete Faild", "Error: some thing wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNewToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateFacilitie frm = new frmAddUpdateFacilitie();
            frm.ShowDialog();
            frmManageFacilities_Load(null, null);
        }

        private void updateToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateFacilitie frm = new frmAddUpdateFacilitie((int)dgvFacilities.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
            frmManageFacilities_Load(null, null);
        }

        private void bunifuImageButton1_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateFacilitie frm = new frmAddUpdateFacilitie();
            frm.ShowDialog();
            frmManageFacilities_Load(null, null);
        }

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            // Get the filter text from the TextBox
            string filterText = txtSearch.Text;

            // Apply the filter to the DataTable
            DataView dv = _dtFacilities.DefaultView;
            dv.RowFilter = $"Name LIKE '%{filterText}%'";

            // Update the DataGridView's DataSource to reflect the filtered data
            dgvFacilities.DataSource = dv.ToTable();

            lblCount.Text = dgvFacilities.Rows.Count.ToString();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmFacilitieDetails frm = new frmFacilitieDetails((int)dgvFacilities.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
