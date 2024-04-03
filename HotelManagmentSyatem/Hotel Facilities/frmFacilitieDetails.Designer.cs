namespace HotelManagmentSyatem.Hotel_Facilities
{
    partial class frmFacilitieDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacilitieDetails));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblFacilitieName = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblFacilitieID = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 39;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(140, 42);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(79, 79);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblFacilitieID);
            this.bunifuPanel1.Controls.Add(this.bunifuPictureBox1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(3, 64);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(362, 127);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.bunifuSeparator1);
            this.bunifuPanel2.Controls.Add(this.lblFacilitieName);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(3, 191);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(362, 67);
            this.bunifuPanel2.TabIndex = 2;
            // 
            // lblFacilitieName
            // 
            this.lblFacilitieName.AllowParentOverrides = false;
            this.lblFacilitieName.AutoEllipsis = false;
            this.lblFacilitieName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblFacilitieName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFacilitieName.Location = new System.Drawing.Point(132, 26);
            this.lblFacilitieName.Name = "lblFacilitieName";
            this.lblFacilitieName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFacilitieName.Size = new System.Drawing.Size(98, 21);
            this.lblFacilitieName.TabIndex = 0;
            this.lblFacilitieName.Text = "Facilitie Name";
            this.lblFacilitieName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFacilitieName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblFacilitieName.Click += new System.EventHandler(this.lblFacilitieName_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(31, 6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(300, 14);
            this.bunifuSeparator1.TabIndex = 1;
            // 
            // lblFacilitieID
            // 
            this.lblFacilitieID.AllowParentOverrides = false;
            this.lblFacilitieID.AutoEllipsis = false;
            this.lblFacilitieID.CursorType = null;
            this.lblFacilitieID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFacilitieID.Location = new System.Drawing.Point(67, 69);
            this.lblFacilitieID.Name = "lblFacilitieID";
            this.lblFacilitieID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFacilitieID.Size = new System.Drawing.Size(14, 21);
            this.lblFacilitieID.TabIndex = 1;
            this.lblFacilitieID.Text = "??";
            this.lblFacilitieID.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFacilitieID.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmFacilitieDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 267);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "frmFacilitieDetails";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facilitie Details";
            this.Load += new System.EventHandler(this.frmFacilitieDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel lblFacilitieName;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel lblFacilitieID;
    }
}