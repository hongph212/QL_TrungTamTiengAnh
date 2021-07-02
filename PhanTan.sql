------------------------TẠO LINK SERVER KẾT NỐI CÁC CƠ SỞ ĐẾN MÁY CHỦ-----------------------------
EXEC sp_addlinkedserver
@server = N'MayChu',
@provider=N'SQLOLEDB',
@datasrc= N'DESKTOP-A12V4HU\NGOCHAI', -- Thay IP hoặc tên máy cho phù hợp
@srvproduct='SQLProduct'

EXEC sp_linkedservers

EXEC master.dbo.sp_addlinkedsrvlogin
@rmtsrvname=N'MayChu',
@useself=N'False',
@locallogin=NULL,
@rmtuser=N'sa', -- Thay tên đăng nhập và mật khẩu phù hợp
@rmtpassword='pass'

go
------------------------TẠO LINK SERVER KẾT NỐI MÁY CHỦ ĐẾN CÁC CƠ SỞ-----------------------------
EXEC sp_addlinkedserver
@server = N'CN1',
@provider=N'SQLOLEDB',
@datasrc= N'DESKTOP-A12V4HU\NGOCHAI1', -- Thay IP hoặc tên máy cho phù hợp
@srvproduct='SQLProduct'

EXEC sp_linkedservers

EXEC master.dbo.sp_addlinkedsrvlogin
@rmtsrvname=N'CN1',
@useself=N'False',
@locallogin=NULL,
@rmtuser=N'sa', -- Thay tên đăng nhập và mật khẩu phù hợp
@rmtpassword='pass'
GO
EXEC sp_addlinkedserver
@server = N'CN2',
@provider=N'SQLOLEDB',
@datasrc= N'DESKTOP-A12V4HU\NGOCHAI2', -- Thay IP hoặc tên máy cho phù hợp
@srvproduct='SQLProduct'

EXEC sp_linkedservers

EXEC master.dbo.sp_addlinkedsrvlogin
@rmtsrvname=N'CN2',
@useself=N'False',
@locallogin=NULL,
@rmtuser=N'sa', -- Thay tên đăng nhập và mật khẩu phù hợp
@rmtpassword='pass'
--------------------------------------TẠO VIEW PHÂN MẢNH------------------------------------------------
CREATE VIEW V_DS_PHANMANH
AS
SELECT TENCN = PUBS.DESCRIPTION, TENSERVER=subscriber_server
from dbo.sysmergepublications PUBS,dbo.sysmergesubscriptions SUBS
where PUBS.pubid = SUBS.pubid and PUBS.publisher<>SUBS.subscriber_server

-----------------------TẠO CÁC STORED PROCEDURES Ở CÁC MẢNH VÀ MÁY CHỦ--------------------------
Create Proc spInsertHocVien(@mahv varchar(10),@hoten nvarchar(50),@ngaysinh date,@gioitinh nvarchar(3),@dienthoai nvarchar(10),@diachi nvarchar(50),@malop varchar(10),@makv varchar(10))
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.HOCVIEN where MAHV=@mahv or DIENTHOAI=@dienthoai)
Begin
print N'Học viên đã tồn tại'
return
End
Insert Into HOCVIEN(MAHV,HOTEN,NGAYSINH,GIOITINH,DIENTHOAI,DIACHI,MALOP,MAKV) 
values(@mahv,@hoten,@ngaysinh,@gioitinh,@dienthoai,@diachi,@malop,@makv)
print N'Thêm thành công ' + @hoten
End
GO

Create Proc spUpdateHocVien(@mahv varchar(10),@hoten nvarchar(50),@ngaysinh date,@gioitinh nvarchar(3),@dienthoai nvarchar(10),@diachi nvarchar(50),@malop varchar(10))
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Not Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.HOCVIEN where MAHV=@mahv)
Begin
print N'Học viên không tồn tại'
return
End
update HOCVIEN 
set HOTEN = @hoten,NGAYSINH = @ngaysinh,GIOITINH = @gioitinh,DIENTHOAI=@dienthoai,DIACHI = @diachi,MALOP = @malop
where MAHV = @mahv
update MayChu.QL_TRUNGTAMTA.dbo.HOCVIEN 
set HOTEN = @hoten,NGAYSINH = @ngaysinh,GIOITINH = @gioitinh,DIENTHOAI=@dienthoai,DIACHI = @diachi,MALOP = @malop
where MAHV = @mahv
print N'Sửa thành công ' + @hoten
End
GO

