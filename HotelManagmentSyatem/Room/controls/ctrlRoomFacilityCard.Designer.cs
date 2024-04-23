namespace HotelManagmentSyatem.Room.controls
{
    partial class ctrlRoomFacilityCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlRoomFacilityCard));
            this.lblFacilitiyName = new Bunifu.UI.WinForms.BunifuLabel();
            this.picFacilityImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFacilityImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFacilitiyName
            // 
            this.lblFacilitiyName.AllowParentOverrides = false;
            this.lblFacilitiyName.AutoEllipsis = false;
            this.lblFacilitiyName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFacilitiyName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblFacilitiyName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFacilitiyName.Location = new System.Drawing.Point(37, 8);
            this.lblFacilitiyName.Name = "lblFacilitiyName";
            this.lblFacilitiyName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFacilitiyName.Size = new System.Drawing.Size(81, 17);
            this.lblFacilitiyName.TabIndex = 0;
            this.lblFacilitiyName.Text = "bunifuLabel1";
            this.lblFacilitiyName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFacilitiyName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // picFacilityImg
            // 
            this.picFacilityImg.Image = global::HotelManagmentSyatem.Properties.Resources.Question_32;
            this.picFacilityImg.Location = new System.Drawing.Point(3, 4);
            this.picFacilityImg.Name = "picFacilityImg";
            this.picFacilityImg.Size = new System.Drawing.Size(28, 25);
            this.picFacilityImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFacilityImg.TabIndex = 1;
            this.picFacilityImg.TabStop = false;
            // 
            // ctrlRoomFacilityCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picFacilityImg);
            this.Controls.Add(this.lblFacilitiyName);
            this.Name = "ctrlRoomFacilityCard";
            this.Size = new System.Drawing.Size(158, 32);
            ((System.ComponentModel.ISupportInitialize)(this.picFacilityImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblFacilitiyName;
        private System.Windows.Forms.PictureBox picFacilityImg;
    }
}
