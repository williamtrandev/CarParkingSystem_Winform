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

go

insert into KhachHang(SODT, TENKH, PASS) values('111111111', N'Nguyễn Tấn Thành', '123')
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
insert into LoaiXe(TENLOAI,PhiGiu) values(N'Xe hơi 4 chỗ', 150000)
insert into LoaiXe(TENLOAI,PhiGiu) values(N'Xe hơi 7 chỗ', 170000)
insert into LoaiXe(TENLOAI,PhiGiu) values(N'Xe bán tải', 180000)



CREATE TABLE BaiGiu
(
	MABAI INT PRIMARY KEY IDENTITY(1, 1),
	TENBAI NVARCHAR(50),
	SUCCHUA INT,
	DELETED INT DEFAULT 0
)



CREATE TABLE ViTri
(
	ID_VITRI INT PRIMARY KEY IDENTITY(1, 1),
	SOVITRI INT,
	MABAIXE INT FOREIGN KEY REFERENCES BaiGiu(MABAI),
	TINHTRANG INT CHECK(TINHTRANG = 1 OR TINHTRANG = 0 OR TINHTRANG = 2), -- 0 là trống, 1 là có xe, 2 là đặt trước
)

alter table vitri drop constraint CK__ViTri__TINHTRANG__32E0915F


CREATE TABLE The
(
	SOTHE INT PRIMARY KEY IDENTITY(1, 1),
	TENTHE NVARCHAR(10),
	ID_VITRI INT FOREIGN KEY REFERENCES ViTri(ID_VITRI),
	BIENSOXE VARCHAR(20),
	TRANGTHAI INT DEFAULT 0, --- 1 là đang dùng, 0 là chưa
	GIOVAO DATETIME DEFAULT NULL,
	SDTKH VARCHAR(20) FOREIGN KEY REFERENCES KhachHang(SODT) DEFAULT NULL,
	MALOAIXE INT FOREIGN KEY REFERENCES LoaiXe(MALOAI) DEFAULT NULL
)

go

CREATE TABLE HoaDon
(
	MAHD VARCHAR(20) primary key,
	SODTKH VARCHAR(20) FOREIGN KEY REFERENCES KhachHang(SODT) DEFAULT NULL,
	NVTHU VARCHAR(20) FOREIGN KEY REFERENCES NhanVien(SODT),
	MALOAIXE INT FOREIGN KEY REFERENCES LoaiXe(MALOAI),
	GIOVAO DATETIME,
	GIORA DATETIME DEFAULT GETDATE(),
	ID_VITRI INT FOREIGN KEY REFERENCES Vitri(ID_VITRI),
	TONGTIEN FLOAT
)

alter table HoaDon alter column tongtien int

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


go




go
create proc lichsudatchokh @sdtkh varchar(20)
as
begin
select HoaDon.MAHD ,NhanVien.TENNV,LoaiXe.TENLOAI, BaiGiu.TENBAI,ViTri.SOVITRI,HoaDon.GIORA, HoaDon.TONGTIEN  from HoaDon join NhanVien 
on HoaDon.NVTHU = NhanVien.SODT
join LoaiXe
on HoaDon.MALOAIXE = LoaiXe.MALOAI
join ViTri
on ViTri.ID_VITRI = HoaDon.ID_VITRI
join BaiGiu on BaiGiu.MABAI = ViTri.MABAIXE

where HoaDon.SODTKH =  @sdtkh
end

GO


go


CREATE PROCEDURE insertHoaDon @sdtkh VARCHAR(20), @nvthu VARCHAR(20), @maloaixe INT, @id_vitri INT, @giovao DATETIME, @giora DATETIME
AS
BEGIN
	DECLARE @phigiu FLOAT
	SELECT @phigiu = PHIGIU FROM LOAIXE WHERE MALOAI=@maloaixe
	
	DECLARE @duration INT
	SELECT @duration = DATEDIFF(SECOND, @giovao, @giora)
	
	DECLARE @tongtien FLOAT
	SELECT @tongtien = @phigiu * (@duration / 3600)
	
	IF @duration >= 8 * 3600 AND @duration < 16 * 3600
		SET @tongtien = @tongtien * 1.1
	ELSE IF @duration >= 16 * 3600 AND @duration < 24 * 3600
		SET @tongtien = @tongtien * 1.3
	ELSE IF @duration >= 24 * 3600
		SET @tongtien = @tongtien * 1.5
	IF @sdtkh IS NULL OR @sdtkh = ''
		SET @sdtkh = 'xxx'
	INSERT INTO HoaDon (MAHD, SODTKH, NVTHU, MALOAIXE, ID_VITRI, TONGTIEN) 
	VALUES(dbo.func_taoMaHoaDon(), @sdtkh, @nvthu, @maloaixe, @id_vitri, @tongtien)
