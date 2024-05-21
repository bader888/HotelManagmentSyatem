using System.Windows.Forms;

namespace HotelManagmentSyatem.Reservation
{
    public partial class frmPaymentDetails : Form
    {
        public enum enMode
        {
            AddNew,
            Update
        }

        enMode _Mode = enMode.AddNew;


        public frmPaymentDetails(enMode Mode)
        {
            InitializeComponent();
            _Mode = Mode;

        }

        private void frmPaymentDetails_Load(object sender, System.EventArgs e)
        {


            //if was exists
            ctrlPaymentDetailsCard1.LoadCardData();


        }
    }
}
