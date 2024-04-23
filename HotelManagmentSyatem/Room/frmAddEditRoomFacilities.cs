using HotelLogic;
using HotelManagmentSyatem.Room.controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Room
{
    public partial class frmAddEditRoomFacilities : Form
    {
        public frmAddEditRoomFacilities(int RoomID, enMode mode)
        {
            InitializeComponent();
            _RoomID = RoomID;
            _Mode = mode;
        }

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, enMode Mode);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        int _RoomID = -1;

        List<int> FacilityiesIDs = new List<int>();

        private void _LoadData()
        {

            DataTable dtRoomFacilities = clsRoomFacility.GetAllFacilitiesForRoomID(_RoomID);

            flpRoomFacilities.Controls.Clear();
            FacilityiesIDs.Clear();


            lblHeader.Text = "Update Room Facilities";

            if (dtRoomFacilities.Rows.Count > 0)
            {
                foreach (DataRow Row in dtRoomFacilities.Rows)
                {
                    ctrlRoomFacility roomFacility = new ctrlRoomFacility();

                    roomFacility.FacilityImage = Row["IconUrl"].ToString();
                    roomFacility.FacilityName = Row["Name"].ToString();
                    roomFacility.RoomFacilityID = (int)Row["ID"];
                    roomFacility.FacilityID = (int)Row["Facility_id"];

                    FacilityiesIDs.Add((int)Row["Facility_id"]);

                    roomFacility.DataSent += RemoveFacility;
                    flpRoomFacilities.Controls.Add(roomFacility);
                }
            }
            lblCount.Text = FacilityiesIDs.Count.ToString();
        }

        private void frmAddEditRoomFacilities_Load(object sender, EventArgs e)
        {
            dgvFacilities.DataSource = clsFacilite.GetAllFacilitie();

            if (_Mode == enMode.Update)
                _LoadData();

        }

        private void dgvFacilities_DoubleClick(object sender, EventArgs e)
        {
            int FacilityID = (int)dgvFacilities.CurrentRow.Cells[0].Value;

            if (FacilityiesIDs.Exists(ele => ele == FacilityID))
            {
                bunifuSnackbar1.Show(this, "this Facility added to the list , please select another one", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }

            ctrlRoomFacility roomFacility = new ctrlRoomFacility();

            roomFacility.FacilityImage = (string)dgvFacilities.CurrentRow.Cells[2].Value;

            roomFacility.FacilityName = (string)dgvFacilities.CurrentRow.Cells[1].Value;

            roomFacility.FacilityID = FacilityID;

            FacilityiesIDs.Add(FacilityID);

            roomFacility.DataSent += RemoveFacility;

            flpRoomFacilities.Controls.Add(roomFacility);

            lblCount.Text = FacilityiesIDs.Count.ToString();

            btnSave.Enabled = true;
        }

        private void RemoveFacility(object sender, int RoomFacilityID, int FacilityID)
        {

            if (clsRoomFacility.DeleteRoomFacility(RoomFacilityID) && FacilityiesIDs.Remove(FacilityID))
            {

                bunifuSnackbar1.Show(this, "Delete Room Facility Successd",

               Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);

                flpRoomFacilities.Controls.Remove((ctrlRoomFacility)sender);


                if (FacilityiesIDs.Count == 0)
                {
                    btnSave.Enabled = false;
                }

                lblCount.Text = FacilityiesIDs.Count.ToString();
            }
            else
                bunifuSnackbar1.Show(this, "Delete Room Facility Faild", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);



        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (FacilityiesIDs.Count == 0)
            {
                bunifuSnackbar1.Show(this, "Error: Please Select Facilities First.",
                   Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }

            clsRoomFacility RoomFacility = new clsRoomFacility();

            RoomFacility.facilitites_ids = string.Join(",", FacilityiesIDs);

            RoomFacility.room_id = _RoomID;

            if (RoomFacility.Save())
            {
                bunifuSnackbar1.Show(this, "Data Saved Successfully.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
                DataBack?.Invoke(this, enMode.Update);
                _Mode = enMode.Update;
                _LoadData();
            }
            else
                bunifuSnackbar1.Show(this, "Error: Data Is not Saved Successfully.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
