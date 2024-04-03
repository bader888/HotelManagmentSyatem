using HotelLogic;
using MaterialSkin;
using MaterialSkin.Controls;

namespace HotelManagmentSyatem.Hotel_Facilities
{
    public partial class frmFacilitieDetails : MaterialForm
    {

        int? _FacilitieID = null;
        clsFacilite _Facilite = new clsFacilite();
        public frmFacilitieDetails(int FacilitieID)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.LightBlue200, TextShade.WHITE);

            _FacilitieID = FacilitieID;
        }

        private void lblFacilitieName_Click(object sender, System.EventArgs e)
        {

        }

        private void _ResetFacilitieData()
        {
            lblFacilitieID.Text = "[N/M]";
            lblFacilitieName.Text = "[??????]";

        }

        private void _ShowFacilitieData()
        {
            lblFacilitieName.Text = _Facilite.Name;
            lblFacilitieID.Text = _Facilite.ID.ToString();
            if (_Facilite.IconUrl != null)
            {
                bunifuPictureBox1.Load(_Facilite.IconUrl);
            }
        }

        private void frmFacilitieDetails_Load(object sender, System.EventArgs e)
        {
            _Facilite = clsFacilite.FindFacilitieByID((int)_FacilitieID);
            if (_Facilite == null)
            {

                _ResetFacilitieData();

                return;
            }

            _ShowFacilitieData();

        }
    }
}
