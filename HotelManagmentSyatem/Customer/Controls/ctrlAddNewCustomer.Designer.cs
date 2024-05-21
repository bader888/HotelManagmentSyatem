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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lblHeader = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAddNewPerson = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ctrlPersonCard1 = new HotelManagmentSyatem.People.Controls.ctrlPersonCard();
            this.btnFindCustomerByUser = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnAddCustomerByUser = new Bunifu.UI.WinForms.BunifuImageButton();
            this.txtFilterValue = new Bunifu.UI.WinForms.BunifuTextBox();
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
            this.btnAddNewPerson.Location = new System.Drawing.Point(11, 9);
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
            // btnFindCustomerByUser
            // 
            this.btnFindCustomerByUser.ActiveImage = null;
            this.btnFindCustomerByUser.AllowAnimations = true;
            this.btnFindCustomerByUser.AllowBuffering = false;
            this.btnFindCustomerByUser.AllowToggling = false;
            this.btnFindCustomerByUser.AllowZooming = true;
            this.btnFindCustomerByUser.AllowZoomingOnFocus = false;
            this.btnFindCustomerByUser.BackColor = System.Drawing.Color.Transparent;
            this.btnFindCustomerByUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFindCustomerByUser.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnFindCustomerByUser.ErrorImage")));
            this.btnFindCustomerByUser.FadeWhenInactive = false;
            this.btnFindCustomerByUser.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnFindCustomerByUser.Image = global::HotelManagmentSyatem.Properties.Resources.SearchPerson;
            this.btnFindCustomerByUser.ImageActive = null;
            this.btnFindCustomerByUser.ImageLocation = null;
            this.btnFindCustomerByUser.ImageMargin = 40;
            this.btnFindCustomerByUser.ImageSize = new System.Drawing.Size(26, 23);
            this.btnFindCustomerByUser.ImageZoomSize = new System.Drawing.Size(66, 63);
            this.btnFindCustomerByUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnFindCustomerByUser.InitialImage")));
            this.btnFindCustomerByUser.Location = new System.Drawing.Point(473, 4);
            this.btnFindCustomerByUser.Name = "btnFindCustomerByUser";
            this.btnFindCustomerByUser.Rotation = 0;
            this.btnFindCustomerByUser.ShowActiveImage = true;
            this.btnFindCustomerByUser.ShowCursorChanges = true;
            this.btnFindCustomerByUser.ShowImageBorders = true;
            this.btnFindCustomerByUser.ShowSizeMarkers = false;
            this.btnFindCustomerByUser.Size = new System.Drawing.Size(66, 63);
            this.btnFindCustomerByUser.TabIndex = 180;
            this.btnFindCustomerByUser.ToolTipText = "";
            this.btnFindCustomerByUser.WaitOnLoad = false;
            this.btnFindCustomerByUser.Zoom = 40;
            this.btnFindCustomerByUser.ZoomSpeed = 10;
            this.btnFindCustomerByUser.Click += new System.EventHandler(this.btnFindCustomerByUser_Click);
            // 
            // btnAddCustomerByUser
            // 
            this.btnAddCustomerByUser.ActiveImage = null;
            this.btnAddCustomerByUser.AllowAnimations = true;
            this.btnAddCustomerByUser.AllowBuffering = false;
            this.btnAddCustomerByUser.AllowToggling = false;
            this.btnAddCustomerByUser.AllowZooming = true;
            this.btnAddCustomerByUser.AllowZoomingOnFocus = false;
            this.btnAddCustomerByUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCustomerByUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddCustomerByUser.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnAddCustomerByUser.ErrorImage")));
            this.btnAddCustomerByUser.FadeWhenInactive = false;
            this.btnAddCustomerByUser.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnAddCustomerByUser.Image = global::HotelManagmentSyatem.Properties.Resources.Add_Person_40;
            this.btnAddCustomerByUser.ImageActive = null;
            this.btnAddCustomerByUser.ImageLocation = null;
            this.btnAddCustomerByUser.ImageMargin = 40;
            this.btnAddCustomerByUser.ImageSize = new System.Drawing.Size(26, 23);
            this.btnAddCustomerByUser.ImageZoomSize = new System.Drawing.Size(66, 63);
            this.btnAddCustomerByUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnAddCustomerByUser.InitialImage")));
            this.btnAddCustomerByUser.Location = new System.Drawing.Point(545, 4);
            this.btnAddCustomerByUser.Name = "btnAddCustomerByUser";
            this.btnAddCustomerByUser.Rotation = 0;
            this.btnAddCustomerByUser.ShowActiveImage = true;
            this.btnAddCustomerByUser.ShowCursorChanges = true;
            this.btnAddCustomerByUser.ShowImageBorders = true;
            this.btnAddCustomerByUser.ShowSizeMarkers = false;
            this.btnAddCustomerByUser.Size = new System.Drawing.Size(66, 63);
            this.btnAddCustomerByUser.TabIndex = 179;
            this.btnAddCustomerByUser.ToolTipText = "";
            this.btnAddCustomerByUser.WaitOnLoad = false;
            this.btnAddCustomerByUser.Zoom = 40;
            this.btnAddCustomerByUser.ZoomSpeed = 10;
            this.btnAddCustomerByUser.Click += new System.EventHandler(this.btnAddCustomerByUser_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.AcceptsReturn = false;
            this.txtFilterValue.AcceptsTab = false;
            this.txtFilterValue.AnimationSpeed = 200;
            this.txtFilterValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFilterValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFilterValue.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFilterValue.BackgroundImage")));
            this.txtFilterValue.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtFilterValue.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFilterValue.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFilterValue.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFilterValue.BorderRadius = 5;
            this.txtFilterValue.BorderThickness = 1;
            this.txtFilterValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.FillColor = System.Drawing.Color.White;
            this.txtFilterValue.HideSelection = true;
            this.txtFilterValue.IconLeft = null;
            this.txtFilterValue.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.IconPadding = 10;
            this.txtFilterValue.IconRight = null;
            this.txtFilterValue.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.Lines = new string[0];
            this.txtFilterValue.Location = new System.Drawing.Point(236, 15);
            this.txtFilterValue.MaxLength = 32767;
            this.txtFilterValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFilterValue.Modified = false;
            this.txtFilterValue.Multiline = false;
            this.txtFilterValue.Name = "txtFilterValue";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFilterValue.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnIdleState = stateProperties8;
            this.txtFilterValue.Padding = new System.Windows.Forms.Padding(3);
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFilterValue.PlaceholderText = "Enter National No.";
            this.txtFilterValue.ReadOnly = false;
            this.txtFilterValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.SelectionLength = 0;
            this.txtFilterValue.SelectionStart = 0;
            this.txtFilterValue.ShortcutsEnabled = true;
            this.txtFilterValue.Size = new System.Drawing.Size(231, 37);
            this.txtFilterValue.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFilterValue.TabIndex = 178;
            this.txtFilterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilterValue.TextMarginBottom = 0;
            this.txtFilterValue.TextMarginLeft = 3;
            this.txtFilterValue.TextMarginTop = 0;
            this.txtFilterValue.TextPlaceholder = "Enter National No.";
            this.txtFilterValue.UseSystemPasswordChar = false;
            this.txtFilterValue.WordWrap = true;
            // 
            // ctrlAddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnFindCustomerByUser);
            this.Controls.Add(this.btnAddCustomerByUser);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnAddNewPerson);
            this.Name = "ctrlAddNewCustomer";
            this.Size = new System.Drawing.Size(846, 391);
            this.Load += new System.EventHandler(this.ctrlAddNewCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel lblHeader;
        private Bunifu.UI.WinForms.BunifuImageButton btnAddNewPerson;
        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private Bunifu.UI.WinForms.BunifuImageButton btnFindCustomerByUser;
        private Bunifu.UI.WinForms.BunifuImageButton btnAddCustomerByUser;
        private Bunifu.UI.WinForms.BunifuTextBox txtFilterValue;
    }
}
