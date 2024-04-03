namespace HotelManagmentSyatem.People
{
    partial class frmPersonDetails
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
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonDetails));
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblHeader = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnMin = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnCloseForm = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.ctrlPersonCard1 = new HotelManagmentSyatem.People.Controls.ctrlPersonCard();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblHeader
            // 
            this.lblHeader.AllowParentOverrides = false;
            this.lblHeader.AutoEllipsis = false;
            this.lblHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHeader.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.lblHeader, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(324, 48);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHeader.Size = new System.Drawing.Size(184, 37);
            this.lblHeader.TabIndex = 10;
            this.lblHeader.Text = "Person Details";
            this.lblHeader.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblHeader.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Gray;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Controls.Add(this.btnMin);
            this.bunifuPanel1.Controls.Add(this.bunifuSeparator1);
            this.bunifuPanel1.Controls.Add(this.btnCloseForm);
            this.bunifuPanel1.Controls.Add(this.ctrlPersonCard1);
            this.bunifuTransition1.SetDecoration(this.bunifuPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(874, 421);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.bunifuLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(342, 50);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(184, 37);
            this.bunifuLabel1.TabIndex = 23;
            this.bunifuLabel1.Text = "Person Details";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnMin
            // 
            this.btnMin.AllowFocused = false;
            this.btnMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMin.AutoSizeHeight = true;
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BorderRadius = 14;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.IsCircle = true;
            this.btnMin.Location = new System.Drawing.Point(787, 16);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(28, 28);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 22;
            this.btnMin.TabStop = false;
            this.btnMin.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(142, 66);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(584, 14);
            this.bunifuSeparator1.TabIndex = 20;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.AllowFocused = false;
            this.btnCloseForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCloseForm.AutoSizeHeight = true;
            this.btnCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.BorderRadius = 14;
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnCloseForm, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.Image")));
            this.btnCloseForm.IsCircle = true;
            this.btnCloseForm.Location = new System.Drawing.Point(821, 16);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(28, 28);
            this.btnCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseForm.TabIndex = 21;
            this.btnCloseForm.TabStop = false;
            this.btnCloseForm.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click_1);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.ctrlPersonCard1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.ctrlPersonCard1.Location = new System.Drawing.Point(25, 106);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(824, 298);
            this.ctrlPersonCard1.TabIndex = 19;
            this.ctrlPersonCard1.Visible = false;
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 421);
            this.Controls.Add(this.bunifuPanel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonDetails";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel lblHeader;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPictureBox btnMin;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuPictureBox btnCloseForm;
        private Controls.ctrlPersonCard ctrlPersonCard1;
    }
}