END

go

/*
CREATE TRIGGER trg_BaiGiu_Insert_Update ON BaiGiu
AFTER INSERT, UPDATE
AS
BEGIN
    -- Insert 
    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        DECLARE @MABAI INT
        DECLARE @SUCCHUA INT
        
        SELECT @MABAI = MABAI, @SUCCHUA = SUCCHUA
        FROM inserted
        
        -- Insert new records into ViTri
        DECLARE @SOVITRI INT = 1
		DECLARE @ID_VITRI INT
		SELECT @ID_VITRI =  ID_VITRI FROM ViTri WHERE MABAIXE = @MABAI AND SOVITRI = @SOVITRI

        WHILE @SOVITRI <= @SUCCHUA
        BEGIN

			DECLARE @Ten NVARCHAR(20) = N'Thẻ ' + CAST(@SOVITRI AS NVARCHAR(10))
            INSERT INTO The (TENTHE, ID_VITRI, BIENSOXE, TRANGTHAI, GIOVAO, SDTKH)
            VALUES (@Ten, @ID_VITRI, '', 0, NULL, NULL)
            
            INSERT INTO ViTri (SOVITRI, MABAIXE, TINHTRANG)
            VALUES (@SOVITRI, @MABAI, 0)
            
			update the set ID_VITRI = @ID_VITRI
            
            
            
            SET @SOVITRI = @SOVITRI + 1
        END
    END
    
    -- Update 
    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        DECLARE @SUCCHUACU INT
        SELECT @SUCCHUACU = SUCCHUA
        FROM deleted
        
		DECLARE @SUCCHUAMOI INT
		SELECT @SUCCHUAMOI = SUCCHUA FROM inserted
		
        IF (@SUCCHUACU < @SUCCHUAMOI)
		BEGIN
			DECLARE @i INT = @SUCCHUACU + 1;
			WHILE (@i <= @SUCCHUAMOI)
			BEGIN

				INSERT INTO ViTri (SOVITRI, MABAIXE, TINHTRANG) VALUES (@i, @MABAI, 0);
				DECLARE @TenMoi NVARCHAR(20) = N'Thẻ ' + CAST(@SOVITRI AS NVARCHAR(10))
				INSERT INTO The (TENTHE, ID_VITRI, BIENSOXE, TRANGTHAI) VALUES (@TenMoi, SCOPE_IDENTITY(), NULL, 0);
				SET @i = @i + 1;
			END
		END
		ELSE IF (@SUCCHUACU > @SUCCHUAMOI)
		BEGIN
			DECLARE @num_delete INT = @SUCCHUACU - @SUCCHUAMOI;
			DELETE FROM The WHERE ID_VITRI IN (SELECT TOP (@num_delete) ID_VITRI FROM ViTri WHERE MABAIXE = @MABAI ORDER BY ID_VITRI DESC);
			DELETE FROM ViTri WHERE MABAIXE = @MABAI AND ID_VITRI NOT IN (SELECT TOP (@SUCCHUAMOI) ID_VITRI FROM ViTri WHERE MABAIXE = @MABAI ORDER BY ID_VITRI);
		END
	END
END
go*/

create trigger insert_vitri_of_baigiu on baigiu after insert 
as
begin
	Declare @sovitri int
	declare @mabai int
	select @sovitri = succhua, @mabai = mabai from inserted 
	Declare @count int = 1;

	while @count <= @sovitri
	begin
		INSERT INTO ViTri (SOVITRI, MABAIXE, TINHTRANG)
            VALUES (@count, @mabai, 0)
		set @count = @count + 1
	end 
end

go

create trigger insert_the_for_vitri on vitri after insert
as
begin
	declare @id_vitri int
	select @id_vitri = id_vitri from inserted

	DECLARE @Ten NVARCHAR(20) = N'Thẻ ' + CAST(@id_vitri AS NVARCHAR(10))
            INSERT INTO The (TENTHE, ID_VITRI, BIENSOXE, TRANGTHAI, GIOVAO, SDTKH)
            VALUES (@Ten, -1, '', 0, NULL, NULL)

end
go

