using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            // Kiểm tra control null
            if (HoTen == null || TenDangNhap == null || SDT == null || Email == null || MatKhau == null || XacNhanMatKhau == null
                || Ngay == null || Thang == null || Nam == null)
            {
                MessageBox.Show("Một số control chưa được khởi tạo. Vui lòng kiểm tra lại tên trong Designer.");
                return;
            }

            // Lấy dữ liệu từ form
            string hoTen = HoTen.Text.Trim();
            string tenDangNhap = TenDangNhap.Text.Trim();
            string sdt = SDT.Text.Trim();
            string email = Email.Text.Trim();
            string matKhau = MatKhau.Text;
            string xacNhanMK = XacNhanMatKhau.Text;

            if (Ngay.SelectedItem == null || Thang.SelectedItem == null || Nam.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn ngày/tháng/năm sinh.");
                return;
            }

            int ngay = int.Parse(Ngay.SelectedItem.ToString());
            int thang = int.Parse(Thang.SelectedItem.ToString());
            int nam = int.Parse(Nam.SelectedItem.ToString());

            DateTime ngaySinh;
            try
            {
                ngaySinh = new DateTime(nam, thang, ngay);
            }
            catch
            {
                MessageBox.Show("Ngày tháng năm không hợp lệ!");
                return;
            }

            // Validate dữ liệu
            if (tenDangNhap == "" || hoTen == "" || sdt == "" || email == "" || matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!Regex.IsMatch(hoTen, @"^[a-zA-ZÀ-ỹ\s]+$"))
            {
                MessageBox.Show("Họ tên không hợp lệ (chỉ cho phép chữ).");
                return;
            }

            if (!Regex.IsMatch(sdt, @"^(0\d{9}|\+84\d{9})$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ.");
                return;
            }

            if (!Regex.IsMatch(matKhau, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{6,}$"))
            {
                MessageBox.Show("Mật khẩu phải >=6 ký tự, có chữ hoa, chữ thường, số và ký tự đặc biệt.");
                return;
            }

            if (matKhau != xacNhanMK)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp.");
                return;
            }


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
            PhanDangNhap DangNhap = new PhanDangNhap();
            this.Hide();
            DangNhap.Show();
            DangNhap.FormClosed += (s, args) => this.Close();
        }


    }
}
// day la pull test
