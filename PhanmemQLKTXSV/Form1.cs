using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PhanmemQLKTXSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sql;
        string chuoiketnoi = @"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            sql = @"Select Phong.maphong, Sinhvien.hoten, DATEDIFF(day,Sinhvien.ngayden, GETDATE()), DATEDIFF(day,Sinhvien.ngayden, GETDATE()) * Phong.giatien 
from     Phong Inner Join Sinhvien 
on       Phong.maphong = Sinhvien.maphong 
where   (Sinhvien.maphong = N'" + cbmaphong.Text + @"')and(Sinhvien.hoten = N'" + txthoten.Text + @"') ";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            while (docdulieu.Read())
            {
                lblphong.Text = docdulieu[0].ToString();
                lblsongay.Text = docdulieu[2].ToString();
                lbltongtien.Text = docdulieu[3].ToString();
            }
            ketnoi.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.dataSet1.Phong);
            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();
        }
        public void hienthi()
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"Select masv, hoten, gioitinh, diachi, ngayden, maphong from Sinhvien";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listView1.Items.Add(docdulieu[0].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[1].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[2].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[3].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[4].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[5].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void btntkmaphong_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = "Select masv, hoten, gioitinh, diachi, ngayden, maphong from Sinhvien where (maphong like '%" + cbmaphong.Text + "%')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listView1.Items.Add(docdulieu[0].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[1].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[2].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[3].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[4].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[5].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void btntkten_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = "Select masv, hoten, gioitinh, diachi, ngayden, maphong from Sinhvien where (hoten like '%" + txthoten.Text + "%')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listView1.Items.Add(docdulieu[0].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[1].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[2].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[3].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[4].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[5].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            cbmaphong.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txthoten.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }



    } 
}
