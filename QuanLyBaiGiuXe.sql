use master
go

-- drop database QuanLyBaiGiuXe

CREATE DATABASE QuanLyBaiGiuXe
GO
USE QuanLyBaiGiuXe
GO

CREATE TABLE KhachHang
(
	SODT VARCHAR(20) PRIMARY KEY,
	TENKH NVARCHAR(50),
	PASS VARCHAR(50) NOT NULL,
	DIEMTICHLUY INT DEFAULT 0,
	DELETED INT DEFAULT 0
)



insert into KhachHang(SODT, TENKH, PASS) values('111111111', N'Nguyễn Tấn Thành', '123')
insert into KhachHang(SODT, TENKH, PASS) values('0981237123', N'Nguyễn Tuấn Kiệt', '123')
insert into KhachHang(SODT, TENKH, PASS) values('0987321632', N'Ngô Tấn Thành', '123')
insert into KhachHang(SODT, TENKH, PASS) values('0907650699', N'Trần Tấn Thành', '123')

go



CREATE TABLE NhanVien
(
	SODT VARCHAR(20) PRIMARY KEY,	-- SODT NV sẽ có thêm dấu . phía trước để phân biệt với KH
	TENNV NVARCHAR(50),
	DIACHI NVARCHAR(100),
	PASS VARCHAR(50) NOT NULL,
	LOAINV INT DEFAULT 0,	-- 1 ADMIN
	DELETED INT DEFAULT 0
)

