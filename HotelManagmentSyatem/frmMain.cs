using HotelManagmentSyatem.Hotel_Facilities;
using HotelManagmentSyatem.People;
using System.Windows.Forms;

namespace HotelManagmentSyatem
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();


        }

        private void bunifuPanel1_Click(object sender, System.EventArgs e)
        {

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
    }
}
