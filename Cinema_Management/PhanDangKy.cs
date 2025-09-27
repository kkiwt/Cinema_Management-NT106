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
            GiaoDienSauKhiDaDangNhapHoacDangKyXong GiaoDien = new GiaoDienSauKhiDaDangNhapHoacDangKyXong();
            this.Hide(); // ẩn form hiện tại
            GiaoDien.Show();
            GiaoDien.FormClosed += (s, args) => this.Close(); // đóng form cũ khi form mới tắt

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
            this.Hide();
            DangNhap.Show();
            DangNhap.FormClosed += (s, args) => this.Close();
        }
    }
}
// day la pull test
