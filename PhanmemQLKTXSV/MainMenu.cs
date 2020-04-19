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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Dangnhap frmdangnhap = new Dangnhap();
            frmdangnhap.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanlySV fm = new QuanlySV();
            fm.ShowDialog();
        }

        private void quảnLýCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlynhanvien fm = new Quanlynhanvien();
            fm.ShowDialog();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlyphong fm = new Quanlyphong();
            fm.ShowDialog();
        }



        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thanhtoantien1 fm = new Thanhtoantien1();
            fm.ShowDialog();
        }

        private void đăngKýThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangkyphong fm = new Dangkyphong();
            fm.ShowDialog();
        }


        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap frmdangnhap = new Dangnhap();
            frmdangnhap.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmdangnhap = new Form1();
            frmdangnhap.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongtinphanmem fm = new Thongtinphanmem();
            fm.ShowDialog();
        }

        private void quảnLýThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlythietbi fm = new Quanlythietbi();
            fm.ShowDialog();
        }
    }
}
