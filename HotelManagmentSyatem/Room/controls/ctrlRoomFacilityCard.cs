using HotelLogic;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Room.controls
{
    public partial class ctrlRoomFacilityCard : UserControl
    {
        public ctrlRoomFacilityCard()
        {
            InitializeComponent();
        }

        private void _resetDefualtValues()
        {
            lblFacilitiyName.Text = "not Found";
        }

        public void LoadFacilityData(int FacilityID)
        {
            clsFacilite facilite = clsFacilite.FindFacilitieByID(FacilityID);
            if (facilite == null)
            {
                //load defualt values
                _resetDefualtValues();

                return;
            }

            picFacilityImg.Load(facilite.IconUrl);
            lblFacilitiyName.Text = facilite.Name;

        }

    }
}
