namespace HotelManagmentSyatem.Reservation.Controls
{
    partial class ctrlCustomerBookingRoomCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlCustomerBookingRoomCard));
            this.rateRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingAgainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llRoomDetails = new System.Windows.Forms.LinkLabel();
            this.lblReservationDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblRoomType = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblReservationCost = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblReservationStatus = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblCheckInCheckOut = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblRoomNumber = new Bunifu.UI.WinForms.BunifuLabel();
            this.picRoom = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rateRoomToolStripMenuItem
            // 
            this.rateRoomToolStripMenuItem.Image = global::HotelManagmentSyatem.Properties.Resources.RateRoom;
            this.rateRoomToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rateRoomToolStripMenuItem.Name = "rateRoomToolStripMenuItem";
            this.rateRoomToolStripMenuItem.Size = new System.Drawing.Size(168, 38);
            this.rateRoomToolStripMenuItem.Text = "Rate Room";
            this.rateRoomToolStripMenuItem.Click += new System.EventHandler(this.rateRoomToolStripMenuItem_Click);
            // 
            // bookingAgainToolStripMenuItem
            // 
            this.bookingAgainToolStripMenuItem.Image = global::HotelManagmentSyatem.Properties.Resources.Calendar_32;
            this.bookingAgainToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bookingAgainToolStripMenuItem.Name = "bookingAgainToolStripMenuItem";
            this.bookingAgainToolStripMenuItem.Size = new System.Drawing.Size(168, 38);
            this.bookingAgainToolStripMenuItem.Text = "Booking Again";
            this.bookingAgainToolStripMenuItem.Click += new System.EventHandler(this.bookingAgainToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = global::HotelManagmentSyatem.Properties.Resources.Delete_32;
            this.removeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(168, 38);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Image = global::HotelManagmentSyatem.Properties.Resources.CancelBooking1;
            this.cancelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(168, 38);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // llRoomDetails
            // 
            this.llRoomDetails.AutoSize = true;
            this.llRoomDetails.Location = new System.Drawing.Point(427, 54);
            this.llRoomDetails.Name = "llRoomDetails";
            this.llRoomDetails.Size = new System.Drawing.Size(70, 13);
            this.llRoomDetails.TabIndex = 10;
            this.llRoomDetails.TabStop = true;
            this.llRoomDetails.Text = "Room Details";
            // 
            // lblReservationDate
            // 
            this.lblReservationDate.AllowParentOverrides = false;
            this.lblReservationDate.AutoEllipsis = false;
            this.lblReservationDate.CursorType = null;
            this.lblReservationDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblReservationDate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblReservationDate.Location = new System.Drawing.Point(427, 87);
            this.lblReservationDate.Name = "lblReservationDate";
            this.lblReservationDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReservationDate.Size = new System.Drawing.Size(132, 17);
            this.lblReservationDate.TabIndex = 9;
            this.lblReservationDate.Text = "Friday, april, 25, 2024";
            this.lblReservationDate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblReservationDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AllowParentOverrides = false;
            this.lblRoomType.AutoEllipsis = false;
            this.lblRoomType.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRoomType.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRoomType.Location = new System.Drawing.Point(106, 41);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRoomType.Size = new System.Drawing.Size(70, 17);
            this.lblRoomType.TabIndex = 7;
            this.lblRoomType.Text = "Room Type";
            this.lblRoomType.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblRoomType.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuImageButton1.ContextMenuStrip = this.contextMenuStrip1;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::HotelManagmentSyatem.Properties.Resources.dots;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 20;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(612, 11);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuImageButton1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.bookingAgainToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.toolStripMenuItem2,
            this.rateRoomToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 168);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(165, 6);
            // 
            // lblReservationCost
            // 
            this.lblReservationCost.AllowParentOverrides = false;
            this.lblReservationCost.AutoEllipsis = false;
            this.lblReservationCost.CursorType = null;
            this.lblReservationCost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblReservationCost.Location = new System.Drawing.Point(427, 21);
            this.lblReservationCost.Name = "lblReservationCost";
            this.lblReservationCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReservationCost.Size = new System.Drawing.Size(59, 17);
            this.lblReservationCost.TabIndex = 5;
            this.lblReservationCost.Text = "US $ 1000";
            this.lblReservationCost.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblReservationCost.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblReservationStatus
            // 
            this.lblReservationStatus.AllowParentOverrides = false;
            this.lblReservationStatus.AutoEllipsis = false;
            this.lblReservationStatus.CursorType = null;
            this.lblReservationStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblReservationStatus.Location = new System.Drawing.Point(106, 87);
            this.lblReservationStatus.Name = "lblReservationStatus";
            this.lblReservationStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReservationStatus.Size = new System.Drawing.Size(114, 17);
            this.lblReservationStatus.TabIndex = 4;
            this.lblReservationStatus.Text = "Reservation Status";
            this.lblReservationStatus.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblReservationStatus.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblCheckInCheckOut
            // 
            this.lblCheckInCheckOut.AllowParentOverrides = false;
            this.lblCheckInCheckOut.AutoEllipsis = false;
            this.lblCheckInCheckOut.CursorType = null;
            this.lblCheckInCheckOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCheckInCheckOut.Location = new System.Drawing.Point(106, 64);
            this.lblCheckInCheckOut.Name = "lblCheckInCheckOut";
            this.lblCheckInCheckOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCheckInCheckOut.Size = new System.Drawing.Size(93, 17);
            this.lblCheckInCheckOut.TabIndex = 2;
            this.lblCheckInCheckOut.Text = "24 mar - 26 apr";
            this.lblCheckInCheckOut.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCheckInCheckOut.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AllowParentOverrides = false;
            this.lblRoomNumber.AutoEllipsis = false;
            this.lblRoomNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRoomNumber.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRoomNumber.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRoomNumber.Location = new System.Drawing.Point(106, 18);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRoomNumber.Size = new System.Drawing.Size(90, 17);
            this.lblRoomNumber.TabIndex = 1;
            this.lblRoomNumber.Text = "Room Number";
            this.lblRoomNumber.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblRoomNumber.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // picRoom
            // 
            this.picRoom.AllowFocused = false;
            this.picRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picRoom.AutoSizeHeight = true;
            this.picRoom.BorderRadius = 0;
            this.picRoom.Image = ((System.Drawing.Image)(resources.GetObject("picRoom.Image")));
            this.picRoom.IsCircle = true;
            this.picRoom.Location = new System.Drawing.Point(268, 11);
            this.picRoom.Name = "picRoom";
            this.picRoom.Size = new System.Drawing.Size(99, 99);
            this.picRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRoom.TabIndex = 0;
            this.picRoom.TabStop = false;
            this.picRoom.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bunifuPanel2.BorderRadius = 10;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.llRoomDetails);
            this.bunifuPanel2.Controls.Add(this.lblReservationDate);
            this.bunifuPanel2.Controls.Add(this.lblRoomType);
            this.bunifuPanel2.Controls.Add(this.bunifuImageButton1);
            this.bunifuPanel2.Controls.Add(this.lblReservationCost);
            this.bunifuPanel2.Controls.Add(this.lblReservationStatus);
            this.bunifuPanel2.Controls.Add(this.lblCheckInCheckOut);
            this.bunifuPanel2.Controls.Add(this.lblRoomNumber);
            this.bunifuPanel2.Controls.Add(this.picRoom);
            this.bunifuPanel2.Location = new System.Drawing.Point(3, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(665, 120);
            this.bunifuPanel2.TabIndex = 4;
            // 
            // ctrlCustomerBookingRoomCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuPanel2);
            this.Name = "ctrlCustomerBookingRoomCard";
            this.Size = new System.Drawing.Size(665, 120);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem rateRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingAgainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.LinkLabel llRoomDetails;
        private Bunifu.UI.WinForms.BunifuLabel lblReservationDate;
        private Bunifu.UI.WinForms.BunifuLabel lblRoomType;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private Bunifu.UI.WinForms.BunifuLabel lblReservationCost;
        private Bunifu.UI.WinForms.BunifuLabel lblReservationStatus;
        private Bunifu.UI.WinForms.BunifuLabel lblCheckInCheckOut;
        private Bunifu.UI.WinForms.BunifuLabel lblRoomNumber;
        private Bunifu.UI.WinForms.BunifuPictureBox picRoom;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
    }
}
