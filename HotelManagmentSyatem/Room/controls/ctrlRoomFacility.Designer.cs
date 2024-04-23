namespace HotelManagmentSyatem.Room.controls
{
    partial class ctrlRoomFacility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlRoomFacility));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lblFacilityName = new Bunifu.UI.WinForms.BunifuLabel();
            this.picFacilityImg = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnClosr = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFacilityImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosr)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.btnClosr);
            this.bunifuCards1.Controls.Add(this.picFacilityImg);
            this.bunifuCards1.Controls.Add(this.lblFacilityName);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(143, 118);
            this.bunifuCards1.TabIndex = 2;
            // 
            // lblFacilityName
            // 
            this.lblFacilityName.AllowParentOverrides = false;
            this.lblFacilityName.AutoEllipsis = false;
            this.lblFacilityName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblFacilityName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFacilityName.Location = new System.Drawing.Point(28, 87);
            this.lblFacilityName.Name = "lblFacilityName";
            this.lblFacilityName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFacilityName.Size = new System.Drawing.Size(90, 17);
            this.lblFacilityName.TabIndex = 3;
            this.lblFacilityName.Text = "???????????????";
            this.lblFacilityName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFacilityName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // picFacilityImg
            // 
            this.picFacilityImg.AllowFocused = false;
            this.picFacilityImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picFacilityImg.AutoSizeHeight = true;
            this.picFacilityImg.BorderRadius = 31;
            this.picFacilityImg.Image = ((System.Drawing.Image)(resources.GetObject("picFacilityImg.Image")));
            this.picFacilityImg.IsCircle = true;
            this.picFacilityImg.Location = new System.Drawing.Point(37, 19);
            this.picFacilityImg.Name = "picFacilityImg";
            this.picFacilityImg.Size = new System.Drawing.Size(62, 62);
            this.picFacilityImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFacilityImg.TabIndex = 4;
            this.picFacilityImg.TabStop = false;
            this.picFacilityImg.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnClosr
            // 
            this.btnClosr.AllowFocused = false;
            this.btnClosr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClosr.AutoSizeHeight = true;
            this.btnClosr.BorderRadius = 11;
            this.btnClosr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosr.Image = global::HotelManagmentSyatem.Properties.Resources.closeBlack32;
            this.btnClosr.IsCircle = true;
            this.btnClosr.Location = new System.Drawing.Point(117, 3);
            this.btnClosr.Name = "btnClosr";
            this.btnClosr.Size = new System.Drawing.Size(23, 23);
            this.btnClosr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClosr.TabIndex = 5;
            this.btnClosr.TabStop = false;
            this.btnClosr.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.btnClosr.Click += new System.EventHandler(this.btnClosr_Click);
            // 
            // ctrlRoomFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuCards1);
            this.Name = "ctrlRoomFacility";
            this.Size = new System.Drawing.Size(143, 118);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFacilityImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuLabel lblFacilityName;
        private Bunifu.UI.WinForms.BunifuPictureBox picFacilityImg;
        private Bunifu.UI.WinForms.BunifuPictureBox btnClosr;
    }
}