create proc getAllHoaDon @start date, @end date
as	
begin

	select HoaDon.MAHD ,NhanVien.TENNV,LoaiXe.TENLOAI, BaiGiu.TENBAI,ViTri.SOVITRI,HoaDon.GIORA, HoaDon.TONGTIEN  from HoaDon join NhanVien 
	on HoaDon.NVTHU = NhanVien.SODT
	join LoaiXe
	on HoaDon.MALOAIXE = LoaiXe.MALOAI
	join ViTri
	on ViTri.ID_VITRI = HoaDon.ID_VITRI
	join BaiGiu on BaiGiu.MABAI = ViTri.MABAIXE
	where HoaDon.GIORA BETWEEN @start AND @end
end

go



create proc showdatchoonline_proc @sdtkh varchar(20)
as
begin
select datchoonline.madon,vitri.SOVITRI, BaiGiu.TENBAI, datchoonline.ngaydat, LoaiXe.TENLOAI, datchoonline.giodat, datchoonline.tinhtrang  from datchoonline join vitri
on datchoonline.ID_VITRI = vitri.ID_VITRI
join BaiGiu on BaiGiu.MABAI = datchoonline.mabai
join LoaiXe on LoaiXe.MALOAI = datchoonline.loaixe
where datchoonline.sdtkhachhang = @sdtkh and datchoonline.tinhtrang != 2 -- 2 là đã vào HD  { { -1, "bị hủy" }, { 0, "chờ xử lý" }, { 1, "đặt thành công" } };
end

go
create proc updatekh  @sdt varchar(20) , @tenkh nvarchar(20) , @pass varchar(20)
as 
begin
	update KhachHang set TENKH = @tenkh where SODT = @sdt
	update KhachHang set PASS = @pass where SODT = @sdt
end

go
create trigger update_vitri_of_bai on baigiu after update 
as 
begin
	declare @mabai int
	declare @succhua_cu int
	declare @succhua_moi int

	select @mabai = mabai,  @succhua_cu = succhua from deleted
	select @succhua_moi = succhua from inserted

	if @succhua_cu < @succhua_moi
	begin
		while @succhua_cu < @succhua_moi
		begin
			INSERT INTO ViTri (SOVITRI, MABAIXE, TINHTRANG)
            VALUES (@succhua_cu+1, @mabai, 0)
			set @succhua_cu = @succhua_cu + 1
		end
	end
	else
	begin

		update vitri set TINHTRANG = 3 where ID_VITRI IN(select top (@succhua_cu-@succhua_moi) ID_VITRI  from ViTri
		order by ID_VITRI desc )	
		update the set TRANGTHAI = 3 where ID_VITRI IN(select top (@succhua_cu-@succhua_moi) ID_VITRI  from ViTri
		order by ID_VITRI desc )
	end

	
end

go

select * from BaiGiu
select * from vitri
select * from the


update BaiGiu set SUCCHUA = 50

insert into BaiGiu(TENBAI,SUCCHUA) values(N'Bãi 1', 50)
insert into BaiGiu(TENBAI,SUCCHUA) values(N'Bãi 2', 100)
insert into BaiGiu(TENBAI,SUCCHUA) values(N'Bãi 3', 60)
insert into BaiGiu(TENBAI,SUCCHUA) values(N'Bãi 4', 40)


update the set ID_VITRI =null , BIENSOXE = '', TRANGTHAI = 0 , GIOVAO = NULL, SDTKH = null where SOTHE = 1
update vitri set TINHTRANG= 0 where ID_VITRI = 1
select * from the
select * from ViTri
update The set ID_VITRI=null, BIENSOXE=null, TRANGTHAI=0, GIOVAO=null, maloaixe =null
select * from hoadon
select * from LoaiXe
select * from KhachHang

insert into KhachHang values('xxx', 'xxx', 0, 0, 0)
select * from KhachHang

go
create trigger update_point on HoaDon AFTER INSERT
as
begin
	DECLARE @sdtkh VARCHAR(20)
	SELECT @sdtkh = SODTKH FROM inserted 
	if(select DIEMTICHLUY FROM KhachHang WHERE SODT = @sdtkh) > 5
	BEGIN
		UPDATE HoaDon SET TONGTIEN = TONGTIEN-10000
	END
	update KhachHang set DIEMTICHLUY = DIEMTICHLUY + 1 WHERE sodt =@sdtkh
	
end

select * from datchoonline

select * from ViTri

delete from datchoonline where madon = @madon

select * from the
update vitri set TINHTRANG = 0
update the set ID_VITRI = null, BIENSOXE = null, TRANGTHAI = 0, GIOVAO =null, maloaixe = null 


select * from NhanVien

update HoaDon set TONGTIEN = 10000