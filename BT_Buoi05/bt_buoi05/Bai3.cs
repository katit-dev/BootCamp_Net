class Bai3
{
    public static void show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n===== BÀI 3: LOẠI BỎ CÁC PHẦN TỬ TRÙNG NHAU TRONG MỘT MẢNG, SAU ĐÓ TRẢ VỀ CHIỀU DÀI CỦA MẢNG SAU KHI ĐÃ LOẠI BỎ =====");
        Console.ResetColor();
        int n = Input_Handler.GetValidInteger("Nhập số lượng phần tử của mảng: ");
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = Input_Handler.GetValidInteger($"Nhập phần tử thứ {i + 1}: ");
        }

        // sort
        Array.Sort(nums);

        // Thuật toán 2 con trỏ
        int uniqueIndex = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[uniqueIndex])
            {
                uniqueIndex++;
                nums[uniqueIndex] = nums[i];
            }
        }

        int newLength = uniqueIndex + 1;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Độ dài mới: {newLength}");

        Console.Write("Mảng sau khi loại trùng: ");
        for (int i = 0; i < newLength; i++)
        {
            Console.Write(nums[i] + " ");
        }

        Console.WriteLine();
        Console.ResetColor();
        
    }
}