Create Proc spDeleteHocVien(@mahv varchar(10))
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Not Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.HOCVIEN where MAHV=@mahv)
Begin
print N'Học viên không tồn tại'
return
End
delete HOCVIEN where MAHV = @mahv
delete MayChu.QL_TRUNGTAMTA.dbo.HOCVIEN where MAHV = @mahv
print N'Xoá thành công ' 
End
GO

-----------------------------------------------------------------------------------------------------------
Create Proc spInsertPhanCong(@mapc varchar(10),@magv varchar(10),@malop varchar(10),@khoahoc varchar(10),@madotthi varchar(10),@makv varchar(10))
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.PHANCONG where MAPC=@mapc)
Begin
print N'Mã đã tồn tại'
return
End
Insert Into PHANCONG(MAPC,MAGV,MALOP,KHOAHOC,MADOTTHI,MAKV) 
values(@mapc,@magv,@malop,@khoahoc,@madotthi,@makv)
print N'Thêm thành công ' + @mapc
End
GO

Create Proc spUpdatePhanCong(@mapc varchar(10),@magv varchar(10),@malop varchar(10),@khoahoc varchar(10),@madotthi varchar(10))
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Not Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.PHANCONG where MAPC=@mapc)
Begin
print N'Mã không tồn tại'
return
End
update PHANCONG 
set MAGV = @magv,MALOP = @malop,KHOAHOC = @khoahoc,MADOTTHI = @madotthi
where MAPC = @mapc
update MayChu.QL_TRUNGTAMTA.dbo.PHANCONG 
set MAGV = @magv,MALOP = @malop,KHOAHOC = @khoahoc,MADOTTHI = @madotthi
where MAPC = @mapc
print N'Sửa thành công ' + @mapc
End
GO

Create Proc spDeletePhanCong(@mapc varchar(10))
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Not Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.PHANCONG where MAPC=@mapc)
Begin
print N'Mã không tồn tại'
return
End
delete PHANCONG where MAPC = @mapc
delete MayChu.QL_TRUNGTAMTA.dbo.PHANCONG where MAPC = @mapc
print N'Xoá thành công ' 
End
GO

---------------------------------------------------------------------------------------------

Create Proc spInsertThiCu(@madotthi varchar(10),@malop varchar(10),@ngaythi date,@giothi time)
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.DOTTHI where MADOTTHI = @madotthi)
Begin
print N'Mã đã tồn tại'
return
End
Insert Into DOTTHI(MADOTTHI,MALOP,NGAYTHI,GIOTHI) 
values(@madotthi,@malop,@ngaythi,@giothi)
print N'Thêm thành công ' + @madotthi
End
GO

Create Proc spUpdateThiCu(@madotthi varchar(10),@malop varchar(10),@ngaythi date,@giothi time)
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Not Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.DOTTHI where MADOTTHI = @madotthi)
Begin
print N'Mã không tồn tại'
return
End
update DOTTHI 
set MALOP = @malop,NGAYTHI = @ngaythi,GIOTHI = @giothi
where MADOTTHI = @madotthi
update MayChu.QL_TRUNGTAMTA.dbo.DOTTHI 
set MALOP = @malop,NGAYTHI = @ngaythi,GIOTHI = @giothi
where MADOTTHI = @madotthi
print N'Sửa thành công ' + @madotthi
End
GO

Create Proc spDeleteThiCu(@madotthi varchar(10))
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Not Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.DOTTHI where MADOTTHI=@madotthi)
Begin
print N'Mã không tồn tại'
return
End
delete DOTTHI where MADOTTHI = @madotthi
delete MayChu.QL_TRUNGTAMTA.dbo.DOTTHI where MADOTTHI = @madotthi
print N'Xoá thành công ' 
End
GO

