using HotelLogic;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Hotel_Facilities
{
    public partial class frmFacilitieDetails : Form
    {

        int? _FacilitieID = null;
        clsFacilite _Facilite = new clsFacilite();
        public frmFacilitieDetails(int FacilitieID)
        {
            InitializeComponent();

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
