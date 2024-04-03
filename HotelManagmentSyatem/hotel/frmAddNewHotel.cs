using MaterialSkin;
using MaterialSkin.Controls;

namespace HotelManagmentSyatem.hotel
{
    public partial class frmAddNewHotel : MaterialForm
    {
        public frmAddNewHotel()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.LightBlue200, TextShade.WHITE);

        }

        private void bunifuButton1_Click(object sender, System.EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, System.EventArgs e)
        {

        }

        private void bunifuShadowPanel1_ControlAdded(object sender, System.Windows.Forms.ControlEventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, System.EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, System.EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, System.EventArgs e)
        {

        }

        private void bunifuTextBox3_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, System.EventArgs e)
        {

        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void frmAddNewHotel_Load(object sender, System.EventArgs e)
        {

        }
    }
}
