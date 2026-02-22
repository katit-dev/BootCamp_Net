class Bai2
{
    public static void show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nBài 2: Tìm 2 số trong 1 danh sách mà tổng bằng một số được nhập vào");
        Console.ResetColor();

        int n = Input_Handler.GetValidInteger("Nhập số lượng phần tử trong mảng: ");
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = Input_Handler.GetValidInteger($"Nhập phần tử thứ {i + 1}: ");
        }

        int target = Input_Handler.GetValidInteger("Nhập số cần tìm tổng: ");

        bool found = false;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Tìm thấy tại vị trí: [{i}, {j}]");
                    Console.ResetColor();
                    found = true;
                    break;
                }
            }

            if (found) break;
        }

        if (!found)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Không tìm thấy hai số phù hợp.");
            Console.ResetColor();
        }
    }


}