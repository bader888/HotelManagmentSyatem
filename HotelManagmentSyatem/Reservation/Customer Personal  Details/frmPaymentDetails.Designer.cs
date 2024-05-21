namespace HotelManagmentSyatem.Reservation
{
    partial class frmPaymentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentDetails));
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.ctrlPaymentDetailsCard1 = new HotelManagmentSyatem.Reservation.Controls.ctrlPaymentDetailsCard();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(47, 43);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(185, 32);
            this.bunifuLabel1.TabIndex = 4;
            this.bunifuLabel1.Text = "Payment Details";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ctrlPaymentDetailsCard1
            // 
            this.ctrlPaymentDetailsCard1.Location = new System.Drawing.Point(47, 91);
            this.ctrlPaymentDetailsCard1.Mode = HotelManagmentSyatem.Reservation.Controls.ctrlPaymentDetailsCard.enMode.AddNewPaymeny;
            this.ctrlPaymentDetailsCard1.Name = "ctrlPaymentDetailsCard1";
            this.ctrlPaymentDetailsCard1.Size = new System.Drawing.Size(600, 287);
            this.ctrlPaymentDetailsCard1.TabIndex = 11;
            // 
            // frmPaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 420);
            this.Controls.Add(this.ctrlPaymentDetailsCard1);
            this.Controls.Add(this.bunifuLabel1);
            this.Name = "frmPaymentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPaymentDetails";
            this.Load += new System.EventHandler(this.frmPaymentDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Controls.ctrlPaymentDetailsCard ctrlPaymentDetailsCard1;
    }
}