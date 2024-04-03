namespace HotelManagmentSyatem
{
    partial class ctrlHotelFacilite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlHotelFacilite));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnUpdate = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnDelete = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pcFaciliteImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.ckFacilite = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.lblFaciliteName = new Bunifu.UI.WinForms.BunifuLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFaciliteImage)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.btnUpdate);
            this.bunifuCards1.Controls.Add(this.btnDelete);
            this.bunifuCards1.Controls.Add(this.pcFaciliteImage);
            this.bunifuCards1.Controls.Add(this.ckFacilite);
            this.bunifuCards1.Controls.Add(this.lblFaciliteName);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(3, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(292, 44);
            this.bunifuCards1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AllowFocused = false;
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.AutoSizeHeight = true;
            this.btnUpdate.BorderRadius = 11;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.IsCircle = true;
            this.btnUpdate.Location = new System.Drawing.Point(192, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(22, 22);
            this.btnUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AllowFocused = false;
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.AutoSizeHeight = true;
            this.btnDelete.BorderRadius = 11;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = global::HotelManagmentSyatem.Properties.Resources.Close_64;
            this.btnDelete.IsCircle = true;
            this.btnDelete.Location = new System.Drawing.Point(228, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(22, 22);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 7;
            this.btnDelete.TabStop = false;
            this.btnDelete.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pcFaciliteImage
            // 
            this.pcFaciliteImage.AllowFocused = false;
            this.pcFaciliteImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcFaciliteImage.AutoSizeHeight = true;
            this.pcFaciliteImage.BorderRadius = 11;
            this.pcFaciliteImage.Image = global::HotelManagmentSyatem.Properties.Resources.Close_64;
            this.pcFaciliteImage.IsCircle = true;
            this.pcFaciliteImage.Location = new System.Drawing.Point(5, 11);
            this.pcFaciliteImage.Name = "pcFaciliteImage";
            this.pcFaciliteImage.Size = new System.Drawing.Size(22, 22);
            this.pcFaciliteImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcFaciliteImage.TabIndex = 6;
            this.pcFaciliteImage.TabStop = false;
            this.pcFaciliteImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // ckFacilite
            // 
            this.ckFacilite.AllowBindingControlAnimation = true;
            this.ckFacilite.AllowBindingControlColorChanges = false;
            this.ckFacilite.AllowBindingControlLocation = true;
            this.ckFacilite.AllowCheckBoxAnimation = false;
            this.ckFacilite.AllowCheckmarkAnimation = true;
            this.ckFacilite.AllowOnHoverStates = true;
            this.ckFacilite.AutoCheck = true;
            this.ckFacilite.BackColor = System.Drawing.Color.Transparent;
            this.ckFacilite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ckFacilite.BackgroundImage")));
            this.ckFacilite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ckFacilite.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.ckFacilite.BorderRadius = 12;
            this.ckFacilite.Checked = false;
            this.ckFacilite.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.ckFacilite.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckFacilite.CustomCheckmarkImage = null;
            this.ckFacilite.Location = new System.Drawing.Point(264, 12);
            this.ckFacilite.MinimumSize = new System.Drawing.Size(17, 17);
            this.ckFacilite.Name = "ckFacilite";
            this.ckFacilite.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ckFacilite.OnCheck.BorderRadius = 12;
            this.ckFacilite.OnCheck.BorderThickness = 2;
            this.ckFacilite.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.ckFacilite.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.ckFacilite.OnCheck.CheckmarkThickness = 2;
            this.ckFacilite.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.ckFacilite.OnDisable.BorderRadius = 12;
            this.ckFacilite.OnDisable.BorderThickness = 2;
            this.ckFacilite.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ckFacilite.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.ckFacilite.OnDisable.CheckmarkThickness = 2;
            this.ckFacilite.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ckFacilite.OnHoverChecked.BorderRadius = 12;
            this.ckFacilite.OnHoverChecked.BorderThickness = 2;
            this.ckFacilite.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ckFacilite.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.ckFacilite.OnHoverChecked.CheckmarkThickness = 2;
            this.ckFacilite.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ckFacilite.OnHoverUnchecked.BorderRadius = 12;
            this.ckFacilite.OnHoverUnchecked.BorderThickness = 1;
            this.ckFacilite.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ckFacilite.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.ckFacilite.OnUncheck.BorderRadius = 12;
            this.ckFacilite.OnUncheck.BorderThickness = 1;
            this.ckFacilite.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ckFacilite.Size = new System.Drawing.Size(21, 21);
            this.ckFacilite.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.ckFacilite.TabIndex = 4;
            this.ckFacilite.ThreeState = false;
            this.ckFacilite.ToolTipText = null;
         
            this.ckFacilite.Click += new System.EventHandler(this.ckFacilite_Click);
            // 
            // lblFaciliteName
            // 
            this.lblFaciliteName.AllowParentOverrides = false;
            this.lblFaciliteName.AutoEllipsis = false;
            this.lblFaciliteName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFaciliteName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblFaciliteName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFaciliteName.Location = new System.Drawing.Point(44, 15);
            this.lblFaciliteName.Name = "lblFaciliteName";
            this.lblFaciliteName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFaciliteName.Size = new System.Drawing.Size(69, 15);
            this.lblFaciliteName.TabIndex = 2;
            this.lblFaciliteName.Text = "FaciliteName";
            this.lblFaciliteName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFaciliteName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripMenuItem.Image")));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // ctrlHotelFacilite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards1);
            this.Name = "ctrlHotelFacilite";
            this.Size = new System.Drawing.Size(298, 50);
            this.Load += new System.EventHandler(this.ctrlHotelFacilite_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFaciliteImage)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuLabel lblFaciliteName;
        private Bunifu.UI.WinForms.BunifuCheckBox ckFacilite;
        private Bunifu.UI.WinForms.BunifuPictureBox pcFaciliteImage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private Bunifu.UI.WinForms.BunifuPictureBox btnUpdate;
        private Bunifu.UI.WinForms.BunifuPictureBox btnDelete;
    }
}
