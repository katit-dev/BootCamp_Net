class Bai5
{
    public static void show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n===== BÀI 5: THỜI GIAN TỐT NHẤT ĐỂ MUA VÀ BÁN CỔ PHIẾU =====");
        Console.ResetColor();
        int n = Input_Handler.GetValidInteger("Nhập số lượng phần tử của mảng: ");
        int[] prices = new int[n];
        for (int i = 0; i < n; i++)
        {
            prices[i] = Input_Handler.GetValidInteger($"Nhập giá cổ phiếu vào ngày {i + 1}: ");
        }
        int minPrice = prices[0];
        int maxProfit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else
            {
                int profit = prices[i] - minPrice;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
        }
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Lợi nhuận tối đa có thể đạt được: {maxProfit}");
        Console.ResetColor();

    }
}