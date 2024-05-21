using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using HotelManagmentSyatem.User_Reservation;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Reservation
{
    public partial class frmManageReservations : Form
    {

        DataTable dtReservations = new DataTable();


        public frmManageReservations()
        {
            InitializeComponent();
            cbFilterByColumn.SelectedIndex = 0;
            cbActivationFilter.Visible = false;
            txtSearchValue.Visible = false;

        }

        private void frmManageReservations_Load(object sender, EventArgs e)
        {
            dtReservations = clsReservation.GetAllReservation();
            if (dtReservations.Rows.Count > 0)
            {
                dgvReservations.DataSource = dtReservations;
                lblCount.Text = dtReservations.Rows.Count.ToString();

            }
        }

        private void cbFilterByColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtReservations.DefaultView.RowFilter = "";
            lblCount.Text = dgvReservations.Rows.Count.ToString();


            if (cbFilterByColumn.SelectedItem.ToString() == "Status")
            {
                cbActivationFilter.SelectedIndex = 0;
            }

            cbActivationFilter.Visible = cbFilterByColumn.SelectedItem.ToString() == "Status";
            txtSearchValue.Visible = cbFilterByColumn.SelectedItem.ToString() == "ID"
                || cbFilterByColumn.SelectedItem.ToString().Trim() == "Full Name" || cbFilterByColumn.SelectedItem.ToString().Trim() == "Room Number";


        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchValue.Text.Trim() == string.Empty)
            {
                dtReservations.DefaultView.RowFilter = "";
                lblCount.Text = dgvReservations.Rows.Count.ToString();

                return;
            }

            string FilterColumn = null;

            switch (cbFilterByColumn.SelectedItem.ToString())
            {
                case "ID":
                    {
                        FilterColumn = "ID";
                        break;
                    }
                case "Full Name":
                    {
                        FilterColumn = "FullName";
                        break;

                    }
                case "Room Number":
                    {
                        FilterColumn = "RoomNumber";
                        break;

                    }
                default:
                    {
                        FilterColumn = "None";
                        break;
                    }
            }
            if (FilterColumn != "ID" && FilterColumn != "RoomNumber")
                dtReservations.DefaultView.RowFilter = string.Format("{0} like '{1}%'", FilterColumn, txtSearchValue.Text.Trim());
            else
                dtReservations.DefaultView.RowFilter = string.Format("{0} = {1} ", FilterColumn, txtSearchValue.Text.Trim());

            lblCount.Text = dgvReservations.Rows.Count.ToString();
        }

        private void cbActivationFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbActivationFilter.SelectedItem.ToString() == "All")
            {
                dtReservations.DefaultView.RowFilter = "";
                lblCount.Text = dgvReservations.Rows.Count.ToString();
                return;
            }
            string FilterValue = cbActivationFilter.SelectedItem.ToString().Trim()
                ;
            dtReservations.DefaultView.RowFilter = string.Format(" reservation_status like '{0}%'", FilterValue);

            lblCount.Text = dgvReservations.Rows.Count.ToString();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowReservationDetails frm = new frmShowReservationDetails((int)dgvReservations.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure want to cancel reservation with id = {(int)dgvReservations.CurrentRow.Cells[0].Value}",
                "Confirm Cancel Reservation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsReservation reservation = clsReservation.FindReservationByID((int)dgvReservations.CurrentRow.Cells[0].Value);
                if (reservation != null)
                {
                    reservation.reservation_status = (byte)clsReservation.enReservationStatus.Cancel;
                    if (reservation.Save())
                    {

                        bunifuSnackbar1.Show(this, "The reservation Cancel Successfuly", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);

                        frmManageReservations_Load(null, null);
                    }
                    else
                        bunifuSnackbar1.Show(this, "The reservation Cancel Faild", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);

                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsReservation reservation = clsReservation.FindReservationByID((int)dgvReservations.CurrentRow.Cells[0].Value);

            cancelToolStripMenuItem.Enabled = reservation.reservation_status != (byte)clsReservation.enReservationStatus.Cancel && reservation.reservation_status != (byte)clsReservation.enReservationStatus.Confirmed;
            deleteReservationToolStripMenuItem.Enabled = reservation.reservation_status == (byte)clsReservation.enReservationStatus.Cancel;
            confirmToolStripMenuItem.Enabled = reservation.reservation_status == (byte)clsReservation.enReservationStatus.Pending;
        }

        private void confirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure want to Confirm reservation with id = {(int)dgvReservations.CurrentRow.Cells[0].Value}",
                "Confirm Reservation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsReservation reservation = clsReservation.FindReservationByID((int)dgvReservations.CurrentRow.Cells[0].Value);
                if (reservation != null)
                {
                    reservation.reservation_status = (byte)clsReservation.enReservationStatus.Confirmed;
                    if (reservation.Save())
                    {
                        // send message to the guest automaticly 

                        clsMessage newMessage = new clsMessage();
                        newMessage.CustomerID = reservation.customer_id;
                        newMessage.UserID = 9; //get from the current user 
                        newMessage.MsgBody = string.Format("The reservation With ID = {0} Is Confirm ,from {1} to {2}",
                            reservation.reservationID,
                            clsFormat.DateToShort((DateTime)reservation.check_out_date),
                            clsFormat.DateToShort((DateTime)reservation.check_in_date));
                        newMessage.MsgSubject = "Confirm Reservation";
                        newMessage.MsgDate = DateTime.Now;

                        if (newMessage.Send())
                        {
                            bunifuSnackbar1.Show(this, "The reservation Confirm Successfuly", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
                        }

                        frmManageReservations_Load(null, null);
                    }
                    else
                        bunifuSnackbar1.Show(this, "The reservation Confirm Faild", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);

                }
            }
        }

        private void deleteReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure want to Delete reservation with id = {(int)dgvReservations.CurrentRow.Cells[0].Value}",
              "Confirm Delete Reservation",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsReservation.DeleteReservation((int)dgvReservations.CurrentRow.Cells[0].Value))
                {
                    bunifuSnackbar1.Show(this, "The reservation Delete Successfuly", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);

                    frmManageReservations_Load(null, null);
                }
                else
                {

                    bunifuSnackbar1.Show(this, "The reservation Delete Faild", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmReservationByUsers frm = new frmReservationByUsers();
            frm.ShowDialog();

        }
    }
}
