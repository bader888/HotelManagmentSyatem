using HotelLogic;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Room_Type
{
    public partial class frmManageRoomTypes : Form
    {
        public frmManageRoomTypes()
        {
            InitializeComponent();
        }

        DataTable dtRoomType;
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageRoomTypes_Load(object sender, EventArgs e)
        {
            dtRoomType = clsRoomType.GetAllRoomType();
            dgvRoomTypes.DataSource = dtRoomType;
            lblCount.Text = dgvRoomTypes.Rows.Count.ToString();

        }

        private void addNewRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditRoomType frm = new frmAddEditRoomType();
            frm.ShowDialog();
            frmManageRoomTypes_Load(null, null);

        }

        private void updateRoomInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditRoomType frm = new frmAddEditRoomType((int)dgvRoomTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageRoomTypes_Load(null, null);
        }

        private void deleteRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MaterialMessageBox.Show("Are you sure you want to delete Room Type [" + dgvRoomTypes.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Perform Delele and refresh
                if (clsRoomType.DeleteRoomType((int)dgvRoomTypes.CurrentRow.Cells[0].Value))
                {
                    bunifuSnackbar1.Show(this,
                        "Room Deleted Successfully",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
                    frmManageRoomTypes_Load(null, null);
                }
                else
                    bunifuSnackbar1.Show(this,
                        "Room type was not deleted because it has data linked to it",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmAddEditRoomType frm = new frmAddEditRoomType();
            frm.ShowDialog();

        }
    }
}
