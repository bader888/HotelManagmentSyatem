using HotelLogic;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Room
{
    public partial class frmManageRooms : Form
    {
        public frmManageRooms()
        {
            InitializeComponent();
        }

        public DataTable dtRooms;

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RoomID = (int)dgvRooms.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to delete Room [" + dgvRooms.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Perform Delele and refresh
                if (clsRoom.DeleteRoom((int)dgvRooms.CurrentRow.Cells[0].Value))
                {
                    bunifuSnackbar1.Show(this,
                        "Room Deleted Successfully",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
                    frmManageRooms_Load_1(null, null);
                }
                else
                    bunifuSnackbar1.Show(this,
                        "Room was not deleted because it has data linked to it",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }

        private void showRoomDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmShowRoomDetails showRoomDetails = new frmShowRoomDetails((int)dgvRooms.CurrentRow.Cells[0].Value);

            showRoomDetails.ShowDialog();

        }

        private void frmManageRooms_Load_1(object sender, EventArgs e)
        {
            dtRooms = clsRoom.GetAllRoom();
            dgvRooms.DataSource = dtRooms;
            lblCount.Text = dtRooms.Rows.Count.ToString();

        }

        private void cbRoomTypeValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = null;
            string FilterValue = null;

            ComboBox Filter = (ComboBox)sender;
            switch (Filter.Name)
            {
                case "cbRoomSizeValue":
                    {
                        FilterValue = cbRoomSizeValue.SelectedItem.ToString();
                        FilterColumn = "Size";
                        break;
                    }
                case "cbStatusValue":
                    {
                        FilterValue = cbStatusValue.SelectedItem.ToString();
                        FilterColumn = "Status";
                        break;
                    }
                case "cbSomkingAllowedValue":
                    {
                        FilterValue = cbSomkingAllowedValue.SelectedItem.ToString();
                        FilterColumn = "SmokingAllowed";
                        break;
                    }
                case "cbRoomTypeValue":
                    {
                        FilterValue = cbRoomTypeValue.SelectedItem.ToString();
                        FilterColumn = "Type";
                        break;
                    }
            }
            if (FilterValue == "None.")
                dtRooms.DefaultView.RowFilter = string.Empty;
            else
                dtRooms.DefaultView.RowFilter = string.Format("{0} like '{1}%'", FilterColumn, FilterValue);


            dgvRooms.DataSource = dtRooms;
            lblCount.Text = dgvRooms.Rows.Count.ToString();

        }

        private void txtSearchRoomNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchRoomNumber.Text.Trim()))

                dtRooms.DefaultView.RowFilter = string.Empty;

            else

                dtRooms.DefaultView.RowFilter = string.Format($"Number = {txtSearchRoomNumber.Text.Trim()}");

            dgvRooms.DataSource = dtRooms;
            lblCount.Text = dgvRooms.Rows.Count.ToString();

        }

        private void txtSearchRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input (0-9) and control keys like backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Cancel the key press if it's not a digit or control key
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bunifuSnackbar1.Show(this, "Not Implemented yet");
        }

        private void addNewRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditRoomInfo frm = new frmAddEditRoomInfo();
            frm.ShowDialog();


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            frmAddEditRoomInfo frm = new frmAddEditRoomInfo();
            frm.ShowDialog();

        }
    }
}
