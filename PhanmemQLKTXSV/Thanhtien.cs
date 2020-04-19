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
    public partial class Thanhtien : Form
    {
        public Thanhtien()
        {
            InitializeComponent();
        }



        public ComboBox message { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        public string tongtientt;
        public void load()
        {
            if (tongtientt != "")
                Tienthanhtoan.Text = tongtientt;
        }

        private void Thanhtien_Load(object sender, EventArgs e)
        {
            Tenkhachhang.Text = _message;
            string s = Tenkhachhang.Text.Trim();
            while (s.IndexOf("  ") >= 0)
                s = s.Replace("   ", "  ");
            Tenkhachhang.Text = s.ToString();

            load();
        }

    }
}
