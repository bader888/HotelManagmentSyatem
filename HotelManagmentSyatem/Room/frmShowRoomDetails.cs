using System.Windows.Forms;

namespace HotelManagmentSyatem.Room
{
    public partial class frmShowRoomDetails : Form
    {
        int _RoomID = -1;
        public frmShowRoomDetails(int RoomID)
        {
            InitializeComponent();

            _RoomID = RoomID;
        }

        private void frmShowRoomDetails_Load(object sender, System.EventArgs e)
        {

            ctrlRoomCard2.LoadRoomInfo(_RoomID);
        }

        public void HideBtnFromCustomer()
        {

            ctrlRoomCard2.BtnAddFacilitiesVisiable = false;
            ctrlRoomCard2.BtnAddImagesVisiable = false;
            ctrlRoomCard2.BtnEditRoomInfoVisiable = false;
        }

        private void btnCloseForm_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
