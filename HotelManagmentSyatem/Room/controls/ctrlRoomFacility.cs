using System.Windows.Forms;

namespace HotelManagmentSyatem.Room.controls
{
    public partial class ctrlRoomFacility : UserControl
    {
        public delegate void delDeleteFacility(object sender, int RoomFacilityID, int FacilityID);

        public event delDeleteFacility DataSent;
        public ctrlRoomFacility()
        {
            InitializeComponent();
        }
        private int _FacilityID = -1;
        public int FacilityID
        {
            get
            {
                return _FacilityID;
            }
            set
            {
                _FacilityID = value;
            }
        }

        private int _RoomFacilityID = -1;

        public int RoomFacilityID
        {
            get
            {
                return _RoomFacilityID;
            }
            set
            {
                _RoomFacilityID = value;
            }
        }
        public string FacilityImage
        {
            //make defualt img if not exists
            set
            {
                picFacilityImg.Load(value);
            }
        }

        public string FacilityName
        {
            set
            {
                lblFacilityName.Text = value;
            }
        }


        private void btnClosr_Click(object sender, System.EventArgs e)
        {
            //send the facility tag to the caller 
            DataSent?.Invoke(this, (int)this.RoomFacilityID, (int)this.FacilityID);

        }
    }
}
