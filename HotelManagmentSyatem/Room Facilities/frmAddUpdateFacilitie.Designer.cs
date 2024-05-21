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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.lblFacilitieID = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.llRemoveImg = new System.Windows.Forms.LinkLabel();
            this.pcFacilitieIcon = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.txtFacilitieName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            btnCancelBorderRadio = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFacilitieIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelBorderRadio
            // 
            btnCancelBorderRadio.ElipseRadius = 10;
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.Location = new System.Drawing.Point(337, 145);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(47, 13);
            this.llSetImage.TabIndex = 14;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Icon";
            // 
            // lblFacilitieID
            // 
            this.lblFacilitieID.AllowParentOverrides = false;
            this.lblFacilitieID.AutoEllipsis = false;
            this.lblFacilitieID.CursorType = null;
            this.lblFacilitieID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFacilitieID.Location = new System.Drawing.Point(118, 74);
            this.lblFacilitieID.Name = "lblFacilitieID";
            this.lblFacilitieID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFacilitieID.Size = new System.Drawing.Size(21, 21);
            this.lblFacilitieID.TabIndex = 12;
            this.lblFacilitieID.Text = "???";
            this.lblFacilitieID.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFacilitieID.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(19, 74);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(85, 21);
            this.bunifuLabel1.TabIndex = 11;
            this.bunifuLabel1.Text = "Facilitie ID: ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.llRemoveImg.Location = new System.Drawing.Point(390, 145);
            this.llRemoveImg.Name = "llRemoveImg";
            this.llRemoveImg.Size = new System.Drawing.Size(42, 13);
            this.llRemoveImg.TabIndex = 15;
            this.llRemoveImg.TabStop = true;
            this.llRemoveImg.Text = "remove";
            this.llRemoveImg.Visible = false;
            // 
            // pcFacilitieIcon
            // 
            this.pcFacilitieIcon.AllowFocused = false;
            this.pcFacilitieIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcFacilitieIcon.AutoSizeHeight = true;
            this.pcFacilitieIcon.BorderRadius = 50;
            this.pcFacilitieIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcFacilitieIcon.Image")));
            this.pcFacilitieIcon.IsCircle = true;
            this.pcFacilitieIcon.Location = new System.Drawing.Point(332, 42);
            this.pcFacilitieIcon.Name = "pcFacilitieIcon";
            this.pcFacilitieIcon.Size = new System.Drawing.Size(100, 100);
            this.pcFacilitieIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcFacilitieIcon.TabIndex = 13;
            this.pcFacilitieIcon.TabStop = false;
            this.pcFacilitieIcon.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
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
            this.txtFacilitieName.Location = new System.Drawing.Point(12, 111);
            this.txtFacilitieName.MaxLength = 32767;
            this.txtFacilitieName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFacilitieName.Modified = false;
            this.txtFacilitieName.Multiline = false;
            this.txtFacilitieName.Name = "txtFacilitieName";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFacilitieName.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFacilitieName.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFacilitieName.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFacilitieName.OnIdleState = stateProperties16;
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
            this.txtFacilitieName.Size = new System.Drawing.Size(280, 47);
            this.txtFacilitieName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFacilitieName.TabIndex = 10;
            this.txtFacilitieName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFacilitieName.TextMarginBottom = 0;
            this.txtFacilitieName.TextMarginLeft = 3;
            this.txtFacilitieName.TextMarginTop = 0;
            this.txtFacilitieName.TextPlaceholder = "Facilitie Name";
            this.txtFacilitieName.UseSystemPasswordChar = false;
            this.txtFacilitieName.WordWrap = true;
            this.txtFacilitieName.Validating += new System.ComponentModel.CancelEventHandler(this.bunifuTextBox1_Validating);
            // 
            // btnClose
            // 
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowMouseEffects = true;
            this.btnClose.AllowToggling = false;
            this.btnClose.AnimationSpeed = 200;
            this.btnClose.AutoGenerateColors = false;
            this.btnClose.AutoRoundBorders = false;
            this.btnClose.AutoSizeLeftIcon = true;
            this.btnClose.AutoSizeRightIcon = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor1 = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.ButtonText = "Close";
            this.btnClose.ButtonTextMarginLeft = 0;
            this.btnClose.ColorContrastOnClick = 45;
            this.btnClose.ColorContrastOnHover = 45;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnClose.CustomizableEdges = borderEdges7;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClose.IconMarginLeft = 11;
            this.btnClose.IconPadding = 10;
            this.btnClose.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClose.IconSize = 25;
            this.btnClose.IdleBorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnClose.IdleBorderRadius = 15;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnClose.IdleIconLeftImage = null;
            this.btnClose.IdleIconRightImage = global::HotelManagmentSyatem.Properties.Resources.Close_32;
            this.btnClose.IndicateFocus = false;
            this.btnClose.Location = new System.Drawing.Point(151, 240);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.OnDisabledState.BorderRadius = 15;
            this.btnClose.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnDisabledState.BorderThickness = 1;
            this.btnClose.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.OnDisabledState.IconLeftImage = null;
            this.btnClose.OnDisabledState.IconRightImage = null;
            this.btnClose.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnClose.onHoverState.BorderRadius = 15;
            this.btnClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.onHoverState.BorderThickness = 1;
            this.btnClose.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnClose.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.onHoverState.IconLeftImage = null;
            this.btnClose.onHoverState.IconRightImage = null;
            this.btnClose.OnIdleState.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnClose.OnIdleState.BorderRadius = 15;
            this.btnClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnIdleState.BorderThickness = 1;
            this.btnClose.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnClose.OnIdleState.IconLeftImage = null;
            this.btnClose.OnIdleState.IconRightImage = global::HotelManagmentSyatem.Properties.Resources.Close_32;
            this.btnClose.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.OnPressedState.BorderRadius = 15;
            this.btnClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnPressedState.BorderThickness = 1;
            this.btnClose.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnPressedState.IconLeftImage = null;
            this.btnClose.OnPressedState.IconRightImage = null;
            this.btnClose.Size = new System.Drawing.Size(138, 40);
            this.btnClose.TabIndex = 171;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.TextMarginLeft = 0;
            this.btnClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClose.UseDefaultRadiusAndThickness = true;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AllowAnimations = true;
            this.btnSave.AllowMouseEffects = true;
            this.btnSave.AllowToggling = false;
            this.btnSave.AnimationSpeed = 200;
            this.btnSave.AutoGenerateColors = false;
            this.btnSave.AutoRoundBorders = false;
            this.btnSave.AutoSizeLeftIcon = true;
            this.btnSave.AutoSizeRightIcon = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackColor1 = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.ButtonText = "Save";
            this.btnSave.ButtonTextMarginLeft = 0;
            this.btnSave.ColorContrastOnClick = 45;
            this.btnSave.ColorContrastOnHover = 45;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btnSave.CustomizableEdges = borderEdges8;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSave.IconMarginLeft = 11;
            this.btnSave.IconPadding = 10;
            this.btnSave.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSave.IconSize = 25;
            this.btnSave.IdleBorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.IdleBorderRadius = 15;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSave.IdleIconLeftImage = null;
            this.btnSave.IdleIconRightImage = global::HotelManagmentSyatem.Properties.Resources.Save_32;
            this.btnSave.IndicateFocus = false;
            this.btnSave.Location = new System.Drawing.Point(310, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.OnDisabledState.BorderRadius = 15;
            this.btnSave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnDisabledState.BorderThickness = 1;
            this.btnSave.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.OnDisabledState.IconLeftImage = null;
            this.btnSave.OnDisabledState.IconRightImage = null;
            this.btnSave.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSave.onHoverState.BorderRadius = 15;
            this.btnSave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.onHoverState.BorderThickness = 1;
            this.btnSave.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSave.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.onHoverState.IconLeftImage = null;
            this.btnSave.onHoverState.IconRightImage = null;
            this.btnSave.OnIdleState.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.OnIdleState.BorderRadius = 15;
            this.btnSave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnIdleState.BorderThickness = 1;
            this.btnSave.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnSave.OnIdleState.IconLeftImage = null;
            this.btnSave.OnIdleState.IconRightImage = global::HotelManagmentSyatem.Properties.Resources.Save_32;
            this.btnSave.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSave.OnPressedState.BorderRadius = 15;
            this.btnSave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnPressedState.BorderThickness = 1;
            this.btnSave.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSave.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnPressedState.IconLeftImage = null;
            this.btnSave.OnPressedState.IconRightImage = null;
            this.btnSave.Size = new System.Drawing.Size(138, 40);
            this.btnSave.TabIndex = 170;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.TextMarginLeft = 0;
            this.btnSave.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmAddUpdateFacilitie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 292);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.llSetImage);
            this.Controls.Add(this.lblFacilitieID);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.llRemoveImg);
            this.Controls.Add(this.pcFacilitieIcon);
            this.Controls.Add(this.txtFacilitieName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddUpdateFacilitie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Facilitie";
            this.Load += new System.EventHandler(this.frmAddUpdateFacilitie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFacilitieIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel llSetImage;
        private Bunifu.UI.WinForms.BunifuLabel lblFacilitieID;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel llRemoveImg;
        private Bunifu.UI.WinForms.BunifuPictureBox pcFacilitieIcon;
        private Bunifu.UI.WinForms.BunifuTextBox txtFacilitieName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}