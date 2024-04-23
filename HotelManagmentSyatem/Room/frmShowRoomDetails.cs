using Bunifu.UI.WinForms.BunifuAnimatorNS;
using System.Threading.Tasks;
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

        async private void frmShowRoomDetails_Load(object sender, System.EventArgs e)
        {
            await Task.Delay(50);
            bunifuTransition1.ShowSync(ctrlRoomCard1, false, Animation.ScaleAndHorizSlide);
            ctrlRoomCard1.LoadRoomInfo(_RoomID);
        }

        private void btnCloseForm_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
