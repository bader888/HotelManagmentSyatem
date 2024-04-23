namespace HotelManagmentSyatem.hotel
{
    partial class frmAddUpdateFacilitie
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.Framework.UI.BunifuElipse btnCancelBorderRadio;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateFacilitie));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.txtFacilitieName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblFacilitieID = new Bunifu.UI.WinForms.BunifuLabel();
            this.pcFacilitieIcon = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.llRemoveImg = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.formRadiuo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnSaveBorderRadiuo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            btnCancelBorderRadio = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcFacilitieIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelBorderRadio
            // 
            btnCancelBorderRadio.ElipseRadius = 10;
            btnCancelBorderRadio.TargetControl = this.btnSave;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = ((System.Drawing.Image)(resources.GetObject("btnSave.Icon")));
            this.btnSave.Location = new System.Drawing.Point(337, 247);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(112, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtFacilitieName
            // 
            this.txtFacilitieName.AcceptsReturn = false;
            this.txtFacilitieName.AcceptsTab = false;
            this.txtFacilitieName.AnimationSpeed = 200;
            this.txtFacilitieName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFacilitieName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFacilitieName.BackColor = System.Drawing.Color.Transparent;
            this.txtFacilitieName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFacilitieName.BackgroundImage")));
            this.txtFacilitieName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtFacilitieName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFacilitieName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtFacilitieName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFacilitieName.BorderRadius = 1;
            this.txtFacilitieName.BorderThickness = 1;
            this.txtFacilitieName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFacilitieName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFacilitieName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtFacilitieName.DefaultText = "";
            this.txtFacilitieName.FillColor = System.Drawing.Color.White;
            this.txtFacilitieName.HideSelection = true;
            this.txtFacilitieName.IconLeft = null;
            this.txtFacilitieName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFacilitieName.IconPadding = 10;
            this.txtFacilitieName.IconRight = null;
            this.txtFacilitieName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFacilitieName.Lines = new string[0];
            this.txtFacilitieName.Location = new System.Drawing.Point(22, 145);
            this.txtFacilitieName.MaxLength = 32767;
            this.txtFacilitieName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFacilitieName.Modified = false;
            this.txtFacilitieName.Multiline = false;
            this.txtFacilitieName.Name = "txtFacilitieName";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFacilitieName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFacilitieName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFacilitieName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFacilitieName.OnIdleState = stateProperties4;
            this.txtFacilitieName.Padding = new System.Windows.Forms.Padding(3);
            this.txtFacilitieName.PasswordChar = '\0';
            this.txtFacilitieName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFacilitieName.PlaceholderText = "Facilitie Name";
            this.txtFacilitieName.ReadOnly = false;
            this.txtFacilitieName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFacilitieName.SelectedText = "";
            this.txtFacilitieName.SelectionLength = 0;
            this.txtFacilitieName.SelectionStart = 0;
            this.txtFacilitieName.ShortcutsEnabled = true;
            this.txtFacilitieName.Size = new System.Drawing.Size(232, 37);
            this.txtFacilitieName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFacilitieName.TabIndex = 2;
            this.txtFacilitieName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFacilitieName.TextMarginBottom = 0;
            this.txtFacilitieName.TextMarginLeft = 3;
            this.txtFacilitieName.TextMarginTop = 0;
            this.txtFacilitieName.TextPlaceholder = "Facilitie Name";
            this.txtFacilitieName.UseSystemPasswordChar = false;
            this.txtFacilitieName.WordWrap = true;
            this.txtFacilitieName.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            this.txtFacilitieName.Validating += new System.ComponentModel.CancelEventHandler(this.bunifuTextBox1_Validating);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(22, 91);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(85, 21);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "Facilitie ID: ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblFacilitieID
            // 
            this.lblFacilitieID.AllowParentOverrides = false;
            this.lblFacilitieID.AutoEllipsis = false;
            this.lblFacilitieID.CursorType = null;
            this.lblFacilitieID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFacilitieID.Location = new System.Drawing.Point(121, 91);
            this.lblFacilitieID.Name = "lblFacilitieID";
            this.lblFacilitieID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFacilitieID.Size = new System.Drawing.Size(21, 21);
            this.lblFacilitieID.TabIndex = 4;
            this.lblFacilitieID.Text = "???";
            this.lblFacilitieID.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFacilitieID.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pcFacilitieIcon
            // 
            this.pcFacilitieIcon.AllowFocused = false;
            this.pcFacilitieIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcFacilitieIcon.AutoSizeHeight = true;
            this.pcFacilitieIcon.BorderRadius = 50;
            this.pcFacilitieIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcFacilitieIcon.Image")));
            this.pcFacilitieIcon.IsCircle = true;
            this.pcFacilitieIcon.Location = new System.Drawing.Point(337, 74);
            this.pcFacilitieIcon.Name = "pcFacilitieIcon";
            this.pcFacilitieIcon.Size = new System.Drawing.Size(100, 100);
            this.pcFacilitieIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcFacilitieIcon.TabIndex = 5;
            this.pcFacilitieIcon.TabStop = false;
            this.pcFacilitieIcon.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.Location = new System.Drawing.Point(337, 177);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(47, 13);
            this.llSetImage.TabIndex = 6;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Icon";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // llRemoveImg
            // 
            this.llRemoveImg.AutoSize = true;
            this.llRemoveImg.Location = new System.Drawing.Point(390, 177);
            this.llRemoveImg.Name = "llRemoveImg";
            this.llRemoveImg.Size = new System.Drawing.Size(42, 13);
            this.llRemoveImg.TabIndex = 7;
            this.llRemoveImg.TabStop = true;
            this.llRemoveImg.Text = "remove";
            this.llRemoveImg.Visible = false;
            this.llRemoveImg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImg_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoEllipsis = true;
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancel.Icon")));
            this.btnCancel.Location = new System.Drawing.Point(210, 247);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(112, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // formRadiuo
            // 
            this.formRadiuo.ElipseRadius = 20;
            this.formRadiuo.TargetControl = this;
            // 
            // btnSaveBorderRadiuo
            // 
            this.btnSaveBorderRadiuo.ElipseRadius = 12;
            this.btnSaveBorderRadiuo.TargetControl = this.btnCancel;
            // 
            // frmAddUpdateFacilitie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 292);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.llRemoveImg);
            this.Controls.Add(this.llSetImage);
            this.Controls.Add(this.pcFacilitieIcon);
            this.Controls.Add(this.lblFacilitieID);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.txtFacilitieName);
            this.Name = "frmAddUpdateFacilitie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Facilitie";
            this.Load += new System.EventHandler(this.frmAddUpdateFacilitie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcFacilitieIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextBox txtFacilitieName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel lblFacilitieID;
        private Bunifu.UI.WinForms.BunifuPictureBox pcFacilitieIcon;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel llRemoveImg;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private Bunifu.Framework.UI.BunifuElipse formRadiuo;
        private Bunifu.Framework.UI.BunifuElipse btnSaveBorderRadiuo;
    }
}