namespace PhanmemQLKTXSV
{
    partial class Quanlyphong
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
            this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sogiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongsv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbmanv = new System.Windows.Forms.ComboBox();
            this.cmbhotennv = new System.Windows.Forms.ComboBox();
            this.txtsoluongsv = new System.Windows.Forms.TextBox();
            this.txtgiatien = new System.Windows.Forms.TextBox();
            this.cmbtinhtrang = new System.Windows.Forms.ComboBox();
            this.txtsogiuong = new System.Windows.Forms.TextBox();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.cmbloaiphong = new System.Windows.Forms.ComboBox();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet1 = new PhanmemQLKTXSV.DataSet1();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongTableAdapter = new PhanmemQLKTXSV.DataSet1TableAdapters.PhongTableAdapter();
            this.phongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phongBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.phongBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPhong
            // 
            this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong,
            this.loaiphong,
            this.tenphong,
            this.hotennv,
            this.manv,
            this.sogiuong,
            this.tinhtrang,
            this.giatien,
            this.soluongsv});
            this.dataGridViewPhong.Location = new System.Drawing.Point(168, 198);
            this.dataGridViewPhong.Name = "dataGridViewPhong";
            this.dataGridViewPhong.Size = new System.Drawing.Size(589, 237);
            this.dataGridViewPhong.TabIndex = 39;
            this.dataGridViewPhong.Click += new System.EventHandler(this.dataGridViewPhong_Click);
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã Phòng";
            this.maphong.Name = "maphong";
            // 
            // loaiphong
            // 
            this.loaiphong.DataPropertyName = "loaiphong";
            this.loaiphong.HeaderText = "Loại phòng";
            this.loaiphong.Name = "loaiphong";
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "tenphong";
            this.tenphong.HeaderText = "Tên phòng";
            this.tenphong.Name = "tenphong";
            // 
            // hotennv
            // 
            this.hotennv.DataPropertyName = "hotennv";
            this.hotennv.HeaderText = "Tên cán bộ";
            this.hotennv.Name = "hotennv";
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã cán bộ";
            this.manv.Name = "manv";
            // 
            // sogiuong
            // 
            this.sogiuong.DataPropertyName = "sogiuong";
            this.sogiuong.HeaderText = "Số giường";
            this.sogiuong.Name = "sogiuong";
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.Name = "tinhtrang";
            // 
            // giatien
            // 
            this.giatien.DataPropertyName = "giatien";
            this.giatien.HeaderText = "Giá tiền";
            this.giatien.Name = "giatien";
            // 
            // soluongsv
            // 
            this.soluongsv.DataPropertyName = "soluongsv";
            this.soluongsv.HeaderText = "Số lượng SV";
            this.soluongsv.Name = "soluongsv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 26);
            this.label1.TabIndex = 51;
            this.label1.Text = "Quản lý Phòng ký túc xá";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbmanv);
            this.groupBox1.Controls.Add(this.cmbhotennv);
            this.groupBox1.Controls.Add(this.txtsoluongsv);
            this.groupBox1.Controls.Add(this.txtgiatien);
            this.groupBox1.Controls.Add(this.cmbtinhtrang);
            this.groupBox1.Controls.Add(this.txtsogiuong);
            this.groupBox1.Controls.Add(this.txttenphong);
            this.groupBox1.Controls.Add(this.cmbloaiphong);
            this.groupBox1.Controls.Add(this.txtmaphong);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 147);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // cmbmanv
            // 
            this.cmbmanv.DataSource = this.phongBindingSource1;
            this.cmbmanv.DisplayMember = "manv";
            this.cmbmanv.FormattingEnabled = true;
            this.cmbmanv.Location = new System.Drawing.Point(344, 67);
            this.cmbmanv.Name = "cmbmanv";
            this.cmbmanv.Size = new System.Drawing.Size(125, 27);
            this.cmbmanv.TabIndex = 87;
            // 
            // cmbhotennv
            // 
            this.cmbhotennv.DataSource = this.phongBindingSource;
            this.cmbhotennv.DisplayMember = "hotennv";
            this.cmbhotennv.FormattingEnabled = true;
            this.cmbhotennv.Location = new System.Drawing.Point(344, 27);
            this.cmbhotennv.Name = "cmbhotennv";
            this.cmbhotennv.Size = new System.Drawing.Size(125, 27);
            this.cmbhotennv.TabIndex = 86;
            // 
            // txtsoluongsv
            // 
            this.txtsoluongsv.Location = new System.Drawing.Point(608, 106);
            this.txtsoluongsv.Name = "txtsoluongsv";
            this.txtsoluongsv.Size = new System.Drawing.Size(125, 26);
            this.txtsoluongsv.TabIndex = 85;
            // 
            // txtgiatien
            // 
            this.txtgiatien.Location = new System.Drawing.Point(608, 67);
            this.txtgiatien.Name = "txtgiatien";
            this.txtgiatien.Size = new System.Drawing.Size(125, 26);
            this.txtgiatien.TabIndex = 84;
            // 
            // cmbtinhtrang
            // 
            this.cmbtinhtrang.DataSource = this.phongBindingSource3;
            this.cmbtinhtrang.DisplayMember = "tinhtrang";
            this.cmbtinhtrang.FormattingEnabled = true;
            this.cmbtinhtrang.Location = new System.Drawing.Point(608, 26);
            this.cmbtinhtrang.Name = "cmbtinhtrang";
            this.cmbtinhtrang.Size = new System.Drawing.Size(125, 27);
            this.cmbtinhtrang.TabIndex = 83;
            // 
            // txtsogiuong
            // 
            this.txtsogiuong.Location = new System.Drawing.Point(344, 106);
            this.txtsogiuong.Name = "txtsogiuong";
            this.txtsogiuong.Size = new System.Drawing.Size(125, 26);
            this.txtsogiuong.TabIndex = 82;
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(104, 103);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(125, 26);
            this.txttenphong.TabIndex = 81;
            // 
            // cmbloaiphong
            // 
            this.cmbloaiphong.DataSource = this.phongBindingSource2;
            this.cmbloaiphong.DisplayMember = "loaiphong";
            this.cmbloaiphong.FormattingEnabled = true;
            this.cmbloaiphong.Location = new System.Drawing.Point(104, 64);
            this.cmbloaiphong.Name = "cmbloaiphong";
            this.cmbloaiphong.Size = new System.Drawing.Size(125, 27);
            this.cmbloaiphong.TabIndex = 80;
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(104, 27);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(125, 26);
            this.txtmaphong.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 78;
            this.label10.Text = "Số giường";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 19);
            this.label9.TabIndex = 77;
            this.label9.Text = "Số lượng SV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 76;
            this.label8.Text = "Mã cán bộ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 75;
            this.label7.Text = "Giá tiền phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 74;
            this.label6.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 73;
            this.label5.Text = "Tên cán bộ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 72;
            this.label4.Text = "Tên phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 71;
            this.label3.Text = "Loại phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 70;
            this.label2.Text = "Mã phòng";
            // 
            // button4
            // 
            this.button4.Image = global::PhanmemQLKTXSV.Properties.Resources.arrow_refresh;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(45, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 42);
            this.button4.TabIndex = 35;
            this.button4.Text = "Load";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::PhanmemQLKTXSV.Properties.Resources.application_form_delete;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(45, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 42);
            this.button3.TabIndex = 34;
            this.button3.Text = "Xóa";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::PhanmemQLKTXSV.Properties.Resources.application_form_edit;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(46, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 42);
            this.button2.TabIndex = 33;
            this.button2.Text = "Sửa";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::PhanmemQLKTXSV.Properties.Resources.application_form_add;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(46, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 42);
            this.button1.TabIndex = 32;
            this.button1.Text = "Thêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataMember = "Phong";
            this.phongBindingSource.DataSource = this.dataSet1;
            // 
            // phongTableAdapter
            // 
            this.phongTableAdapter.ClearBeforeFill = true;
            // 
            // phongBindingSource1
            // 
            this.phongBindingSource1.DataMember = "Phong";
            this.phongBindingSource1.DataSource = this.dataSet1;
            // 
            // phongBindingSource2
            // 
            this.phongBindingSource2.DataMember = "Phong";
            this.phongBindingSource2.DataSource = this.dataSet1;
            // 
            // phongBindingSource3
            // 
            this.phongBindingSource3.DataMember = "Phong";
            this.phongBindingSource3.DataSource = this.dataSet1;
            // 
            // Quanlyphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 459);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPhong);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Quanlyphong";
            this.Text = "Quản lý Phòng cho thuê";
            this.Load += new System.EventHandler(this.Quanlyphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridViewPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sogiuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatien;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongsv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbmanv;
        private System.Windows.Forms.ComboBox cmbhotennv;
        private System.Windows.Forms.TextBox txtsoluongsv;
        private System.Windows.Forms.TextBox txtgiatien;
        private System.Windows.Forms.ComboBox cmbtinhtrang;
        private System.Windows.Forms.TextBox txtsogiuong;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.ComboBox cmbloaiphong;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private DataSet1TableAdapters.PhongTableAdapter phongTableAdapter;
        private System.Windows.Forms.BindingSource phongBindingSource1;
        private System.Windows.Forms.BindingSource phongBindingSource3;
        private System.Windows.Forms.BindingSource phongBindingSource2;
    }
}