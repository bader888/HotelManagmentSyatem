namespace HotelManagmentSyatem.Reservation.Messages
{
    partial class ctrlMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlMessage));
            this.bunifuPanel9 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblMsgDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox3 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblMsgTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel9
            // 
            this.bunifuPanel9.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel9.BackgroundImage")));
            this.bunifuPanel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel9.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel9.BorderRadius = 3;
            this.bunifuPanel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuPanel9.BorderThickness = 1;
            this.bunifuPanel9.Controls.Add(this.lblMsgDate);
            this.bunifuPanel9.Controls.Add(this.bunifuPictureBox3);
            this.bunifuPanel9.Controls.Add(this.lblMsgTitle);
            this.bunifuPanel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuPanel9.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel9.Name = "bunifuPanel9";
            this.bunifuPanel9.ShowBorders = true;
            this.bunifuPanel9.Size = new System.Drawing.Size(174, 46);
            this.bunifuPanel9.TabIndex = 4;
            this.bunifuPanel9.Click += new System.EventHandler(this.bunifuPanel9_Click);
            // 
            // lblMsgDate
            // 
            this.lblMsgDate.AllowParentOverrides = false;
            this.lblMsgDate.AutoEllipsis = false;
            this.lblMsgDate.CursorType = null;
            this.lblMsgDate.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblMsgDate.ForeColor = System.Drawing.Color.Gray;
            this.lblMsgDate.Location = new System.Drawing.Point(39, 21);
            this.lblMsgDate.Name = "lblMsgDate";
            this.lblMsgDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMsgDate.Size = new System.Drawing.Size(35, 13);
            this.lblMsgDate.TabIndex = 2;
            this.lblMsgDate.Text = "mar-25";
            this.lblMsgDate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblMsgDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox3
            // 
            this.bunifuPictureBox3.AllowFocused = false;
            this.bunifuPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox3.AutoSizeHeight = true;
            this.bunifuPictureBox3.BorderRadius = 15;
            this.bunifuPictureBox3.Image = global::HotelManagmentSyatem.Properties.Resources.send_email_32;
            this.bunifuPictureBox3.IsCircle = true;
            this.bunifuPictureBox3.Location = new System.Drawing.Point(3, 5);
            this.bunifuPictureBox3.Name = "bunifuPictureBox3";
            this.bunifuPictureBox3.Size = new System.Drawing.Size(30, 30);
            this.bunifuPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox3.TabIndex = 0;
            this.bunifuPictureBox3.TabStop = false;
            this.bunifuPictureBox3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblMsgTitle
            // 
            this.lblMsgTitle.AllowParentOverrides = false;
            this.lblMsgTitle.AutoEllipsis = false;
            this.lblMsgTitle.CursorType = null;
            this.lblMsgTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblMsgTitle.Location = new System.Drawing.Point(35, 5);
            this.lblMsgTitle.Name = "lblMsgTitle";
            this.lblMsgTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMsgTitle.Size = new System.Drawing.Size(72, 15);
            this.lblMsgTitle.TabIndex = 1;
            this.lblMsgTitle.Text = "Message Title";
            this.lblMsgTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblMsgTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ctrlMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuPanel9);
            this.Name = "ctrlMessage";
            this.Size = new System.Drawing.Size(174, 46);
            this.bunifuPanel9.ResumeLayout(false);
            this.bunifuPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel9;
        private Bunifu.UI.WinForms.BunifuLabel lblMsgDate;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox3;
        private Bunifu.UI.WinForms.BunifuLabel lblMsgTitle;
    }
}
