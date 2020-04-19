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
    public partial class QuanlySV : Form
    {
        public QuanlySV()
        {
            InitializeComponent();
        }

        //kết nối đến sql cho nó hiện lên ddataGridView
        private void ketnoidulieu()
        {
            try
            {

                SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
                kn.Open();
                string sql = "select * from Sinhvien";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dataGridViewSinhvien.DataSource = table;
            }
            catch
            {
                MessageBox.Show("LỖI KẾT NỐI VUI LÒNG KIỂM TRA LẠI !");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
                kn.Close();
            }
        }

        private void QuanlySV_Load(object sender, EventArgs e)
        {
            ketnoidulieu();
        }

        //cho nó hiện lên textbox
        int index;
        private void dataGridViewSinhvien_Click(object sender, EventArgs e)
        {
            index = dataGridViewSinhvien.CurrentRow.Index;
            txtmasv.Text = dataGridViewSinhvien.Rows[index].Cells[0].Value.ToString();
            txthoten.Text = dataGridViewSinhvien.Rows[index].Cells[1].Value.ToString();
            cmbgioitinh.Text = dataGridViewSinhvien.Rows[index].Cells[2].Value.ToString();
            txtngaysinh.Text = dataGridViewSinhvien.Rows[index].Cells[3].Value.ToString();
            txtnoisinh.Text = dataGridViewSinhvien.Rows[index].Cells[4].Value.ToString();
            txtdantoc.Text = dataGridViewSinhvien.Rows[index].Cells[5].Value.ToString();
            txtdiachi.Text = dataGridViewSinhvien.Rows[index].Cells[6].Value.ToString();
            txtngayden.Text = dataGridViewSinhvien.Rows[index].Cells[7].Value.ToString();
            txtmaphong.Text = dataGridViewSinhvien.Rows[index].Cells[8].Value.ToString();


        }

        //thêm
        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
            try
            {
                if (txtmasv.Text != "" && txthoten.Text != "" && cmbgioitinh.Text != "" && txtngaysinh.Text != "" && txtnoisinh.Text != "" && txtdantoc.Text != "" && txtdiachi.Text != "" && txtngayden.Text != "" && txtmaphong.Text != "")
                {
                    kn.Open();
                    string sql = "insert into Sinhvien values('" + txtmasv.Text + "',N'" + txthoten.Text + "',N'" + cmbgioitinh.Text + "','" + txtngaysinh.Text + "',N'" + txtnoisinh.Text + "',N'" + txtdantoc.Text + "',N'" + txtdiachi.Text + "','" + txtngayden.Text + "','" + txtmaphong.Text + "')";
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
            catch(Exception ex)
            {
             MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            }
        //sửa
        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
            try
            {
                kn.Open();
                string sql = "update Sinhvien set hoten=N'" + txthoten.Text + "',gioitinh=N'" + cmbgioitinh.Text + "',ngaysinh='" + txtngaysinh.Text + "',noisinh=N'" + txtnoisinh.Text + "',dantoc=N'" + txtdantoc.Text + "',diachi=N'" + txtdiachi.Text + "',ngayden='" + txtngayden.Text + "',maphong='" + txtmaphong.Text + "' where masv='" + txtmasv.Text + "'  ";
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

        //xóa 
        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
                kn.Open();
                string sql = "delete Sinhvien where masv='" + txtmasv.Text + "'";
                SqlCommand commandxoa = new SqlCommand(sql, kn);
                commandxoa.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                ketnoidulieu();
                kn.Close();
            }
        }

        //hết
        }
    }
