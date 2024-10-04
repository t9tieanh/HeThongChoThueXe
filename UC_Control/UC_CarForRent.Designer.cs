namespace HeThongChoThueXe.UC_Control
{
    partial class UC_CarForRent
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
            this.pnImage = new Guna.UI2.WinForms.Guna2Panel();
            this.picImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnTrangtri = new Guna.UI2.WinForms.Guna2Panel();
            this.btnChoosePark = new Guna.UI2.WinForms.Guna2Button();
            this.lblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblIDPark = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnImage
            // 
            this.pnImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.pnImage.BorderRadius = 10;
            this.pnImage.BorderThickness = 2;
            this.pnImage.Controls.Add(this.picImage);
            this.pnImage.FillColor = System.Drawing.Color.Transparent;
            this.pnImage.Location = new System.Drawing.Point(10, 11);
            this.pnImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnImage.Name = "pnImage";
            this.pnImage.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pnImage.Size = new System.Drawing.Size(154, 110);
            this.pnImage.TabIndex = 45;
            // 
            // picImage
            // 
            this.picImage.ImageRotate = 0F;
            this.picImage.Location = new System.Drawing.Point(7, 5);
            this.picImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(141, 101);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // pnTrangtri
            // 
            this.pnTrangtri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.pnTrangtri.Location = new System.Drawing.Point(10, 232);
            this.pnTrangtri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnTrangtri.Name = "pnTrangtri";
            this.pnTrangtri.Size = new System.Drawing.Size(158, 3);
            this.pnTrangtri.TabIndex = 49;
            // 
            // btnChoosePark
            // 
            this.btnChoosePark.BackColor = System.Drawing.Color.Transparent;
            this.btnChoosePark.BorderColor = System.Drawing.Color.White;
            this.btnChoosePark.BorderRadius = 10;
            this.btnChoosePark.BorderThickness = 1;
            this.btnChoosePark.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoosePark.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoosePark.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoosePark.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoosePark.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnChoosePark.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePark.ForeColor = System.Drawing.Color.White;
            this.btnChoosePark.Location = new System.Drawing.Point(10, 193);
            this.btnChoosePark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChoosePark.Name = "btnChoosePark";
            this.btnChoosePark.Size = new System.Drawing.Size(154, 26);
            this.btnChoosePark.TabIndex = 48;
            this.btnChoosePark.Text = "Xem thông tin";
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblAddress.Location = new System.Drawing.Point(12, 165);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 18);
            this.lblAddress.TabIndex = 47;
            this.lblAddress.Text = "Giá: 100.000";
            // 
            // lblIDPark
            // 
            this.lblIDPark.BackColor = System.Drawing.Color.Transparent;
            this.lblIDPark.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lblIDPark.Location = new System.Drawing.Point(12, 138);
            this.lblIDPark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblIDPark.Name = "lblIDPark";
            this.lblIDPark.Size = new System.Drawing.Size(59, 21);
            this.lblIDPark.TabIndex = 46;
            this.lblIDPark.Text = "Tên xe";
            // 
            // UC_CarForRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnImage);
            this.Controls.Add(this.pnTrangtri);
            this.Controls.Add(this.btnChoosePark);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblIDPark);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_CarForRent";
            this.Size = new System.Drawing.Size(177, 246);
            this.pnImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnImage;
        private Guna.UI2.WinForms.Guna2PictureBox picImage;
        private Guna.UI2.WinForms.Guna2Panel pnTrangtri;
        private Guna.UI2.WinForms.Guna2Button btnChoosePark;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIDPark;
    }
}
