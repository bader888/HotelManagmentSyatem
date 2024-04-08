using HotelLogic;
using HotelManagmentSyatem.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Users.Controls
{
    public partial class ctrlUserCard : UserControl
    {
        private clsUser _User;
        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
        }


        public void LoadUserInfo(int UserID)
        {
            _User = clsUser.FinduserByID(UserID);

            if (_User == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }

        private void _FillUserInfo()
        {

            ctrlPersonCard1.LoadPersonInfo((int)_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName.ToString();
            lblRole.Text = clsUser.UserRoleMapping[(int)_User.Role];

            if ((bool)_User.IsActive)
            {
                lblIsActive.Text = "Yes";
                lblIsActive.ForeColor = Color.ForestGreen;
                pbActivation.Image = Resources.ActiveUser;
            }
            else
            {
                lblIsActive.Text = "No";
                lblIsActive.ForeColor = Color.Red;
                pbActivation.Image = Resources.NotActiveUser;
            }

        }
        private void _ResetPersonInfo()
        {

            ctrlPersonCard1.ResetPersonInfo();
            lblUserID.Text = "[???]";
            lblUserName.Text = "[???]";
            lblIsActive.Text = "[???]";
            lblRole.Text = "[???]";
        }
        public ctrlUserCard()
        {
            InitializeComponent();
        }
    }
}
