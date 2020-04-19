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
    public partial class Quanlynhanvien : Form
    {
        public Quanlynhanvien()
        {
            InitializeComponent();
        }

        //kết nối sql
        private void ketnoidulieu()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
                kn.Open();
                string sql = "select * from Nhanvien1";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dataGridViewNhanVien.DataSource = table;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối vui lòng kiểm tra lại !");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
                kn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoidulieu();
        }

        int index;
        private void dataGridViewNhanVien_Click(object sender, EventArgs e)
        {
            index = dataGridViewNhanVien.CurrentRow.Index;
            txtmanv.Text = dataGridViewNhanVien.Rows[index].Cells[0].Value.ToString();
            txthotennv.Text = dataGridViewNhanVien.Rows[index].Cells[1].Value.ToString();
            cmbgioitinh.Text = dataGridViewNhanVien.Rows[index].Cells[2].Value.ToString();
            txtdiachi.Text = dataGridViewNhanVien.Rows[index].Cells[3].Value.ToString();
            txtsdt.Text = dataGridViewNhanVien.Rows[index].Cells[4].Value.ToString();
            txtchucvu.Text = dataGridViewNhanVien.Rows[index].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ketnoidulieu();
        }

        //thêm
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
            try
            {
                if (txtmanv.Text != "" && txthotennv.Text != "" && cmbgioitinh.Text != "" && txtdiachi.Text != "" && txtsdt.Text != "" && txtchucvu.Text != "")
                {
                    kn.Open();
                    string sql = "insert into Nhanvien1 values('" + txtmanv.Text + "',N'" + txthotennv.Text + "',N'" + cmbgioitinh.Text + "',N'" + txtdiachi.Text + "',N'" + txtsdt.Text + "',N'" + txtchucvu.Text + "')";
                    SqlCommand commandthem = new SqlCommand(sql, kn);
                    int kq = (int)commandthem.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        ketnoidulieu();
                    }
                    else
                        MessageBox.Show("Thêm Thất Bại");
                    kn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        //sửa
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
            try
            {
                kn.Open();
                string sql = "update Nhanvien1 set hotennv=N'" + txthotennv.Text + "',gioitinh=N'" + cmbgioitinh.Text + "',diachi=N'" + txtdiachi.Text + "',sdt=N'" + txtsdt.Text + "',chucvu=N'" + txtchucvu.Text + "' where manv='" + txtmanv.Text + "'  ";
                SqlCommand cmd = new SqlCommand(sql, kn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    ketnoidulieu();
                }
                else
                    MessageBox.Show("Sửa thất bại");
                kn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
                kn.Open();
                string sql = "delete Nhanvien1 where manv='" + txtmanv.Text + "'";
                SqlCommand commandxoa = new SqlCommand(sql, kn);
                commandxoa.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                ketnoidulieu();
                kn.Close();
            }
        }



    }
}
