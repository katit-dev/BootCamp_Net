class Menu
{
    public void Show()
    {
        int choice;
        bool checkValid;
        do
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n ===== MENU CHẤM BÀI =====");
            Console.WriteLine("1. Bài 1: Tính tổng các số trong mảng");
            Console.WriteLine("2. Bài 2: Tìm 2 số trong 1 danh sách mà tổng bằng một số được nhập vào");
            Console.WriteLine("3. Bài 3: Loại bỏ các phần tử trùng nhau trong một mảng, sau đó trả về chiều dài của mảng sau khi đã loại bỏ");
            Console.WriteLine("4. Bài 4: Nhập 1 số nguyên k, sau đó hệ thống sẽ ra k phần tử xuất hiện nhiều nhất");
            Console.WriteLine("5. Bài 5: Thởi gian tốt nhất để mua và bán cổ phiếu");
            Console.WriteLine("6. Thoát");
            Console.WriteLine("===========================");
            Console.Write("Nhập lựa chọn của bạn (1-6): ");
            Console.ResetColor();

            checkValid = int.TryParse(Console.ReadLine(), out choice);
            if (!checkValid || choice < 1 || choice > 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
                Console.ResetColor();
                continue;
            }
            switch (choice)
            {
                case 1:
                    Bai1.show();
                    break;
                case 2:
                    Bai2.show();
                    break;
                case 3:
                    Bai3.show();
                    break;
                case 4:
                    Bai4.show();
                    break;
                case 5:
                    Bai5.show();
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nKết thúc chương trình. \n");
                    Console.ResetColor();
                    return;
            }
        } while (true);
    }
}