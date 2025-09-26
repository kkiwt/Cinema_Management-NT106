using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Management
{
    public partial class PhanDangKy : Form
    {
        public PhanDangKy()
        {
            InitializeComponent();
        }

        private void NutDangKy_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PhanDangNhap DangNhap = new PhanDangNhap();
            DangNhap.ShowDialog();
        }
    }
}
