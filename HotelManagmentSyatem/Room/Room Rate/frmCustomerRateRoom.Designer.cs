namespace HotelManagmentSyatem.Room.Room_Rate
{
    partial class frmCustomerRateRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerRateRoom));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblCustomerName = new Bunifu.UI.WinForms.BunifuLabel();
            this.Rating = new Bunifu.UI.WinForms.BunifuRating();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtDescription = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblLettersCount = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnSend = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pbCustomer = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.llRoomDeatils = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.lblRoomNumber = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AllowParentOverrides = false;
            this.lblCustomerName.AutoEllipsis = false;
            this.lblCustomerName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCustomerName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCustomerName.Location = new System.Drawing.Point(100, 42);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCustomerName.Size = new System.Drawing.Size(149, 21);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Bader Haider husen";
            this.lblCustomerName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCustomerName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Rating
            // 
            this.Rating.BackColor = System.Drawing.Color.Transparent;
            this.Rating.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Rating.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.Rating.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Rating.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Rating.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.Rating.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.Rating.InnerRadius = 2F;
            this.Rating.Location = new System.Drawing.Point(319, 66);
            this.Rating.Name = "Rating";
            this.Rating.OuterRadius = 10F;
            this.Rating.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.Rating.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.Rating.ReadOnly = false;
            this.Rating.RightClickToClear = true;
            this.Rating.Size = new System.Drawing.Size(106, 22);
            this.Rating.Spacing = 1;
            this.Rating.TabIndex = 2;
            this.Rating.Text = "bunifuRating1";
            this.Rating.Value = 2;
            this.Rating.ValueChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs>(this.Rating_ValueChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuLabel1.Location = new System.Drawing.Point(42, 117);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(172, 20);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "Descripte your experience";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = false;
            this.txtDescription.AcceptsTab = false;
            this.txtDescription.AnimationSpeed = 200;
            this.txtDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDescription.BackgroundImage")));
            this.txtDescription.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtDescription.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDescription.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtDescription.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtDescription.BorderRadius = 5;
            this.txtDescription.BorderThickness = 1;
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.DefaultText = "";
            this.txtDescription.FillColor = System.Drawing.Color.White;
            this.txtDescription.HideSelection = true;
            this.txtDescription.IconLeft = null;
            this.txtDescription.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.IconPadding = 10;
            this.txtDescription.IconRight = null;
            this.txtDescription.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(42, 143);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDescription.Modified = false;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescription.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDescription.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescription.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescription.OnIdleState = stateProperties4;
            this.txtDescription.Padding = new System.Windows.Forms.Padding(3);
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDescription.PlaceholderText = "Enter text";
            this.txtDescription.ReadOnly = false;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(383, 189);
            this.txtDescription.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtDescription.TabIndex = 4;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.TextMarginBottom = 0;
            this.txtDescription.TextMarginLeft = 3;
            this.txtDescription.TextMarginTop = 0;
            this.txtDescription.TextPlaceholder = "Enter text";
            this.txtDescription.UseSystemPasswordChar = false;
            this.txtDescription.WordWrap = true;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // lblDate
            // 
            this.lblDate.AllowParentOverrides = false;
            this.lblDate.AutoEllipsis = false;
            this.lblDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDate.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDate.Location = new System.Drawing.Point(371, 122);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(52, 15);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "2024/5/17";
            this.lblDate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblLettersCount
            // 
            this.lblLettersCount.AllowParentOverrides = false;
            this.lblLettersCount.AutoEllipsis = false;
            this.lblLettersCount.CursorType = null;
            this.lblLettersCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLettersCount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLettersCount.Location = new System.Drawing.Point(382, 338);
            this.lblLettersCount.Name = "lblLettersCount";
            this.lblLettersCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLettersCount.Size = new System.Drawing.Size(41, 15);
            this.lblLettersCount.TabIndex = 6;
            this.lblLettersCount.Text = "255/255";
            this.lblLettersCount.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblLettersCount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnSend
            // 
            this.btnSend.AllowAnimations = true;
            this.btnSend.AllowMouseEffects = true;
            this.btnSend.AllowToggling = false;
            this.btnSend.AnimationSpeed = 200;
            this.btnSend.AutoGenerateColors = false;
            this.btnSend.AutoRoundBorders = false;
            this.btnSend.AutoSizeLeftIcon = true;
            this.btnSend.AutoSizeRightIcon = true;
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSend.ButtonText = "send";
            this.btnSend.ButtonTextMarginLeft = 0;
            this.btnSend.ColorContrastOnClick = 45;
            this.btnSend.ColorContrastOnHover = 45;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSend.CustomizableEdges = borderEdges1;
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSend.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSend.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSend.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSend.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSend.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSend.IconMarginLeft = 11;
            this.btnSend.IconPadding = 10;
            this.btnSend.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSend.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSend.IconSize = 25;
            this.btnSend.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSend.IdleBorderRadius = 5;
            this.btnSend.IdleBorderThickness = 1;
            this.btnSend.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSend.IdleIconLeftImage = global::HotelManagmentSyatem.Properties.Resources.ActiveUser;
            this.btnSend.IdleIconRightImage = null;
            this.btnSend.IndicateFocus = false;
            this.btnSend.Location = new System.Drawing.Point(236, 338);
            this.btnSend.Name = "btnSend";
            this.btnSend.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSend.OnDisabledState.BorderRadius = 5;
            this.btnSend.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSend.OnDisabledState.BorderThickness = 1;
            this.btnSend.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSend.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSend.OnDisabledState.IconLeftImage = null;
            this.btnSend.OnDisabledState.IconRightImage = null;
            this.btnSend.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSend.onHoverState.BorderRadius = 5;
            this.btnSend.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSend.onHoverState.BorderThickness = 1;
            this.btnSend.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSend.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSend.onHoverState.IconLeftImage = null;
            this.btnSend.onHoverState.IconRightImage = null;
            this.btnSend.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSend.OnIdleState.BorderRadius = 5;
            this.btnSend.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSend.OnIdleState.BorderThickness = 1;
            this.btnSend.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSend.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSend.OnIdleState.IconLeftImage = global::HotelManagmentSyatem.Properties.Resources.ActiveUser;
            this.btnSend.OnIdleState.IconRightImage = null;
            this.btnSend.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSend.OnPressedState.BorderRadius = 5;
            this.btnSend.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSend.OnPressedState.BorderThickness = 1;
            this.btnSend.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSend.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSend.OnPressedState.IconLeftImage = null;
            this.btnSend.OnPressedState.IconRightImage = null;
            this.btnSend.Size = new System.Drawing.Size(128, 39);
            this.btnSend.TabIndex = 7;
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSend.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSend.TextMarginLeft = 0;
            this.btnSend.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSend.UseDefaultRadiusAndThickness = true;
            this.btnSend.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.ButtonText = "cancel";
            this.btnClose.ButtonTextMarginLeft = 0;
            this.btnClose.ColorContrastOnClick = 45;
            this.btnClose.ColorContrastOnHover = 45;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnClose.CustomizableEdges = borderEdges2;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClose.IconMarginLeft = 11;
            this.btnClose.IconPadding = 10;
            this.btnClose.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClose.IconSize = 25;
            this.btnClose.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.IdleBorderRadius = 5;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.IdleIconLeftImage = global::HotelManagmentSyatem.Properties.Resources.Close_64;
            this.btnClose.IdleIconRightImage = null;
            this.btnClose.IndicateFocus = false;
            this.btnClose.Location = new System.Drawing.Point(102, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.OnDisabledState.BorderRadius = 5;
            this.btnClose.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnDisabledState.BorderThickness = 1;
            this.btnClose.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.OnDisabledState.IconLeftImage = null;
            this.btnClose.OnDisabledState.IconRightImage = null;
            this.btnClose.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnClose.onHoverState.BorderRadius = 5;
            this.btnClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.onHoverState.BorderThickness = 1;
            this.btnClose.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnClose.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.onHoverState.IconLeftImage = null;
            this.btnClose.onHoverState.IconRightImage = null;
            this.btnClose.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.OnIdleState.BorderRadius = 5;
            this.btnClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnIdleState.BorderThickness = 1;
            this.btnClose.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnIdleState.IconLeftImage = global::HotelManagmentSyatem.Properties.Resources.Close_64;
            this.btnClose.OnIdleState.IconRightImage = null;
            this.btnClose.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.OnPressedState.BorderRadius = 5;
            this.btnClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnPressedState.BorderThickness = 1;
            this.btnClose.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnPressedState.IconLeftImage = null;
            this.btnClose.OnPressedState.IconRightImage = null;
            this.btnClose.Size = new System.Drawing.Size(128, 39);
            this.btnClose.TabIndex = 8;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.TextMarginLeft = 0;
            this.btnClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClose.UseDefaultRadiusAndThickness = true;
            this.btnClose.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // pbCustomer
            // 
            this.pbCustomer.AllowFocused = false;
            this.pbCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCustomer.AutoSizeHeight = true;
            this.pbCustomer.BorderRadius = 37;
            this.pbCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbCustomer.Image")));
            this.pbCustomer.IsCircle = true;
            this.pbCustomer.Location = new System.Drawing.Point(20, 16);
            this.pbCustomer.Name = "pbCustomer";
            this.pbCustomer.Size = new System.Drawing.Size(74, 74);
            this.pbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCustomer.TabIndex = 9;
            this.pbCustomer.TabStop = false;
            this.pbCustomer.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel4.Location = new System.Drawing.Point(319, 45);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(75, 15);
            this.bunifuLabel4.TabIndex = 10;
            this.bunifuLabel4.Text = "Rate the room ";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // llRoomDeatils
            // 
            this.llRoomDeatils.AutoSize = true;
            this.llRoomDeatils.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.llRoomDeatils.Location = new System.Drawing.Point(100, 66);
            this.llRoomDeatils.Name = "llRoomDeatils";
            this.llRoomDeatils.Size = new System.Drawing.Size(83, 13);
            this.llRoomDeatils.TabIndex = 11;
            this.llRoomDeatils.TabStop = true;
            this.llRoomDeatils.Text = "see room details";
            this.llRoomDeatils.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRoomDeatils_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = false;
            this.bunifuSnackbar1.ShowCloseIcon = false;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AllowParentOverrides = false;
            this.lblRoomNumber.AutoEllipsis = false;
            this.lblRoomNumber.CursorType = null;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRoomNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRoomNumber.Location = new System.Drawing.Point(400, 45);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRoomNumber.Size = new System.Drawing.Size(30, 15);
            this.lblRoomNumber.TabIndex = 12;
            this.lblRoomNumber.Text = "10000";
            this.lblRoomNumber.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblRoomNumber.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmCustomerRateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 393);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.llRoomDeatils);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.pbCustomer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblLettersCount);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "frmCustomerRateRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rate Room";
            this.Load += new System.EventHandler(this.FrmCustomerRateRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel lblCustomerName;
        private Bunifu.UI.WinForms.BunifuRating Rating;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtDescription;
        private Bunifu.UI.WinForms.BunifuLabel lblDate;
        private Bunifu.UI.WinForms.BunifuLabel lblLettersCount;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSend;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
        private Bunifu.UI.WinForms.BunifuPictureBox pbCustomer;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private System.Windows.Forms.LinkLabel llRoomDeatils;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.UI.WinForms.BunifuLabel lblRoomNumber;
    }
}