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
    public partial class Thanhtoantien1 : Form
    {
        public Thanhtoantien1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
                Application.Exit();
        }
        int tien1, tien2, tien3, tien4, tien5 ;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (tienphong.Checked == true)
                tien1 = 3700000;
            else
                tien1 = 0;

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (guixe.Checked == true)
                tien5 = 50000;
            else
                tien5 = 0;
        }

        private void tiendien_CheckedChanged(object sender, EventArgs e)
        {
            if (tiendien.Checked == true)
                tien2 = 150000;
            else
                tien2 = 0;
        }

        private void tiennuoc_CheckedChanged(object sender, EventArgs e)
        {
            if (tiennuoc.Checked == true)
                tien3 = 150000;
            else
                tien3 = 0;
        }

        private void dichvu_CheckedChanged(object sender, EventArgs e)
        {
            if (dichvu.Checked == true)
                tien4 = 20000;
            else
                tien4 = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thanhtien tt = new Thanhtien();
            tt.Message = khungnhapsinhvien.Text;
            Tongtien.Text = Convert.ToString(tien1 + tien2 + tien3 + tien4 + tien5);
            
            string tongtientt;
            tongtientt = Tongtien.Text;
            tt.tongtientt = tongtientt;
            tt.Show();


        }

        private void label4_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Timsinhvien fm = new Timsinhvien();
            fm.ShowDialog();
        }

        private void Thanhtoantien1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Sinhvien' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.Fill(this.dataSet1.Sinhvien);

        }

    }
}
