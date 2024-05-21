using HotelManagmentSyatem.People;
using System;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Customers.Controls
{
    public partial class ctrlAddNewCustomer : UserControl
    {

        // Define a custom event handler delegate with parameters
        public event Action<int> OnPersonSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }

        public event Action<int> OnCustomerAddedByUser;
        protected virtual void CustomerAddedByUser(int CustomerID)
        {
            Action<int> handler = OnCustomerAddedByUser;
            if (handler != null)
            {
                handler(CustomerID); // Raise the event with the parameter
            }
        }



        public enum enAddCustomerMode
        {
            byCustomer,
            byUser
        }

        private enAddCustomerMode _AddCustomerMode;

        public enAddCustomerMode AddCustomerMode
        {
            get
            {
                return _AddCustomerMode;
            }
            set
            {
                _AddCustomerMode = value;
            }
        }


        public int PersonID
        {
            get
            {
                return ctrlPersonCard1.PersonID;
            }
        }

        public bool hideAddNewBtnAndLable
        {
            set
            {
                btnAddNewPerson.Visible = value;
                lblHeader.Visible = true;
            }
        }

        public ctrlAddNewCustomer()
        {
            InitializeComponent();
        }

        private void DataBackEvent(object sender, int PersonID)
        {

            ctrlPersonCard1.LoadPersonInfo(PersonID);
            btnAddNewPerson.Visible = false;
            OnPersonSelected.Invoke(PersonID);

        }

        private void btnAddNewPerson_Click_1(object sender, EventArgs e)
        {

            frmAddEditPerson frm1 = new frmAddEditPerson();
            frm1.DataBack += DataBackEvent; // Subscribe to the event 
            frm1.ShowDialog();
        }

        public void LoadPersonInfo(int PersonID)
        {
            ctrlPersonCard1.LoadPersonInfo(PersonID);

        }


        private void ctrlAddNewCustomer_Load(object sender, EventArgs e)
        {
            btnAddCustomerByUser.Visible = (enAddCustomerMode.byUser == _AddCustomerMode);
            btnFindCustomerByUser.Visible = (enAddCustomerMode.byUser == _AddCustomerMode);
            txtFilterValue.Visible = (enAddCustomerMode.byUser == _AddCustomerMode);
            lblHeader.Visible = (enAddCustomerMode.byUser != _AddCustomerMode);
            btnAddNewPerson.Visible = (enAddCustomerMode.byUser != _AddCustomerMode);

        }

        private void btnAddCustomerByUser_Click(object sender, EventArgs e)
        {

            frmAddEditPerson frm1 = new frmAddEditPerson();
            frm1.DataBack += DataBackEvent; // Subscribe to the event 
            frm1.ShowDialog();
        }

        private void btnFindCustomerByUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {

                MessageBox.Show("Error: please Enter National Number First", "Error: Not Valid Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            ctrlPersonCard1.LoadPersonInfo(txtFilterValue.Text.Trim());
            OnPersonSelected.Invoke((int)ctrlPersonCard1.PersonID);


        }
    }
}
