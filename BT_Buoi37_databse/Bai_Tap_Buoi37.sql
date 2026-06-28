USE db_qlnv_dotnet06;
GO

-- ==========================================
-- BÀI TẬP INNER JOIN
-- Cơ sở dữ liệu: db_qlnv_dotnet06
-- ==========================================


-- ==========================================
-- BÀI 1 — INNER JOIN từ 2 bảng
-- ==========================================

-- Câu 1.1
-- Hiển thị danh sách nhân viên kèm tên phòng ban của họ.
-- Kết quả gồm: TenNV, SoDienThoai, TenPB.
-- Sắp xếp theo tên phòng ban.

SELECT 
    nv.TenNV,
    nv.SoDienThoai,
    pb.TenPB
FROM NhanVien nv
INNER JOIN PhongBan pb
    ON nv.MaPB = pb.Id
ORDER BY pb.TenPB;


-- Câu 1.2
-- Liệt kê tất cả dự án cùng địa điểm thực hiện.
-- Kết quả gồm: TenDuAn, NgayBatDau, NgayKetThuc, TenDiaDiem, DiaChi.

SELECT 
    da.TenDuAn,
    da.NgayBatDau,
    da.NgayKetThuc,
    dd.TenDiaDiem,
    dd.DiaChi
FROM DuAn da
INNER JOIN DiaDiem dd
ON da.MaDiaDiem = dd.Id;


-- Câu 1.3
-- Cho biết mỗi nhân viên đã tham gia những dự án nào.
-- Kết quả gồm: TenDuAn, MaNhanVien, NgayThamGia.
-- Nối DuAn với NhanVien_Duan.

SELECT da.TenDuAn,
         nvd.MaNhanVien,
         nvd.NgayThamGia
FROM DuAn da
INNER JOIN NhanVien_Duan nvd
ON da.Id = nvd.MaDuAn;

-- ==========================================
-- BÀI 2 — INNER JOIN từ 3 bảng
-- ==========================================

-- Câu 2.1
-- Hiển thị danh sách nhân viên gồm:
-- TenNV, TenPB và tên trưởng phòng TenTruongPhong.
-- Nối NhanVien với PhongBan,
-- và tự nối NhanVien với chính nó qua MaTruongPhong.

SELECT 
    nv.TenNV,
    pb.TenPB,
    tp.TenNV AS TenTruongPhong
FROM NhanVien nv
INNER JOIN PhongBan pb
    ON nv.MaPB = pb.Id
INNER JOIN NhanVien tp
    ON nv.MaTruongPhong = tp.Id;


-- Câu 2.2
-- Liệt kê chi tiết phân công công việc:
-- với mỗi dòng cho biết tên nhân viên, tên dự án và ngày tham gia.
-- Kết quả gồm: TenNV, TenDuAn, NgayThamGia.
-- Sắp xếp theo TenNV.

SELECT 
    nv.TenNV,
    da.TenDuAn,
    nvd.NgayThamGia
FROM NhanVien nv
INNER JOIN NhanVien_Duan nvd
    ON nv.Id = nvd.MaNhanVien
INNER JOIN DuAn da
    ON nvd.MaDuAn = da.Id
ORDER BY nv.TenNV;


-- Câu 2.3
-- Cho biết mỗi dự án được thực hiện ở địa điểm nào
-- và có những nhân viên mã nào tham gia.
-- Kết quả gồm: TenDuAn, TenDiaDiem, MaNhanVien, NgayThamGia.
-- Nối DuAn, DiaDiem, NhanVien_Duan.

SELECT 
    da.TenDuAn,
    dd.TenDiaDiem,
    nvd.MaNhanVien,
    nvd.NgayThamGia
FROM DuAn da
INNER JOIN DiaDiem dd
    ON da.MaDiaDiem = dd.Id
INNER JOIN NhanVien_Duan nvd
    ON da.Id = nvd.MaDuAn;

-- ==========================================
-- BÀI 3 — INNER JOIN từ 4 bảng
-- ==========================================

-- Câu 3.1
-- Báo cáo phân công đầy đủ:
-- mỗi dòng cho biết nhân viên tham gia dự án nào,
-- dự án đó nằm ở địa điểm nào.
-- Kết quả gồm: TenNV, TenDuAn, TenDiaDiem, NgayThamGia.
-- Nối NhanVien → NhanVien_Duan → DuAn → DiaDiem.

SELECT 
    nv.TenNV,
    da.TenDuAn,
    dd.TenDiaDiem,
    nvd.NgayThamGia
FROM NhanVien nv
INNER JOIN NhanVien_Duan nvd
    ON nv.Id = nvd.MaNhanVien
INNER JOIN DuAn da
    ON nvd.MaDuAn = da.Id
INNER JOIN DiaDiem dd
    ON da.MaDiaDiem = dd.Id;


-- Câu 3.2
-- Liệt kê các nhân viên tham gia dự án,
-- kèm phòng ban của nhân viên và tên dự án.
-- Kết quả gồm: TenNV, TenPB, TenDuAn, NgayThamGia.
-- Nối NhanVien → PhongBan → NhanVien_Duan → DuAn.

SELECT 
    nv.TenNV,
    pb.TenPB,
    da.TenDuAn,
    nvd.NgayThamGia
FROM NhanVien nv
INNER JOIN PhongBan pb
    ON nv.MaPB = pb.Id
INNER JOIN NhanVien_Duan nvd
    ON nv.Id = nvd.MaNhanVien
INNER JOIN DuAn da
    ON nvd.MaDuAn = da.Id;


-- Câu 3.3
-- Báo cáo tổng hợp:
-- với mỗi phân công, hiển thị tên nhân viên,
-- phòng ban, tên dự án và địa điểm dự án.
-- Kết quả gồm: TenNV, TenPB, TenDuAn, TenDiaDiem.
-- Nối NhanVien, PhongBan, NhanVien_Duan, DuAn, DiaDiem.

SELECT 
    nv.TenNV,
    pb.TenPB,
    da.TenDuAn,
    dd.TenDiaDiem
FROM NhanVien nv
INNER JOIN PhongBan pb
    ON nv.MaPB = pb.Id
INNER JOIN NhanVien_Duan nvd
    ON nv.Id = nvd.MaNhanVien
INNER JOIN DuAn da
    ON nvd.MaDuAn = da.Id
INNER JOIN DiaDiem dd
    ON da.MaDiaDiem = dd.Id;
