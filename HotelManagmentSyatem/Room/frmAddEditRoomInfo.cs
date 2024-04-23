using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Room
{
    public partial class frmAddEditRoomInfo : Form
    {
        public frmAddEditRoomInfo()
        {
            InitializeComponent();



        }

        public frmAddEditRoomInfo(int RoomID)
        {
            InitializeComponent();
            _RoomID = RoomID;
            _ModeRoom = enModeRoom.Update;


        }

        int _RoomID = -1;

        public enum enModeRoom { AddNew = 0, Update = 1 }
        public enum enModeInfo { AddNew = 0, Update = 1 };
        public enum enModeImages { AddNew = 0, Update = 1 };
        public enum enModeFacilities { AddNew = 0, Update = 1 };

        enModeInfo _ModeInfo = enModeInfo.AddNew;
        enModeImages _ModeImages = enModeImages.AddNew;
        enModeFacilities _ModeFacilities = enModeFacilities.AddNew;
        enModeRoom _ModeRoom = enModeRoom.AddNew;

        private void btnAddRoom_Click(object sender, EventArgs e)
        {

            if (_ModeInfo == enModeInfo.Update)
            {
                frmAddEditRoom frmAddEditRoom = new frmAddEditRoom(_RoomID);
                frmAddEditRoom.ShowDialog();
                return;
            }

            frmAddEditRoom frm = new frmAddEditRoom();
            frm.DataBack += DataBackFromRoomInfo;
            frm.ShowDialog();

            //if the user open the form and close it with out add any room this mean the roomid = -1 
            //otherwise the user add the room info this mean the roomid != -1 
            if (_RoomID != -1)
            {
                btnAddRoom.ForeColor = Color.Blue;
                btnAddRoom.IdleBorderColor = Color.Blue;
                btnAddRoom.IdleFillColor = Color.Blue;
                lblRoomInfo.Text = "Update Room";

                //show the add room images
                btnRoomImages.Enabled = true;
                btnRoomImages.IdleBorderColor = Color.Blue;
                btnRoomImages.IdleFillColor = Color.Blue;
                btnRoomImages.ForeColor = Color.White;
                bunifuSeparator1.LineColor = Color.Blue;
            }
        }

        private void btnRoomImages_Click(object sender, EventArgs e)
        {
            frmAddEditRoomImages frm = new frmAddEditRoomImages(_RoomID,
                (frmAddEditRoomImages.enMode)_ModeImages);
            frm.DataBack += DataBackFromRoomImages;
            frm.ShowDialog();


            //show the add room facilities btn
            //some time the user open the Images form and close it with out adding any facilities so we should handle this case   
            /// enmodeimages.update this mean the user add the images to the room 
            if (_ModeImages == enModeImages.Update)
            {

                lblRoomImages.Text = "Update Room Images";
                btnRoomFacility.ForeColor = Color.Blue;
                btnRoomFacility.IdleBorderColor = Color.Blue;
                btnRoomFacility.IdleFillColor = Color.Blue;

                bunifuSeparator2.LineColor = Color.Blue;

                btnRoomFacility.Enabled = true;
            }

        }

        private void btnRoomFacility_Click(object sender, EventArgs e)
        {
            frmAddEditRoomFacilities frm = new frmAddEditRoomFacilities(_RoomID, (frmAddEditRoomFacilities.enMode)_ModeFacilities);
            frm.DataBack += DataBackFromRoomFacilities;
            frm.ShowDialog();

            //some time the user open the facilities form and close it with out adding any facilities so we should handle this case  
            ///enModeFacilities.Update this mean the user add the Facilities to the room 
            if (_ModeFacilities == enModeFacilities.Update)
            {

                lblRoomFacilities.Text = "Update Room Facilities";
                btnRoomFacility.ForeColor = Color.Blue;
                btnRoomFacility.IdleBorderColor = Color.Blue;
                btnRoomFacility.IdleFillColor = Color.Blue;
                btnRoomFacility.ForeColor = Color.Blue;

            }

        }

        private void _ResetDefaultValues()
        {
            if (_ModeRoom == enModeRoom.Update)
            {
                bunifuSeparator1.LineColor = Color.Blue;
                bunifuSeparator2.LineColor = Color.Blue;

                btnRoomImages.Enabled = true;
                btnRoomFacility.Enabled = true;

                //labels
                lblRoomFacilities.Text = "Update Room Facilities";
                lblRoomImages.Text = "Update Room Images";
                lblRoomInfo.Text = "Update Room Info.";
                bunifuLabel1.Text = "edite room information.";

                _ModeFacilities = enModeFacilities.Update;
                _ModeImages = enModeImages.Update;
                _ModeInfo = enModeInfo.Update;
            }
            else
            {

                bunifuSeparator1.LineColor = Color.Black;
                bunifuSeparator2.LineColor = Color.Black;

                btnRoomImages.Enabled = false;
                btnRoomFacility.Enabled = false;

                lblRoomFacilities.Text = "Add Room Facilities";
                lblRoomImages.Text = "Add Room Images";
                lblRoomInfo.Text = "Add Room Info.";
                bunifuLabel1.Text = "Add new room information.";


            }
        }

        private void frmAddEditRoomInfo_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
        }

        private void DataBackFromRoomInfo(object sender, int RoomID, frmAddEditRoom.enMode Mode)
        {
            _RoomID = RoomID;
            _ModeInfo = (enModeInfo)Mode;
        }

        private void DataBackFromRoomImages(object sender, frmAddEditRoomImages.enMode Mode)
        {
            _ModeImages = (enModeImages)Mode;
        }

        private void DataBackFromRoomFacilities(object sender, frmAddEditRoomFacilities.enMode Mode)
        {

            _ModeFacilities = (enModeFacilities)Mode;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
