namespace PhanmemQLKTXSV
{
    partial class Thanhtoantien1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.khungnhapsinhvien = new System.Windows.Forms.ComboBox();
            this.sinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new PhanmemQLKTXSV.DataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guixe = new System.Windows.Forms.CheckBox();
            this.dichvu = new System.Windows.Forms.CheckBox();
            this.tiennuoc = new System.Windows.Forms.CheckBox();
            this.tiendien = new System.Windows.Forms.CheckBox();
            this.tienphong = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Tongtien = new System.Windows.Forms.TextBox();
            this.qLKTKSVDataSet = new PhanmemQLKTXSV.QLKTKSVDataSet();
            this.qLKTKSVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.sinhvienTableAdapter = new PhanmemQLKTXSV.DataSet1TableAdapters.SinhvienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLKTKSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKTKSVDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(116, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 26);
            this.label1.TabIndex = 52;
            this.label1.Text = "Thanh toán tổng tiền thuê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "Tên sinh viên :";
            // 
            // khungnhapsinhvien
            // 
            this.khungnhapsinhvien.DataSource = this.sinhvienBindingSource;
            this.khungnhapsinhvien.DisplayMember = "hoten";
            this.khungnhapsinhvien.FormattingEnabled = true;
            this.khungnhapsinhvien.Location = new System.Drawing.Point(168, 66);
            this.khungnhapsinhvien.Name = "khungnhapsinhvien";
            this.khungnhapsinhvien.Size = new System.Drawing.Size(284, 27);
            this.khungnhapsinhvien.TabIndex = 54;
            // 
            // sinhvienBindingSource
            // 
            this.sinhvienBindingSource.DataMember = "Sinhvien";
            this.sinhvienBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guixe);
            this.groupBox1.Controls.Add(this.dichvu);
            this.groupBox1.Controls.Add(this.tiennuoc);
            this.groupBox1.Controls.Add(this.tiendien);
            this.groupBox1.Controls.Add(this.tienphong);
            this.groupBox1.Location = new System.Drawing.Point(36, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 132);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các loại tiền cần thanh toán :";
            // 
            // guixe
            // 
            this.guixe.AutoSize = true;
            this.guixe.Location = new System.Drawing.Point(213, 39);
            this.guixe.Name = "guixe";
            this.guixe.Size = new System.Drawing.Size(112, 23);
            this.guixe.TabIndex = 4;
            this.guixe.Text = "Chi phí gửi xe";
            this.guixe.UseVisualStyleBackColor = true;
            this.guixe.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // dichvu
            // 
            this.dichvu.AutoSize = true;
            this.dichvu.Location = new System.Drawing.Point(213, 68);
            this.dichvu.Name = "dichvu";
            this.dichvu.Size = new System.Drawing.Size(190, 23);
            this.dichvu.TabIndex = 3;
            this.dichvu.Text = "Tiền dịch vụ phát sinh thêm";
            this.dichvu.UseVisualStyleBackColor = true;
            this.dichvu.CheckedChanged += new System.EventHandler(this.dichvu_CheckedChanged);
            // 
            // tiennuoc
            // 
            this.tiennuoc.AutoSize = true;
            this.tiennuoc.Location = new System.Drawing.Point(37, 97);
            this.tiennuoc.Name = "tiennuoc";
            this.tiennuoc.Size = new System.Drawing.Size(88, 23);
            this.tiennuoc.TabIndex = 2;
            this.tiennuoc.Text = "Tiền nước";
            this.tiennuoc.UseVisualStyleBackColor = true;
            this.tiennuoc.CheckedChanged += new System.EventHandler(this.tiennuoc_CheckedChanged);
            // 
            // tiendien
            // 
            this.tiendien.AutoSize = true;
            this.tiendien.Location = new System.Drawing.Point(37, 68);
            this.tiendien.Name = "tiendien";
            this.tiendien.Size = new System.Drawing.Size(82, 23);
            this.tiendien.TabIndex = 1;
            this.tiendien.Text = "Tiền điện";
            this.tiendien.UseVisualStyleBackColor = true;
            this.tiendien.CheckedChanged += new System.EventHandler(this.tiendien_CheckedChanged);
            // 
            // tienphong
            // 
            this.tienphong.AutoSize = true;
            this.tienphong.Location = new System.Drawing.Point(37, 39);
            this.tienphong.Name = "tienphong";
            this.tienphong.Size = new System.Drawing.Size(94, 23);
            this.tienphong.TabIndex = 0;
            this.tienphong.Text = "Tiền phòng";
            this.tienphong.UseVisualStyleBackColor = true;
            this.tienphong.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tháng thanh toán :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Tháng mới nhất "});
            this.comboBox2.Location = new System.Drawing.Point(168, 100);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(91, 27);
            this.comboBox2.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 37);
            this.button1.TabIndex = 58;
            this.button1.Text = "Tính tiền";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 37);
            this.button2.TabIndex = 59;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 60;
            this.label4.Text = "Tổng tiền";
            // 
            // Tongtien
            // 
            this.Tongtien.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Tongtien.Location = new System.Drawing.Point(187, 293);
            this.Tongtien.Name = "Tongtien";
            this.Tongtien.Size = new System.Drawing.Size(180, 26);
            this.Tongtien.TabIndex = 61;
            // 
            // qLKTKSVDataSet
            // 
            this.qLKTKSVDataSet.DataSetName = "QLKTKSVDataSet";
            this.qLKTKSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLKTKSVDataSetBindingSource
            // 
            this.qLKTKSVDataSetBindingSource.DataSource = this.qLKTKSVDataSet;
            this.qLKTKSVDataSetBindingSource.Position = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(280, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 27);
            this.button3.TabIndex = 62;
            this.button3.Text = "Tìm kiếm tên sinh viên";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sinhvienTableAdapter
            // 
            this.sinhvienTableAdapter.ClearBeforeFill = true;
            // 
            // Thanhtoantien1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 390);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Tongtien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.khungnhapsinhvien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Thanhtoantien1";
            this.Text = "Thanh toán tiền trọ";
            this.Load += new System.EventHandler(this.Thanhtoantien1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLKTKSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKTKSVDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox khungnhapsinhvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox tiennuoc;
        private System.Windows.Forms.CheckBox tiendien;
        private System.Windows.Forms.CheckBox tienphong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox guixe;
        private System.Windows.Forms.CheckBox dichvu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tongtien;
        private QLKTKSVDataSet qLKTKSVDataSet;
        private System.Windows.Forms.BindingSource qLKTKSVDataSetBindingSource;
        private System.Windows.Forms.Button button3;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource sinhvienBindingSource;
        private DataSet1TableAdapters.SinhvienTableAdapter sinhvienTableAdapter;
    }
}