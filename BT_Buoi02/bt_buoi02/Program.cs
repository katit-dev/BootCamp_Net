// See https://aka.ms/new-console-template for more information

// Bai Tap 1
Console.Write("Nhap nhiet do (°C): ");

bool checkFormat = double.TryParse(Console.ReadLine(), out double nhietDo);

if (!checkFormat)
{
    Console.WriteLine("Hay nhap dung dinh dang so!");}
else
{
    if(nhietDo > 0)
    {
        Console.WriteLine("Trời ấm");
    }
    else if(nhietDo < 0)
    {
        Console.WriteLine("Trời lạnh, có thể có băng giá!");
    }
    else
    {
        Console.WriteLine("Trời rất lạnh, đúng 0°C!");
    }
}

// Bai Tap 2
Console.Write("Nhap thu nhap hang thang (trieu dong): ");

bool checkFormat2 = double.TryParse(Console.ReadLine(), out double thuNhap);

if (!checkFormat2)
{
    Console.WriteLine("Hay nhap dung dinh dang so!");
}
else
{
    double thue = 0;

    if (thuNhap <= 5)
    {
        Console.WriteLine("Mien thue");
        thue = 0;
    }
    else if (thuNhap <= 10)
    {
        Console.WriteLine("Thue 10%");
        thue = thuNhap * 0.1;
    }
    else
    {
        Console.WriteLine("Thue 20%");
        thue = thuNhap * 0.2;
    }

    Console.WriteLine($"So thue phai nop: {thue} trieu dong");
}


// Bai tap 3
Console.Write("Nhập vào số tháng (1-12): ");
bool checkNumber = int.TryParse(Console.ReadLine(), out int month);
if (!checkNumber || month < 1 || month > 12)
{
    Console.WriteLine("Vui lòng nhập đúng định dạng (1-12)");

}
else
{
    string season = month switch
    {
        1 or 2 or 3 => "Mùa Xuân",
        4 or 5 or 6 => "Mùa Hạ",
        7 or 8 or 9 => "Mùa Thu",
        10 or 11 or 12 => "Mùa Đông"
    };
    Console.WriteLine($"Tháng {month} thuộc {season}");
}

// Bai tap 4
Console.Write("Nhập tuổi công dân: ");
bool checkNumber2 = int.TryParse(Console.ReadLine(), out int age);

if(!checkNumber2 || age < 0)
{
    Console.WriteLine("Tuổi không hợp lệ!");
}
else
{
    if(age < 18) Console.WriteLine("Chưa đủ tuổi tham gia NVQS");
    else if (age <= 27) Console.WriteLine("Đủ tuổi tham gia NVQS");
    else Console.WriteLine("Quá tuổi tham gia NVQS");
}

// Bai tap 5
Console.Write("Nhập một số nguyên: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int n);

if (!isNumber)
{
    Console.WriteLine("Giá trị nhập vào không hợp lệ");

}

if (n <= 1)
{
    Console.WriteLine("Không phải số nguyên tố");
    return;
}

bool isPrime = true;

for (int i = 2; i <= Math.Sqrt(n); i++)
{
    if (n % i == 0)
    {
        isPrime = false;
        break;
    }
}

if (isPrime)
    Console.WriteLine($"{n} là số nguyên tố");
else
    Console.WriteLine($"{n} không phải số nguyên tố");

// bai tap 6
Console.Write("Nhập số điện tiêu thụ(kWh): ");
bool checkNumber3 = double.TryParse(Console.ReadLine(), out double input);

if(!checkNumber3 || input <= 0)
{
    Console.WriteLine("Số điện không hợp lệ");

}
else
{
    double donGia;
    if(input < 100)
    {
        donGia = 1500;;
    }else if(input <= 200)
    {
        donGia = 2000;
    }
    else
    {
        donGia = 2500;
    }

    Console.WriteLine($"{input} kWh điện");
    Console.WriteLine($"có đơn giá là {donGia}");
    Console.WriteLine($"Số tiền phải trả là {input * donGia}");
}


// Bai tap 7
Console.Write(@"Hãy chọn hạng vé:
1. Standard
2. Premium
3. VIP
");

bool checkNumber4 = int.TryParse(Console.ReadLine(), out int input2);

if(!checkNumber4 || input2 < 1 || input2 > 3)
{
    Console.WriteLine("Nhập không hợp lệ!");
}
else
{
    string tienIch = input2 switch
    {
      1 => "Ghế ngồi thường, không có đồ uống",
      2 => "Ghế ngồi thoải mái, có đồ uống miễn phí",
      3 => "Ghế ngồi hạng sang, có đồ uống và bỏng ngô miễn phí"  
    };
    Console.WriteLine(tienIch);
}

// Bai tap 8
Console.Write("Nhập số km đã đi: ");
bool checkNumber5 = double.TryParse(Console.ReadLine(), out double input3);

if(!checkNumber5 || input3 <= 0)
{
    Console.WriteLine("Nhập không đúng định dạng!");
}
else
{
    double giaTien;
    if(input3 <= 1)
    {
        giaTien = 10000 * input3; 
    }else if(input3 <= 5)
    {
        giaTien =10000 + (input3 -1) * 8000;
    }
    else
    {
        giaTien = 10000 + 4 * 8000 + (input3 - 5) * 6000;
    }
    Console.WriteLine($"Số km: {input3}");
Console.WriteLine($"Tiền cước taxi: {giaTien:N0} VND");
}

// Bai tap 9
Console.Write("Nhập một ký tự: ");
char ch = char.ToLower(Console.ReadKey().KeyChar);
Console.WriteLine();

switch (ch)
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("Là nguyên âm");
        break;
    default:
        Console.WriteLine("Là phụ âm");
        break;
}



// bai tap 10
Console.Write(@"Hãy chọn loại vé:
1. Economy
2. Business
3. First Class
");

bool checkNumber6 = int.TryParse(Console.ReadLine(), out int input4);

if (!checkNumber6 || input4 < 1 || input4 > 3)
{
    Console.WriteLine("Nhập không hợp lệ!");
}
else
{
    string tienIch = input4 switch
    {
        1 => "Ghế thường",
        2 => "Ghế rộng",
        3 => "Ghế sang trọng",
        _ => "Loại vé không tồn tại"
    };

    Console.WriteLine($"Tiện ích đi kèm: {tienIch}");
}

