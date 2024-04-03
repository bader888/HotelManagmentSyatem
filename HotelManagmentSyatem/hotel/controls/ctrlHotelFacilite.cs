using HotelLogic;
using HotelManagmentSyatem.hotel;
using HotelManagmentSyatem.Properties;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace HotelManagmentSyatem
{
    public partial class ctrlHotelFacilite : UserControl
    {
        public ctrlHotelFacilite()
        {
            InitializeComponent();
        }

        // Delegate declaration
        public delegate void DataSender(string data);

        // Event to be raised when data is sent from Form2
        public event DataSender DataSent;

        //check event 
        // Define a delegate for the Check event
        public delegate void CheckEventHandler(int FaciliteID);
        // Define the Check event based on the delegate
        public event CheckEventHandler Check;

        // Method to raise the Check event
        protected virtual void OnCheck(int FaciliteID)
        {
            Check.Invoke(FaciliteID);
        }


        // Define the event
        public event EventHandler CustomEvent;

        // Method to raise the event
        protected virtual void OnCustomEvent()
        {
            // Raise the event
            CustomEvent?.Invoke(this, EventArgs.Empty);
        }


        private int _FaciliteID;
        public int FaciliteID
        {
            get
            {
                return _FaciliteID;
            }
            set
            {
                _FaciliteID = value;
            }
        }
        public string FacilitieName
        {
            get
            {
                return lblFaciliteName.Text.Trim();
            }
            set
            {
                lblFaciliteName.Text = value;
            }
        }
        public string IconUrl
        {
            get
            {
                return pcFaciliteImage.Image.ToString();
            }
            set
            {
                if (value == string.Empty)
                    pcFaciliteImage.Image = Resources.Close_64;
                else
                    pcFaciliteImage.Load(value);
            }
        }

        private void ctrlHotelFacilite_Load(object sender, System.EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(this.FaciliteID.ToString() + " name: " + this.Name.ToString());
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateFacilitie frm = new frmAddUpdateFacilitie(this.FaciliteID);
            frm.SendNewIcon += SetNewIcon;
            frm.ShowDialog();

        }

        private void SetNewIcon(string NewIcon)
        {
            this.IconUrl = NewIcon;
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (MaterialMessageBox.Show("are you sure you want to delete this facilitie? ",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {


                if (clsFacilite.DeleteFacilitie(this.FaciliteID))
                {
                    MaterialMessageBox.Show("Facilite Delete Successfully",
                       "Success",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       true,
                       FlexibleMaterialForm.ButtonsPosition.Center);

                    // When some action happens, raise the event
                    OnCustomEvent();
                }
                else
                {
                    MaterialMessageBox.Show("Faild to delete",
                       "Error:Some thing Wrong",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error,
                       true,
                       FlexibleMaterialForm.ButtonsPosition.Center);
                }

            }
        }


        private void ckFacilite_Click(object sender, EventArgs e)
        {
            OnCheck(this.FaciliteID);
        }
    }
}
