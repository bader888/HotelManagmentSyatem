using Bunifu.UI.WinForms.BunifuAnimatorNS;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HotelManagmentSyatem.People
{
    public partial class frmPersonDetails : Form
    {


        private async void Form1_Load(object sender, EventArgs e)
        {

            await Task.Delay(50);
            bunifuTransition1.ShowSync(ctrlPersonCard1, false, Animation.ScaleAndHorizSlide);
            ctrlPersonCard1.LoadPersonInfo((int)_personID);

        }

        int? _personID = null;

        public frmPersonDetails(int PersonID)
        {
            InitializeComponent();
            _personID = PersonID;

        }



        private void btnCloseForm_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
