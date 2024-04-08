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
            // Handle the data received  
            ctrlPersonCard1.LoadPersonInfo(PersonID);
            btnAddNewPerson.Visible = false;
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


    }
}
