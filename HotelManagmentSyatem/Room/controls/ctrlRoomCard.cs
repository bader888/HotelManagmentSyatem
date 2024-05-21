using Bunifu.Framework.UI;
using HotelLogic;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Room.controls
{
    public partial class ctrlRoomCard : UserControl
    {
        private clsRoom _Room;
        private int _RoomID = -1;

        public int RoomID
        {
            get { return _RoomID; }
        }

        public clsRoom SelectedRoomInfo
        {
            get { return _Room; }
        }

        public ctrlRoomCard()
        {
            InitializeComponent();
        }

        public bool BtnAddImagesVisiable
        {
            set
            {
                btnAddNewRoomImage.Visible = value;
            }
        }

        public bool BtnEditRoomInfoVisiable
        {
            set
            {
                btnEditRoomInfo.Visible = value;
            }
        }

        public bool BtnAddFacilitiesVisiable
        {
            set
            {
                btnAddNewRoomFacilities.Visible = value;
            }
        }

        public void ResetRoomInfo()
        {
            _RoomID = -1;
            lblDescription.Text = "[????]";
            lblIsBetFriendly.Text = "[????]";
            lblIsSmokingAllowed.Text = "[????]";
            lblnumber.Text = "[????]";
            lblNumberOFBeds.Text = "[????]";
            lblNumberOfPeople.Text = "[????]";
            lblrate.Text = "[????]";
            lblRoomID.Text = "[????]";
            lblRoomSize.Text = "[????]";
            lblRoomType.Text = "[????]";
            lblStatus.Text = "[????]";
            lblView.Text = "[????]";
        }


        private void _FillRoomImages()
        {
            DataTable roomImage = clsRoomImage.GetAllImagesForRoomID(_RoomID);
            if (roomImage.Rows.Count > 0)
            {
                foreach (DataRow row in roomImage.Rows)
                {

                    try
                    {

                        picRoomOne.Load(roomImage.Rows[0]["imagePath"].ToString());
                        BunifuImageButton bunifuImagebtn = new BunifuImageButton();
                        bunifuImagebtn.Click += BunifuImagebtn_Click;
                        bunifuImagebtn.Load(row["imagePath"].ToString());
                        flpRoomImages.Controls.Add(bunifuImagebtn);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }

        }

        private void BunifuImagebtn_Click(object sender, EventArgs e)
        {
            BunifuImageButton btn = (BunifuImageButton)sender;
            picRoomOne.Load(btn.ImageLocation.ToString());
        }

        private void _FillRoomFacilities()
        {

            flpRoomFacilities.Controls.Clear();

            DataTable roomFacilities = clsRoomFacility.GetAllFacilitiesForRoomID(this.RoomID);
            if (roomFacilities.Rows.Count > 0)
            {
                foreach (DataRow row in roomFacilities.Rows)
                {

                    ctrlRoomFacilityCard roomFacilityCard = new ctrlRoomFacilityCard();
                    roomFacilityCard.LoadFacilityData((int)row["facility_id"]);
                    flpRoomFacilities.Controls.Add(roomFacilityCard);

                }
            }
        }


        private void _FillRoomInfo()
        {
            _RoomID = (int)_Room.room_id;
            lblDescription.Text = _Room.room_description.ToString();
            lblIsBetFriendly.Text = _Room.is_pet_friendly == true ? "Yes" : "No";
            lblIsSmokingAllowed.Text = _Room.is_smoking_allowed == true ? "Yes" : "Now";
            lblnumber.Text = _Room.room_number.ToString();
            lblNumberOFBeds.Text = _Room.number_of_beds.ToString();
            lblNumberOfPeople.Text = _Room.number_of_people.ToString();
            lblrate.Text = _Room.room_rate.ToString();
            lblRoomID.Text = _Room.room_id.ToString();
            lblRoomSize.Text = clsRoom.RoomSize[(int)_Room.room_size];
            lblRoomType.Text = _Room.room_type_id.ToString();
            lblStatus.Text = clsRoom.RoomStatus[(int)_Room.room_status];
            lblView.Text = clsRoom.RoomView[(int)_Room.room_view];

            //load room facilities
            _FillRoomFacilities();


            //load room images
            _FillRoomImages();


        }


        public void LoadRoomInfo(int RoomID)
        {
            _Room = clsRoom.FindRoomByID(RoomID);
            if (_Room == null)
            {
                ResetRoomInfo();
                MessageBox.Show("No Room with RoomID = " + RoomID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            flpRoomImages.Controls.Clear();
            flpRoomFacilities.Controls.Clear();

            _FillRoomInfo();
        }


        private void btnEditRoomInfo_Click(object sender, EventArgs e)
        {
            frmAddEditRoom frm = new frmAddEditRoom(this.RoomID);
            frm.ShowDialog();
            LoadRoomInfo(this.RoomID);
        }

        private void btnAddNewRoomFacilities_Click(object sender, EventArgs e)
        {
            frmAddEditRoomFacilities frm = new frmAddEditRoomFacilities(this.RoomID, frmAddEditRoomFacilities.enMode.Update);
            frm.ShowDialog();
            LoadRoomInfo(this.RoomID);

        }

        private void btnAddNewRoomImage_Click(object sender, EventArgs e)
        {
            frmAddEditRoomImages frm = new frmAddEditRoomImages(this.RoomID, frmAddEditRoomImages.enMode.Update);
            frm.ShowDialog();
            LoadRoomInfo(this.RoomID);


        }
    }
}
