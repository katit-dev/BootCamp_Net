// See https://aka.ms/new-console-template for more information

// Bai tap 1
Console.Write("Nhập số ngày: ");
int days = int.Parse(Console.ReadLine());
int soTuan = days / 7;
int soNgayConLai = days % 7;
Console.WriteLine($"{days} ngay= {soTuan} tuan va {soNgayConLai} ngay");

// Bai tap 2
Console.Write("Nhập giá trị đơn hàng: ");
double giaTriDonHang = double.Parse(Console.ReadLine());
Console.Write("Nhập phần trăm giảm giá(%): ");
double phanTramGiamGia = double.Parse(Console.ReadLine());
double tongTienSauGiamGia = giaTriDonHang - (giaTriDonHang * phanTramGiamGia / 100);
Console.WriteLine($"Tổng tiền sau giảm giá: {tongTienSauGiamGia}");

// Bai tap 3
Console.Write("Nhập số phút: ");
int soPhut = int.Parse(Console.ReadLine());
int soGio = soPhut / 60;
int soPhutConLai = soPhut % 60;
Console.WriteLine($"{soPhut} phut = {soGio} gio va {soPhutConLai} phut");

// Bai tap 4
Console.Write("Nhập số tiền : ");
double soTien = double.Parse(Console.ReadLine());
Console.Write("Nhập tỷ lệ thuế VAT(%): ");
double tyLeThueVAT = double.Parse(Console.ReadLine());
double tongTien = soTien + (soTien * tyLeThueVAT / 100);
Console.WriteLine($"Tổng tiền sau thuế VAT: {tongTien}");

// Bai tap 5
Console.Write("Nhập số tiền (USD): ");
double usd = double.Parse(Console.ReadLine());
Console.Write("Nhập tỷ giá USD sang VND: ");
double tyGia = double.Parse(Console.ReadLine());
Console.WriteLine($"{usd} USD = {usd * tyGia} VND");

// Bai tap 6
Console.Write("Nhập số dư tài khoản hiện tại: ");
double soDu = double.Parse(Console.ReadLine());
Console.Write("Nhập số tiền muốn rút: ");
double soTienRut = double.Parse(Console.ReadLine());
double soDuConLai = soDu - soTienRut;
 Console.WriteLine($"Số dư còn lại sau khi rút: {soDuConLai}");

 // Bai tap 7
 Console.Write("Nhập quãng đường đã đi (km): ");
double quangDuong = double.Parse(Console.ReadLine());

Console.Write("Nhập thời gian đã đi (giờ): ");
double thoiGian = double.Parse(Console.ReadLine());

double tocDoTrungBinh = quangDuong / thoiGian;

Console.WriteLine($"Tốc độ trung bình: {tocDoTrungBinh} km/h");

// Bai tap 8
Console.Write("Nhập một số: ");
double so = double.Parse(Console.ReadLine());

Console.Write("Nhập tổng số: ");
double tongSo = double.Parse(Console.ReadLine());

double tyLePhanTram = (so / tongSo) * 100;

Console.WriteLine($"Tỷ lệ phần trăm: {tyLePhanTram}%");

// Bai tap 9
Console.Write("Nhập vận tốc (km/h): ");
 double vanTocKmH = double.Parse(Console.ReadLine());

 double vanTocMS = vanTocKmH / 3.6;

 Console.WriteLine($"Vận tốc sau khi chuyển đổi: {vanTocMS} m/s");

// Bai tap 10
Console.Write("Nhập số phút tập thể dục: ");
int soPhut2 = int.Parse(Console.ReadLine());

Console.Write("Nhập loại hình tập thể dục (chay / dapxe / boi): ");
string loaiHinh = Console.ReadLine().ToLower();

double heSoCalo;

switch (loaiHinh)
{
    case "chay":
        heSoCalo = 10.0;
        break;
    case "dapxe":
        heSoCalo = 8;
        break;
    case "boi":
        heSoCalo = 12;
        break;
    default:
        Console.WriteLine("Loại hình tập thể dục không hợp lệ.");
        return;
}
double caloTieuThu = soPhut2 * heSoCalo;
Console.WriteLine($"Lượng calo tiêu thụ: {caloTieuThu} calo");