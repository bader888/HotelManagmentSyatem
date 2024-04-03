using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagmentSyatem.hotel
{
    public partial class frmAddUpdateFacilitie : MaterialForm
    {
        public delegate void SendNewFacilite(clsFacilite NewFacilite);

        // Event to be raised when data is sent to Form1
        public event SendNewFacilite DataSent;

        public delegate void SendNewIconUrel(string NewIcon);

        // Event to be raised when data is sent to Form1
        public event SendNewIconUrel SendNewIcon;

        private bool _UpdateMode = false;
        clsFacilite facilite = new clsFacilite();
        int? _FacilitieID = null;

        public frmAddUpdateFacilitie()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.LightBlue200, TextShade.WHITE);

        }

        public frmAddUpdateFacilitie(int FacilitieID)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey900,
                Accent.LightBlue200,
                TextShade.WHITE);
            _UpdateMode = true;
            _FacilitieID = FacilitieID;
            this.Text = "Update Facilitie";

        }

        private void bunifuTextBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void frmAddUpdateFacilitie_Load(object sender, System.EventArgs e)
        {

            pcFacilitieIcon.Image = Image.FromFile("C:\\Users\\lenovo\\source\\repos\\HotelManagmentSyatem\\hotelImages\\Male 512.png");

            if (_UpdateMode)
            {
                facilite = clsFacilite.FindFacilitieByID((int)_FacilitieID);
                if (facilite == null)
                {
                    MaterialMessageBox.Show($"facilitie with ID = {_FacilitieID} Not Found",
                   "Error: Wrong ID",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   true,
                   FlexibleMaterialForm.ButtonsPosition.Center);

                    return;

                }

                if (facilite.IconUrl != null)
                    pcFacilitieIcon.Load(facilite.IconUrl);
                else
                    pcFacilitieIcon.Image = Image.FromFile("C:\\Users\\lenovo\\source\\repos\\HotelManagmentSyatem\\hotelImages\\Male 512.png");

                txtFacilitieName.Text = facilite.Name;
                lblFacilitieID.Text = facilite.ID.ToString();

            }
        }

        private void bunifuTextBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtFacilitieName.Text.Trim() == string.Empty)
            {
                e.Cancel = true;

                errorProvider1.SetError(txtFacilitieName, "can't by empty");
            }
            else
                errorProvider1.Clear();


        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filters to allow specific image file types
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.ico|All Files|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path
                string selectedImagePath = openFileDialog1.FileName;

                //      _CopyImageToCdDrive(selectedImagePath);

                // Display the selected image in the PictureBox
                pcFacilitieIcon.Image = Image.FromFile(selectedImagePath);
                facilite.IconUrl = selectedImagePath;
                llRemoveImg.Visible = true;

            }
        }

        private void btnSave_Click_1(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MaterialMessageBox.Show("Hover On the read icon",
                    "Error: Some Filed not valid",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    true,
                    FlexibleMaterialForm.ButtonsPosition.Center);
                return;
            }

            if (facilite.IconUrl == null)
            {
                MaterialMessageBox.Show("please select an icon",
                    "Error:Some thing Wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    true,
                    FlexibleMaterialForm.ButtonsPosition.Center);
                return;
            }

            facilite.Name = txtFacilitieName.Text.Trim();
            facilite.IconUrl = clsFileManager.CopyFile(facilite.IconUrl, "C:\\Facilities-Images");
            if (facilite.save())
            {
                MaterialMessageBox.Show("facilitie save Successfully",
                  "info: success",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information,
                  true,
                  FlexibleMaterialForm.ButtonsPosition.Center);
                lblFacilitieID.Text = facilite.ID.ToString();

                this.Text = "Update Facilitie";

                if (_UpdateMode)
                    SendNewIcon?.Invoke(facilite.IconUrl);
                else
                    DataSent?.Invoke(facilite);
            }
            else
                MaterialMessageBox.Show("facilitie faild",
                   "Error:Some thing Wrong",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   true,
                   FlexibleMaterialForm.ButtonsPosition.Center);
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void llRemoveImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pcFacilitieIcon.Image = Image.FromFile("C:\\Users\\lenovo\\source\\repos\\HotelManagmentSyatem\\hotelImages\\Male 512.png");
        }
    }
}
