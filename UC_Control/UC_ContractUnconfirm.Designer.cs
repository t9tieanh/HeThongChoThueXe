namespace HeThongChoThueXe.UC_Control
{
    partial class UC_ContractUnconfirm
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
            this.PicCustomer = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picStatus = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblStartday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDetail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblIdContract = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNameCustomer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PicCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // PicCustomer
            // 
            this.PicCustomer.FillColor = System.Drawing.Color.IndianRed;
            this.PicCustomer.ImageRotate = 0F;
            this.PicCustomer.Location = new System.Drawing.Point(2, 1);
            this.PicCustomer.Name = "PicCustomer";
            this.PicCustomer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PicCustomer.Size = new System.Drawing.Size(40, 37);
            this.PicCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCustomer.TabIndex = 18;
            this.PicCustomer.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.lblStatus.Location = new System.Drawing.Point(249, 23);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(87, 65);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Contract pending confirmation";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(258, 107);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(24, 18);
            this.guna2HtmlLabel1.TabIndex = 16;
            this.guna2HtmlLabel1.Text = "ID : ";
            // 
            // picStatus
            // 
            this.picStatus.BackColor = System.Drawing.Color.White;
            this.picStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.picStatus.ImageRotate = 0F;
            this.picStatus.Location = new System.Drawing.Point(336, 3);
            this.picStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picStatus.Name = "picStatus";
            this.picStatus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picStatus.Size = new System.Drawing.Size(9, 8);
            this.picStatus.TabIndex = 15;
            this.picStatus.TabStop = false;
            // 
            // lblStartday
            // 
            this.lblStartday.AutoSize = false;
            this.lblStartday.BackColor = System.Drawing.Color.Transparent;
            this.lblStartday.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.lblStartday.Location = new System.Drawing.Point(1, 107);
            this.lblStartday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblStartday.Name = "lblStartday";
            this.lblStartday.Size = new System.Drawing.Size(129, 22);
            this.lblStartday.TabIndex = 14;
            this.lblStartday.Text = "Request day";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = false;
            this.lblDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblDetail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.lblDetail.Location = new System.Drawing.Point(4, 40);
            this.lblDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(248, 66);
            this.lblDetail.TabIndex = 13;
            this.lblDetail.Text = "Service : ";
            // 
            // lblIdContract
            // 
            this.lblIdContract.BackColor = System.Drawing.Color.Transparent;
            this.lblIdContract.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdContract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.lblIdContract.Location = new System.Drawing.Point(285, 107);
            this.lblIdContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblIdContract.Name = "lblIdContract";
            this.lblIdContract.Size = new System.Drawing.Size(49, 18);
            this.lblIdContract.TabIndex = 12;
            this.lblIdContract.Text = "ID here";
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblNameCustomer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.lblNameCustomer.Location = new System.Drawing.Point(52, 9);
            this.lblNameCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(90, 25);
            this.lblNameCustomer.TabIndex = 11;
            this.lblNameCustomer.Text = "Name here";
            // 
            // UC_ContractUnconfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PicCustomer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.picStatus);
            this.Controls.Add(this.lblStartday);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblIdContract);
            this.Controls.Add(this.lblNameCustomer);
            this.Name = "UC_ContractUnconfirm";
            this.Size = new System.Drawing.Size(347, 130);
            ((System.ComponentModel.ISupportInitialize)(this.PicCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox PicCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStartday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDetail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIdContract;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNameCustomer;
    }
}
