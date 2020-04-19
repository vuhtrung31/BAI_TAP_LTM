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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool checkOject()
        {
            if (string.IsNullOrWhiteSpace(txtusename.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên người dùng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusename.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpass.Focus();
                return false;
            }
            return true;
        }


        private void btdangnhap_Click(object sender, EventArgs e)
        {
            if (checkOject())
            {
                if (txtusename.Text.Equals("admin") && txtpass.Text.Equals("admin"))
                {
                    this.Hide();
                }
                else
                {
                    lblmes.Visible = true;
                    lblmes.Text = "Bạn đã nhập sai tên người dùng hoặc mật khẩu";
                }
            }
        }
    }
}
