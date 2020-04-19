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
    public partial class Quanlyphong : Form
    {
        public Quanlyphong()
        {
            InitializeComponent();
        }

        //
        private void ketnoidulieu()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
                kn.Open();
                string sql = "select * from Phong";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dataGridViewPhong.DataSource = table;
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
        private void Quanlyphong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.dataSet1.Phong);
            ketnoidulieu();
        }

        int index;
        private void dataGridViewPhong_Click(object sender, EventArgs e)
        {
            index = dataGridViewPhong.CurrentRow.Index;
            txtmaphong.Text = dataGridViewPhong.Rows[index].Cells[0].Value.ToString();
            cmbloaiphong.Text = dataGridViewPhong.Rows[index].Cells[1].Value.ToString();
            txttenphong.Text = dataGridViewPhong.Rows[index].Cells[2].Value.ToString();
            cmbhotennv.Text = dataGridViewPhong.Rows[index].Cells[3].Value.ToString();
            cmbmanv.Text = dataGridViewPhong.Rows[index].Cells[4].Value.ToString();
            txtsogiuong.Text = dataGridViewPhong.Rows[index].Cells[5].Value.ToString();
            cmbtinhtrang.Text = dataGridViewPhong.Rows[index].Cells[6].Value.ToString();
            txtgiatien.Text = dataGridViewPhong.Rows[index].Cells[7].Value.ToString();
            txtsoluongsv.Text = dataGridViewPhong.Rows[index].Cells[8].Value.ToString();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ketnoidulieu();
        }

        //them
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
            try
            {
                if (txtmaphong.Text != "" && cmbloaiphong.Text != "" && txttenphong.Text != "" && cmbhotennv.Text != "" && cmbmanv.Text != "" && txtsogiuong.Text != "" && cmbtinhtrang.Text != "" && txtgiatien.Text != "" && txtsoluongsv.Text != "")
                {
                    kn.Open();
                    string sql = "insert into Phong values('" + txtmaphong.Text + "',N'" + cmbloaiphong.Text + "',N'" + txttenphong.Text + "',N'" + cmbhotennv.Text + "','" + cmbmanv.Text + "','" + txtsogiuong.Text + "',N'" + cmbtinhtrang.Text + "','" + txtgiatien.Text + "', '" + txtsoluongsv.Text + "')";
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

        //sua
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
            try
            {
                kn.Open();
                string sql = "update Phong set loaiphong=N'" + cmbloaiphong.Text + "',tenphong=N'" + txttenphong.Text + "',hotennv=N'" + cmbhotennv.Text + "',manv='" + cmbmanv.Text + "',sogiuong='" + txtsogiuong.Text + "',tinhtrang=N'" + cmbtinhtrang.Text + "',giatien='" + txtgiatien.Text + "',soluongsv='" + txtsoluongsv.Text + "' where maphong='" + txtmaphong.Text + "'";
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

        //xoa
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
                kn.Open();
                string sql = "delete Phong where maphong='" + txtmaphong.Text + "'";
                SqlCommand commandxoa = new SqlCommand(sql, kn);
                commandxoa.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                ketnoidulieu();
                kn.Close();
            }
        }


    }
}
