class Bai1
{
    public static void show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nBài 1: Tính tổng các số trong mảng");
        Console.ResetColor();

        int n = Input_Handler.GetValidInteger("Nhập số lượng phần tử trong mảng: ");
        int[] lstNumber = new int[n];
        for (int i = 0; i < n; i++)
        {
            lstNumber[i] = Input_Handler.GetValidInteger($"Nhập phần tử thứ {i + 1}: ");
        }
        int sum = 0;
        foreach (int number in lstNumber)
        {
            sum += number;
        }
        
       Console.ForegroundColor = ConsoleColor.Blue;
       Console.WriteLine("Tổng các phần tử trong mảng là: " + sum);
       Console.ResetColor();

    }
}