----------------------------------------------------------------------------------------------

Create Proc spInsertGV(@magv varchar(10),@tengv nvarchar(50),@dienthoai nvarchar(10))
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.GIAOVIEN where MAGV = @magv)
Begin
print N'Mã đã tồn tại'
return
End
Insert Into GIAOVIEN(MAGV,TENGV,DIENTHOAI) 
values(@magv,@tengv,@dienthoai)
print N'Thêm thành công ' + @magv
End
GO

Create Proc spUpdateGV(@magv varchar(10),@tengv nvarchar(50),@dienthoai nvarchar(10))
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Not Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.GIAOVIEN where MAGV = @magv)
Begin
print N'Mã không tồn tại'
return
End
update GIAOVIEN 
set TENGV = @tengv,DIENTHOAI = @dienthoai
where MAGV = @magv
update MayChu.QL_TRUNGTAMTA.dbo.GIAOVIEN 
set TENGV = @tengv,DIENTHOAI = @dienthoai
where MAGV = @magv
print N'Sửa thành công ' + @magv
End
GO

Create Proc spDeleteGV(@magv varchar(10))
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Not Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.GIAOVIEN where MAGV=@magv)
Begin
print N'Mã không tồn tại'
return
End
delete GIAOVIEN where MAGV=@magv
delete MayChu.QL_TRUNGTAMTA.dbo.GIAOVIEN where MAGV=@magv
print N'Xoá thành công ' 
End
GO

----------------------------------------------------------------------------------------------

Create Proc spInsertHS(@mahs varchar(10),@mahv varchar(10))
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.HOSOHOCVIEN where MAHOSO = @mahs or MAHV = @mahv)
Begin
print N'Mã đã tồn tại'
return
End
Insert Into HOSOHOCVIEN(MAHOSO,MAHV) 
values(@mahs,@mahv)
print N'Thêm thành công ' + @mahs
End
GO

Create Proc spUpdateHS(@mahs varchar(10),@mahv varchar(10))
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Not Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.HOSOHOCVIEN where MAHOSO = @mahs)
Begin
print N'Mã không tồn tại'
return
End
update HOSOHOCVIEN 
set MAHV = @mahv
where MAHOSO = @mahs
update MayChu.QL_TRUNGTAMTA.dbo.HOSOHOCVIEN 
set MAHV = @mahv
where MAHOSO = @mahs
print N'Sửa thành công ' + @mahs
End
GO

Create Proc spDeleteHS(@mahs varchar(10))
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Not Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.HOSOHOCVIEN where MAHOSO=@mahs)
Begin
print N'Mã không tồn tại'
return
End
delete HOSOHOCVIEN where MAHOSO = @mahs
delete MayChu.QL_TRUNGTAMTA.dbo.HOSOHOCVIEN where MAHOSO = @mahs
print N'Xoá thành công ' 
End
GO

----------------------------------------------------------------------------------------------
Create Proc spInsertDiem(@mahv varchar(10),@mapc varchar(10),@lan int,@diem float)
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.KIEMTRA where MAPC = @mapc and MAHV = @mahv and LAN = @lan)
Begin
print N'Mã đã tồn tại'
return
End
Insert Into KIEMTRA(MAHV,MAPC,LAN,DIEM) 
values(@mahv,@mapc,@lan,@diem)
print N'Thêm thành công ' + @mahv
End
GO

Create Proc spUpdateDiem(@mahv varchar(10),@mapc varchar(10),@lan int,@diem float)
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Not Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.KIEMTRA where MAPC = @mapc and MAHV = @mahv and LAN = @lan)
Begin
print N'Mã không tồn tại'
return
End
update KIEMTRA 
set DIEM = @diem
where MAPC = @mapc and MAHV = MAHV and LAN = @lan
update MayChu.QL_TRUNGTAMTA.dbo.KIEMTRA 
set DIEM = @diem
where MAPC = @mapc and MAHV = MAHV and LAN = @lan
print N'Sửa thành công ' + @mahv
End
GO

