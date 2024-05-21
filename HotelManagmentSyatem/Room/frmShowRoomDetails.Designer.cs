namespace HotelManagmentSyatem.Room
{
    partial class frmShowRoomDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowRoomDetails));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.btnMin = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnCloseForm = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.ctrlRoomCard2 = new HotelManagmentSyatem.Room.controls.ctrlRoomCard();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            // btnMin
            // 
            this.btnMin.AllowFocused = false;
            this.btnMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMin.AutoSizeHeight = true;
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BorderRadius = 15;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.IsCircle = true;
            this.btnMin.Location = new System.Drawing.Point(972, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 189;
            this.btnMin.TabStop = false;
            this.btnMin.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.AllowFocused = false;
            this.btnCloseForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCloseForm.AutoSizeHeight = true;
            this.btnCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.BorderRadius = 15;
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnCloseForm, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.Image")));
            this.btnCloseForm.IsCircle = true;
            this.btnCloseForm.Location = new System.Drawing.Point(1006, 12);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(30, 30);
            this.btnCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCloseForm.TabIndex = 188;
            this.btnCloseForm.TabStop = false;
            this.btnCloseForm.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // ctrlRoomCard2
            // 
            this.bunifuTransition1.SetDecoration(this.ctrlRoomCard2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.ctrlRoomCard2.Location = new System.Drawing.Point(25, 48);
            this.ctrlRoomCard2.Name = "ctrlRoomCard2";
            this.ctrlRoomCard2.Size = new System.Drawing.Size(989, 586);
            this.ctrlRoomCard2.TabIndex = 190;
            // 
            // frmShowRoomDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 693);
            this.Controls.Add(this.ctrlRoomCard2);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnMin);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowRoomDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Room Details";
            this.Load += new System.EventHandler(this.frmShowRoomDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private controls.ctrlRoomCard ctrlRoomCard1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private Bunifu.UI.WinForms.BunifuPictureBox btnCloseForm;
        private Bunifu.UI.WinForms.BunifuPictureBox btnMin;
        private controls.ctrlRoomCard ctrlRoomCard2;
    }
}