go
insert into NhanVien(SODT,TENNV,DIACHI,PASS) values('''222222222', N'Trần Tấn Thành',N'43, Cầu giấy, Hà Nội', '123')
insert into NhanVien(SODT,TENNV,DIACHI,PASS, LOAINV) values('''333333333', N'Trần Tấn Thành ADMIN',N'53, Cầu giấy, Hà Nội', '123', 1)

CREATE TABLE LoaiXe
(
	MALOAI INT PRIMARY KEY IDENTITY(1, 1),
	TENLOAI NVARCHAR(30),
	PHIGIU FLOAT,
	DELETED INT DEFAULT 0
)

insert into LoaiXe(TENLOAI,PhiGiu) values(N'Xe tải', 100000)
insert into LoaiXe(TENLOAI,PhiGiu) values(N'Xe container', 200000)
insert into LoaiXe(TENLOAI,PhiGiu) values(N'Xe hơi 4 chỗ', 150000)
insert into LoaiXe(TENLOAI,PhiGiu) values(N'Xe hơi 7 chỗ', 170000)
insert into LoaiXe(TENLOAI,PhiGiu) values(N'Xe giường nằm', 110000)
insert into LoaiXe(TENLOAI,PhiGiu) values(N'Xe bus', 190000)
insert into LoaiXe(TENLOAI,PhiGiu) values(N'Xe bán tải', 180000)
insert into LoaiXe(TENLOAI,PhiGiu) values(N'Xe điện', 160000)

CREATE TABLE Xe
(	
	BIENSO VARCHAR(20) PRIMARY KEY,
	MALOAI INT FOREIGN KEY REFERENCES LoaiXe(MALOAI),
	SODT VARCHAR(20) FOREIGN KEY REFERENCES KhachHang(SODT),
	DELETED INT DEFAULT 0
)

CREATE TABLE BaiGiu
(
	MABAI INT PRIMARY KEY IDENTITY(1, 1),
	TENBAI NVARCHAR(50),
	SUCCHUA INT,
	DELETED INT DEFAULT 0
)

insert into BaiGiu(TENBAI,SUCCHUA) values(N'Bãi 1', 50)
insert into BaiGiu(TENBAI,SUCCHUA) values(N'Bãi 2', 100)
insert into BaiGiu(TENBAI,SUCCHUA) values(N'Bãi 3', 60)
insert into BaiGiu(TENBAI,SUCCHUA) values(N'Bãi 4', 40)

CREATE TABLE ViTri
(
	ID_VITRI INT PRIMARY KEY IDENTITY(1, 1),
	SOVITRI INT,
	MABAIXE INT FOREIGN KEY REFERENCES BaiGiu(MABAI),
	TINHTRANG INT CHECK(TINHTRANG = 1 OR TINHTRANG = 0 OR TINHTRANG = 2),
)
-- insert bãi 1
DECLARE @i INT = 1;
WHILE @i <= 10
BEGIN
  INSERT INTO ViTri(SOVITRI, MABAIXE, TINHTRANG)
  VALUES (@i, 1, 0);
  SET @i = @i + 1
END
go
-- insert bãi 2
DECLARE @i INT = 1;
WHILE @i <= 10
BEGIN
  INSERT INTO ViTri(SOVITRI, MABAIXE, TINHTRANG)
  VALUES (@i, 2, 0);
  SET @i = @i + 1
END
go
-- insert bãi 3
DECLARE @i INT = 1;
WHILE @i <= 10
BEGIN
  INSERT INTO ViTri(SOVITRI, MABAIXE, TINHTRANG)
  VALUES (@i, 3, 0);
  SET @i = @i + 1
END
go
-- insert bãi 4
DECLARE @i INT = 1;
WHILE @i <= 10
BEGIN
  INSERT INTO ViTri(SOVITRI, MABAIXE, TINHTRANG)
  VALUES (@i, 4, 0);
  SET @i = @i + 1
END
go

CREATE TABLE The
(
	SOTHE INT PRIMARY KEY IDENTITY(1, 1),
	TENTHE NVARCHAR(10),
	ID_VITRI INT REFERENCES ViTri(ID_VITRI),
	BIENSOXE VARCHAR(20) FOREIGN KEY REFERENCES Xe(BIENSO),
	GIOVAO DATE,
	GIORA DATE DEFAULT NULL
)
go
CREATE TABLE HoaDon
(
	MAHD VARCHAR(20) primary key,
	SODTKH VARCHAR(20) REFERENCES KhachHang(SODT),
	NVTHU VARCHAR(20) REFERENCES NhanVien(SODT),
	MALOAIXE INT REFERENCES LoaiXe(MALOAI),
	NGAYLAP DATE DEFAULT GETDATE(),
	ID_VITRI INT REFERENCES Vitri(ID_VITRI),
	TONGTIEN FLOAT
)


select * from vitri

GO
------------------PROC AND FUNCTION-------------------
------------------------------------------------------
go

-- exec USP_login_to_system @phone = '111111111', @pass = '123'
go
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
	set @date_string = RIGHT(@date_string, 8)
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


go


create table datchoonline(
		madon INT PRIMARY KEY IDENTITY(1, 1),
		sdtkhachhang  VARCHAR(20) FOREIGN KEY REFERENCES KhachHang(SODT),
		ID_VITRI int FOREIGN KEY REFERENCES ViTri(ID_VITRI),
		mabai int FOREIGN KEY REFERENCES BaiGiu(MABAI),
		ngaydat date,
		loaixe int FOREIGN KEY REFERENCES LoaiXe(MALOAI),
		giodat varchar(10),
		tinhtrang int DEFAULT 0 -- 0 đã đặt, 1 -- đã rời, -1 hủy
)

GO

create function getAllXe(@mabai INT)
RETURNS TABLE
AS
	RETURN (SELECT * FROM VITRI WHERE MABAIXE = @mabai)

GO

SELECT * FROM dbo.getAllXe(1)

GO

create proc insert_datChoOnline 
@sdtkhachhang  VARCHAR(20), @mavitri int, @mabai int, @ngaydat date,@loaixe int, @giodat varchar(10)
as
begin
	insert into datchoonline(sdtkhachhang, ID_VITRI, mabai, ngaydat, loaixe, giodat, tinhtrang) 
	values(@sdtkhachhang  , @mavitri , @mabai, @ngaydat,@loaixe, @giodat,0)
end

GO

CREATE FUNCTION getAllDon(@mabai INT)
RETURNS TABLE
AS
	RETURN (SELECT dc.*, vt.SOVITRI, lx.TENLOAI FROM DATCHOONLINE dc JOIN ViTri vt ON dc.ID_VITRI=vt.ID_VITRI JOIN LoaiXe lx ON dc.loaixe = lx.MALOAI WHERE MABAIXE = @mabai AND dc.tinhtrang=0)

GO
SELECT madon, sdtkhachhang, sovitri, ngaydat, tenloai, giodat FROM dbo.getAllDon(1)

GO

CREATE PROC updateViTri @id_vitri INT
AS
	UPDATE ViTri SET TINHTRANG = 1 WHERE ID_VITRI = @id_vitri

exec insert_datChoOnline '0907650699', 1, 1, '2023-03-27', 2, '7:30'
exec insert_datChoOnline '0981237123', 2, 1, '2023-03-28', 1, '8:30'
exec insert_datChoOnline '0987321632', 3, 1, '2023-03-29', 3, '9:30'
exec insert_datChoOnline '0987321632', 10, 1, '2023-03-30', 3, '9:30'
update vitri set tinhtrang = 1 where ID_VITRI=10
select * from ViTri