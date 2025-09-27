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
namespace Cinema_Management
{
    public partial class PhanDangNhap : Form
    {
        public PhanDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiaoDienSauKhiDaDangNhapHoacDangKyXong GiaoDien = new GiaoDienSauKhiDaDangNhapHoacDangKyXong();
            this.Hide(); // ẩn form hiện tại
            GiaoDien.Show();
            GiaoDien.FormClosed += (s, args) => this.Close(); // đóng form cũ khi form mới tắt





















































            // Danh cho phan SQL Server ben duoi





































        }
        private void ConnectToDatabase()
        {
            string connectionString = "Server=localhost;Database=mydatabase;UserId = myuser; Password = mypassword; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Kết nối thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PhanDangKy DangKy = new PhanDangKy();
            this.Hide();
            DangKy.Show();
            DangKy.FormClosed += (s, args) => this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void PhanDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
