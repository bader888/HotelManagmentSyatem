namespace HotelManagmentSyatem.People.Controls
{
    partial class ctrlPersonCardWithFilter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPersonCardWithFilter));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.gbFilters = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnFind = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnAddNewPerson = new Bunifu.UI.WinForms.BunifuImageButton();
            this.txtFilterValue = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPersonCard1 = new HotelManagmentSyatem.People.Controls.ctrlPersonCard();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuPanel1.SuspendLayout();
            this.gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 2;
            this.bunifuElipse3.TargetControl = this;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Black;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.gbFilters);
            this.bunifuPanel1.Controls.Add(this.ctrlPersonCard1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(839, 440);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // gbFilters
            // 
            this.gbFilters.BackColor = System.Drawing.Color.White;
            this.gbFilters.BorderRadius = 5;
            this.gbFilters.BottomSahddow = true;
            this.gbFilters.color = System.Drawing.Color.Tomato;
            this.gbFilters.Controls.Add(this.bunifuLabel1);
            this.gbFilters.Controls.Add(this.bunifuSeparator1);
            this.gbFilters.Controls.Add(this.btnFind);
            this.gbFilters.Controls.Add(this.btnAddNewPerson);
            this.gbFilters.Controls.Add(this.txtFilterValue);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.LeftSahddow = false;
            this.gbFilters.Location = new System.Drawing.Point(3, 15);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.RightSahddow = true;
            this.gbFilters.ShadowDepth = 20;
            this.gbFilters.Size = new System.Drawing.Size(830, 111);
            this.gbFilters.TabIndex = 21;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(14, 8);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(39, 21);
            this.bunifuLabel1.TabIndex = 30;
            this.bunifuLabel1.Text = "Filter";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.RightEdgeFaded;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(9, 30);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(812, 14);
            this.bunifuSeparator1.TabIndex = 31;
            // 
            // btnFind
            // 
            this.btnFind.ActiveImage = null;
            this.btnFind.AllowAnimations = true;
            this.btnFind.AllowBuffering = false;
            this.btnFind.AllowToggling = false;
            this.btnFind.AllowZooming = true;
            this.btnFind.AllowZoomingOnFocus = false;
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFind.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnFind.ErrorImage")));
            this.btnFind.FadeWhenInactive = false;
            this.btnFind.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnFind.Image = global::HotelManagmentSyatem.Properties.Resources.SearchPerson;
            this.btnFind.ImageActive = null;
            this.btnFind.ImageLocation = null;
            this.btnFind.ImageMargin = 40;
            this.btnFind.ImageSize = new System.Drawing.Size(26, 23);
            this.btnFind.ImageZoomSize = new System.Drawing.Size(66, 63);
            this.btnFind.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnFind.InitialImage")));
            this.btnFind.Location = new System.Drawing.Point(516, 45);
            this.btnFind.Name = "btnFind";
            this.btnFind.Rotation = 0;
            this.btnFind.ShowActiveImage = true;
            this.btnFind.ShowCursorChanges = true;
            this.btnFind.ShowImageBorders = true;
            this.btnFind.ShowSizeMarkers = false;
            this.btnFind.Size = new System.Drawing.Size(66, 63);
            this.btnFind.TabIndex = 29;
            this.btnFind.ToolTipText = "";
            this.btnFind.WaitOnLoad = false;
            this.btnFind.Zoom = 40;
            this.btnFind.ZoomSpeed = 10;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
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
            this.btnAddNewPerson.Location = new System.Drawing.Point(588, 45);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Rotation = 0;
            this.btnAddNewPerson.ShowActiveImage = true;
            this.btnAddNewPerson.ShowCursorChanges = true;
            this.btnAddNewPerson.ShowImageBorders = true;
            this.btnAddNewPerson.ShowSizeMarkers = false;
            this.btnAddNewPerson.Size = new System.Drawing.Size(66, 63);
            this.btnAddNewPerson.TabIndex = 28;
            this.btnAddNewPerson.ToolTipText = "";
            this.btnAddNewPerson.WaitOnLoad = false;
            this.btnAddNewPerson.Zoom = 40;
            this.btnAddNewPerson.ZoomSpeed = 10;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
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
            this.txtFilterValue.Location = new System.Drawing.Point(279, 56);
            this.txtFilterValue.MaxLength = 32767;
            this.txtFilterValue.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFilterValue.Modified = false;
            this.txtFilterValue.Multiline = false;
            this.txtFilterValue.Name = "txtFilterValue";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFilterValue.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFilterValue.OnIdleState = stateProperties4;
            this.txtFilterValue.Padding = new System.Windows.Forms.Padding(3);
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFilterValue.PlaceholderText = "Enter text";
            this.txtFilterValue.ReadOnly = false;
            this.txtFilterValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.SelectionLength = 0;
            this.txtFilterValue.SelectionStart = 0;
            this.txtFilterValue.ShortcutsEnabled = true;
            this.txtFilterValue.Size = new System.Drawing.Size(231, 37);
            this.txtFilterValue.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFilterValue.TabIndex = 27;
            this.txtFilterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFilterValue.TextMarginBottom = 0;
            this.txtFilterValue.TextMarginLeft = 3;
            this.txtFilterValue.TextMarginTop = 0;
            this.txtFilterValue.TextPlaceholder = "Enter text";
            this.txtFilterValue.UseSystemPasswordChar = false;
            this.txtFilterValue.WordWrap = true;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
           
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Find By:";
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(5, 132);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(830, 298);
            this.ctrlPersonCard1.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(839, 440);
            this.Load += new System.EventHandler(this.ctrlPersonCardWithFilter_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.Framework.UI.BunifuCards gbFilters;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuImageButton btnFind;
        private Bunifu.UI.WinForms.BunifuImageButton btnAddNewPerson;
        private Bunifu.UI.WinForms.BunifuTextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
