CREATE TABLE USERS

USE USERS


CREATE TABLE UserClient
(
-- NOT NULL la ko de trong dc , NULL la de trong dc 
-- Khoa chinh: MaKhachHang (UserID) , no tu tang r ko can lam gi nhieu dau
UserID INT PRIMARY KEY IDENTITY(1,1),

-- Ten Dang Nhap
Username NVARCHAR(50) NOT NULL UNIQUE,

-- Ho Ten
HoTen NVARCHAR(100) NOT NULL,

-- Ngay Thang Nam sinh
NgaySinh DATE NULL,

-- So Dien Thoai
SDT VARCHAR (11) NOT NULL,

-- Email
Email NVARCHAR(100) NOT NULL,

-- Khu Vuc
KhuVuc NVARCHAR(100) NOT NULL,

-- Mat Khau ko luu vao Database ma luu vao ma Hash cua no
MaHashCuaMatKhau VARCHAR(255), 

-- Tu dong tao ngay tao tai khoan, ko can quan tam
NgayTaoTaiKhoan DATETIME DEFAULT GETDATE()


);
