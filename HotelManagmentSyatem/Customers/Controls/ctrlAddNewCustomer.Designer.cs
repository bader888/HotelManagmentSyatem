namespace HotelManagmentSyatem.Customers.Controls
{
    partial class ctrlAddNewCustomer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAddNewCustomer));
            this.lblHeader = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAddNewPerson = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ctrlPersonCard1 = new HotelManagmentSyatem.People.Controls.ctrlPersonCard();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AllowParentOverrides = false;
            this.lblHeader.AutoEllipsis = false;
            this.lblHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHeader.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHeader.Location = new System.Drawing.Point(73, 32);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHeader.Size = new System.Drawing.Size(218, 17);
            this.lblHeader.TabIndex = 176;
            this.lblHeader.Text = "Click Here to add  your information.";
            this.lblHeader.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblHeader.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.ActiveImage = null;
            this.btnAddNewPerson.AllowAnimations = true;
            this.btnAddNewPerson.AllowBuffering = false;
            this.btnAddNewPerson.AllowToggling = false;
            this.btnAddNewPerson.AllowZooming = true;
            this.btnAddNewPerson.AllowZoomingOnFocus = false;
            this.btnAddNewPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewPerson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewPerson.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewPerson.ErrorImage")));
            this.btnAddNewPerson.FadeWhenInactive = false;
            this.btnAddNewPerson.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnAddNewPerson.Image = global::HotelManagmentSyatem.Properties.Resources.Add_Person_40;
            this.btnAddNewPerson.ImageActive = null;
            this.btnAddNewPerson.ImageLocation = null;
            this.btnAddNewPerson.ImageMargin = 40;
            this.btnAddNewPerson.ImageSize = new System.Drawing.Size(26, 23);
            this.btnAddNewPerson.ImageZoomSize = new System.Drawing.Size(66, 63);
            this.btnAddNewPerson.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewPerson.InitialImage")));
            this.btnAddNewPerson.Location = new System.Drawing.Point(11, 4);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Rotation = 0;
            this.btnAddNewPerson.ShowActiveImage = true;
            this.btnAddNewPerson.ShowCursorChanges = true;
            this.btnAddNewPerson.ShowImageBorders = true;
            this.btnAddNewPerson.ShowSizeMarkers = false;
            this.btnAddNewPerson.Size = new System.Drawing.Size(66, 63);
            this.btnAddNewPerson.TabIndex = 174;
            this.btnAddNewPerson.ToolTipText = "";
            this.btnAddNewPerson.WaitOnLoad = false;
            this.btnAddNewPerson.Zoom = 40;
            this.btnAddNewPerson.ZoomSpeed = 10;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click_1);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(11, 73);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(830, 298);
            this.ctrlPersonCard1.TabIndex = 177;
            // 
            // ctrlAddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnAddNewPerson);
            this.Name = "ctrlAddNewCustomer";
            this.Size = new System.Drawing.Size(846, 391);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel lblHeader;
        private Bunifu.UI.WinForms.BunifuImageButton btnAddNewPerson;
        private People.Controls.ctrlPersonCard ctrlPersonCard1;
    }
}
