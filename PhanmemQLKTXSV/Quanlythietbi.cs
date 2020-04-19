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
    public partial class Quanlythietbi : Form
    {
        public Quanlythietbi()
        {
            InitializeComponent();
        }

        private void Quanlythietbi_Load(object sender, EventArgs e)
        {
            ketnoidulieu();

        }
        private void ketnoidulieu()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
                kn.Open();
                string sql = "select * from Thietbi";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dataGridViewthietbi.DataSource = table;
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

        int index;
        private void dataGridViewNhanVien_Click(object sender, EventArgs e)
        {
            index = dataGridViewthietbi.CurrentRow.Index;
            matb.Text = dataGridViewthietbi.Rows[index].Cells[0].Value.ToString();
            tentb.Text = dataGridViewthietbi.Rows[index].Cells[1].Value.ToString();
            soluong.Text = dataGridViewthietbi.Rows[index].Cells[2].Value.ToString();
            tinhtrang.Text = dataGridViewthietbi.Rows[index].Cells[3].Value.ToString();
            giatien.Text = dataGridViewthietbi.Rows[index].Cells[4].Value.ToString();
            maphong.Text = dataGridViewthietbi.Rows[index].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ketnoidulieu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
            try
            {
                if (matb.Text != "" && tentb.Text != "" && soluong.Text != "" && tinhtrang.Text != "" && giatien.Text != "" && maphong.Text != "")
                {
                    kn.Open();
                    string sql = "insert into Thietbi values('" + matb.Text + "',N'" + tentb.Text + "','" + soluong.Text + "',N'" + tinhtrang.Text + "','" + giatien.Text + "','" + maphong.Text + "')";
                    SqlCommand commandthem = new SqlCommand(sql, kn);
                    int kq = (int)commandthem.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công dữ liệu thiết bị");
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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=DELL-N3567E\SQLEXPRESS;Initial Catalog=QLKTKSV;Integrated Security=True");
            try
            {
                kn.Open();
                string sql = "update Thietbi set tentb=N'" + tentb.Text + "',soluong='" + soluong.Text + "',tinhtrang=N'" + tinhtrang.Text + "',giatien='" + giatien.Text + "',maphong='" + maphong.Text + "' where matb='" + matb.Text + "'  ";
                SqlCommand cmd = new SqlCommand(sql, kn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công dữ liệu thiết bị !");
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
                string sql = "delete Thietbi where matb='" + matb.Text + "'";
                SqlCommand commandxoa = new SqlCommand(sql, kn);
                commandxoa.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                ketnoidulieu();
                kn.Close();
            }
        }




    }
}
