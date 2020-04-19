using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanmemQLKTXSV
{
    public partial class Timsinhvien : Form
    {
        public Timsinhvien()
        {
            InitializeComponent();
        }
        //khai báo class kết nối
        clsConnect cls = new clsConnect();
        private void Timsinhvien_Load(object sender, EventArgs e)
        {
            dataGridViewSinhvien.DataSource = cls.LoadData();
        }


        DataTable dt;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txthoten.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                //bắt đầu tìm kiếm
                dt = new DataTable();
                dt = cls.Timkiem(txthoten.Text.Trim());
                if(dt.Rows.Count>0)
                {
                    dataGridViewSinhvien.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Bạn tìm : "+txthoten.Text+"Không có trong dữ liệu!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    Timsinhvien_Load(null,null);//k có dữ liệu thì sẽ load lại thông tin
                    txthoten.Text="";

                }
            }
        }

        private void dataGridViewSinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
