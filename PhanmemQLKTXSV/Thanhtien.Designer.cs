namespace PhanmemQLKTXSV
{
    partial class Thanhtien
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tenkhachhang = new System.Windows.Forms.TextBox();
            this.Tienthanhtoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 53;
            this.label1.Text = "Thông báo số tiền trọ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 38);
            this.button1.TabIndex = 57;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tên sinh viên thuê :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 19);
            this.label3.TabIndex = 59;
            this.label3.Text = "Số tiền cần thanh toán :";
            // 
            // Tenkhachhang
            // 
            this.Tenkhachhang.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Tenkhachhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tenkhachhang.Location = new System.Drawing.Point(130, 87);
            this.Tenkhachhang.Name = "Tenkhachhang";
            this.Tenkhachhang.Size = new System.Drawing.Size(204, 19);
            this.Tenkhachhang.TabIndex = 60;
            // 
            // Tienthanhtoan
            // 
            this.Tienthanhtoan.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Tienthanhtoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tienthanhtoan.Location = new System.Drawing.Point(163, 130);
            this.Tienthanhtoan.Name = "Tienthanhtoan";
            this.Tienthanhtoan.Size = new System.Drawing.Size(160, 19);
            this.Tienthanhtoan.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 62;
            this.label4.Text = "Chú ý :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 75);
            this.label5.TabIndex = 63;
            this.label5.Text = "Nếu có sai sót vui lòng kiểm \r\ntra lại các khoản phụ phí \r\nqua các tháng !\r\nHoặc " +
    "liên hệ số điện thoại \r\nquản trị : 0120.542.578";
            // 
            // Thanhtien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 289);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tienthanhtoan);
            this.Controls.Add(this.Tenkhachhang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Thanhtien";
            this.Text = "Thông báo tiền";
            this.Load += new System.EventHandler(this.Thanhtien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tenkhachhang;
        private System.Windows.Forms.TextBox Tienthanhtoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}