
CREATE DATABASE QuanLyBaiGiuXe
GO
USE QuanLyBaiGiuXe
GO

CREATE TABLE KhachHang
(
	SODT VARCHAR(20) PRIMARY KEY,
	TENKH NVARCHAR(50),
	PASS VARCHAR(50) NOT NULL,
	DIEMTICHLUY INT DEFAULT 0
)

CREATE TABLE NhanVien
(
	SODT VARCHAR(20) PRIMARY KEY,	-- SODT NV sẽ có thêm dấu ' phía trước để phân biệt với KH
	TENNV NVARCHAR(50),
	DIACHI NVARCHAR(100),
	PASS VARCHAR(50) NOT NULL,
	LOAINV INT DEFAULT 0	-- 1 ADMIN
)

CREATE TABLE LoaiXe
(
	MALOAI INT PRIMARY KEY IDENTITY(1, 1),
	TENLOAI NVARCHAR(30),
	PHIGIU FLOAT
)

CREATE TABLE Xe
(	
	BIENSO VARCHAR(20) PRIMARY KEY,
	MALOAI INT FOREIGN KEY REFERENCES LoaiXe(MALOAI),
	SODT VARCHAR(20) FOREIGN KEY REFERENCES KhachHang(SODT)
)

CREATE TABLE BaiGiu
(
	MABAI INT PRIMARY KEY IDENTITY(1, 1),
	TENBAI NVARCHAR(50),
	DIACHI NVARCHAR(200),
	SUCCHUA INT,
)

CREATE TABLE ViTri
(
	SOVITRI INT PRIMARY KEY IDENTITY(1, 1),
	VITRIBAIXE INT FOREIGN KEY REFERENCES BaiGiu(MABAI),
	TINHTRANG INT CHECK(TINHTRANG = 1 OR TINHTRANG = 0),
	BIENSOXEDO VARCHAR(20) FOREIGN KEY REFERENCES Xe(BIENSO)
)
CREATE TABLE The
(
	SOTHE INT PRIMARY KEY IDENTITY(1, 1),
	SOVITRI INT REFERENCES ViTri(SOVITRI),
	BIENSOXE VARCHAR(20) FOREIGN KEY REFERENCES Xe(BIENSO),
	GIOVAO DATE,
	GIORA DATE DEFAULT NULL
)

CREATE TABLE HoaDon
(
	SOHD INT PRIMARY KEY IDENTITY(1, 1),
	SODTKH VARCHAR(20) REFERENCES KhachHang(SODT),
	NVTHU VARCHAR(20) REFERENCES NhanVien(SODT),
	NGAYLAP DATE DEFAULT GETDATE(),
	TONGTIEN FLOAT
)


GO
------------------PROC AND FUNCTION-------------------
------------------------------------------------------

-- Login
CREATE PROC USP_login_to_system @phone VARCHAR(20), @pass VARCHAR(50)
AS
BEGIN
	IF (LEFT(@phone, 1) = '''')
	BEGIN
		SELECT * FROM NhanVien WHERE SODT = @phone AND PASS = @pass
	END

	ELSE
	BEGIN
		SELECT * FROM KhachHang WHERE SODT = @phone AND PASS = @pass
	END
END

GO

create function func_taoMaHoaDon()
returns varchar(10)
as
begin
	declare @date date, @date_string varchar(10), @mahd varchar(10), @num int, @ma varchar(10)
	set @date = GETDATE()
	set @date_string = CONVERT(varchar(10),@date,111)
	set @date_string = RIGHT(@date_string, 😎
	set @date_string = REPLACE(@date_string,'/','')
	set @ma = 'X' + @date_string
	if EXISTS((select top 1 MAHD from HoaDon where LEFT(MAHD,7) = @ma order by MAHD desc))
	begin
		set @mahd = (select top 1 MAHD from HoaDon where LEFT(MAHD,7) = @ma order by MAHD desc)
		set @num = CAST(RIGHT(@mahd,3) as int) + 1
		if (@num < 10)
			set @ma = @ma + '00' + CAST(@num as varchar)
		else
		begin
			if (@num < 100)
				set @ma = @ma + '0' + CAST(@num as varchar)
			else
				set @ma = @ma + CAST(@num as varchar)
		end
	end
	else
		set @ma = @ma + '001'
	return @ma
end