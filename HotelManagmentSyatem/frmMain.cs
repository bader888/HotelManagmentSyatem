using HotelManagmentSyatem.Hotel_Facilities;
using HotelManagmentSyatem.Log_in;
using HotelManagmentSyatem.People;
using HotelManagmentSyatem.Users;
using System.Windows.Forms;

namespace HotelManagmentSyatem
{
    public partial class FrmMain : Form
    {
        frmLogin _frmLogin;
        public FrmMain(frmLogin frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;

        }


        private void btnManageFacilities_Click(object sender, System.EventArgs e)
        {
            frmManageFacilities frm = new frmManageFacilities();
            frm.ShowDialog();

        }

        private void btnManagePeople_Click(object sender, System.EventArgs e)
        {
            frmManagePeople frm = new frmManagePeople();
            frm.ShowDialog();

        }

        private void bunifuButton2_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            frmManageUsers frm = new frmManageUsers(this);
            frm.ShowDialog();
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, System.EventArgs e)
        {
            _frmLogin.Show();
            this.Close();

        }
    }
}
