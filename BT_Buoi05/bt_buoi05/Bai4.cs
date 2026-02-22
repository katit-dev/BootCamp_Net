class Bai4
{
    public static void show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n===== BÀI 4: NHẬP 1 SỐ NGUYÊN K, SAU ĐÓ HỆ THỐNG SẼ RA K PHẦN TỬ XUẤT HIỆN NHIỀU NHẤT =====");
        Console.ResetColor();
        int n = Input_Handler.GetValidInteger("Nhập số lượng phần tử của mảng: ");
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = Input_Handler.GetValidInteger($"Nhập phần tử thứ {i + 1}: ");
        }
        int k = Input_Handler.GetValidInteger("Nhập số nguyên k: ");

        // sort
        Array.Sort(nums);

        // Đếm tần suất
        Dictionary<int, int> frequency = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }

        // Lấy top k phần tử xuất hiện nhiều nhất
        var result = frequency
                        .OrderByDescending(x => x.Value)
                        .Take(k)
                        .Select(x => x.Key)
                        .ToList();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("K phần tử xuất hiện nhiều nhất:");

        foreach (var item in result)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
        Console.ResetColor();

      
    }
}