Create Proc spDeleteDiem(@mahv varchar(10),@mapc varchar(10),@lan int)
AS
Begin
-- Kiểm tra tính hợp lệ của dữ liệu nhập
if Not Exists (Select * from MayChu.QL_TRUNGTAMTA.dbo.KIEMTRA where MAPC = @mapc and MAHV = @mahv and LAN = @lan)
Begin
print N'Mã không tồn tại'
return
End
delete KIEMTRA where MAPC = @mapc and MAHV = @mahv and LAN = @lan
delete MayChu.QL_TRUNGTAMTA.dbo.KIEMTRA where MAPC = @mapc and MAHV = @mahv and LAN = @lan
print N'Xoá thành công ' 
End
GO

-------------------------------------TẠO TRIGGER Ở CÁC CƠ SỞ VÀ MÁY CHỦ---------------------------------------------
create trigger CapNhatDiemTB on KIEMTRA
FOR DELETE, INSERT, UPDATE
AS
BEGIN
UPDATE HOSOHOCVIEN
SET TBDIEM = (SELECT (SUM(DIEM)/COUNT(DIEM)) FROM KIEMTRA,HOCVIEN,PHANCONG,LOP
WHERE HOSOHOCVIEN.MAHV = HOCVIEN.MAHV AND KIEMTRA.MAHV = HOCVIEN.MAHV 
AND PHANCONG.MALOP = LOP.MALOP AND HOCVIEN.MALOP = LOP.MALOP
GROUP BY KIEMTRA.MAHV)
END
-----------------------------------------------------------------------------------------------------
CREATE TRIGGER CapNhatXepLoai on HOSOHOCVIEN
FOR UPDATE
AS
BEGIN
		UPDATE HOSOHOCVIEN
		SET XEPLOAI = 'A'
		FROM INSERTED
		WHERE HOSOHOCVIEN.MAHOSO = inserted.MAHOSO AND inserted.TBDIEM>=8.5
		UPDATE HOSOHOCVIEN
		SET XEPLOAI = 'B'
		FROM INSERTED
		WHERE HOSOHOCVIEN.MAHOSO = inserted.MAHOSO AND inserted.TBDIEM>=7.5 AND inserted.TBDIEM<8.5
		UPDATE HOSOHOCVIEN
		SET XEPLOAI = 'C'
		FROM INSERTED
		WHERE HOSOHOCVIEN.MAHOSO = inserted.MAHOSO AND inserted.TBDIEM>=6.5 AND inserted.TBDIEM<7.5
		UPDATE HOSOHOCVIEN
		SET XEPLOAI = 'D'
		FROM INSERTED
		WHERE HOSOHOCVIEN.MAHOSO = inserted.MAHOSO AND inserted.TBDIEM>=5 AND inserted.TBDIEM<6.5
END

---------------------------------------------------------------------------------------------------
select HOTEN,hs3.TBDIEM as DIEM from CN1.QL_TRUNGTAMTA.dbo.HOSOHOCVIEN hs1,CN2.QL_TRUNGTAMTA.dbo.HOSOHOCVIEN hs2,HOSOHOCVIEN hs3,HOCVIEN
where hs1.MAHOSO = hs3.MAHOSO and hs3.MAHV = HOCVIEN.MAHV or hs2.MAHOSO = hs3.MAHOSO and hs3.MAHV = HOCVIEN.MAHV 
group by HOTEN,hs3.TBDIEM
------------------------------------------------------------------------------------------------------
select TENKV,COUNT(MAHV) as soluong from KHUVUC,HOCVIEN where KHUVUC.MAKV = HOCVIEN.MAKV group by TENKV
-------------------------------------------------------------------------------------------------------
select TENKV,SUM(HOCPHI) as hocphi from KHUVUC,HOCVIEN,LOP where KHUVUC.MAKV = HOCVIEN.MAKV and HOCVIEN.MALOP = LOP.MALOP group by TENKV