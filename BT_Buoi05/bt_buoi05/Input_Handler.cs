class Input_Handler
{
   // kiểm tra nhập có rỗng không
   public static string GetNonEmptyString(string prompt)
    {
        string? input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dữ liệu không được để trống. Vui lòng nhập lại.");
                Console.ResetColor();
            }
        } while (string.IsNullOrWhiteSpace(input));
        return input;
    }

    // kiểm tra nhập có phải là số nguyên không
    public static int GetValidInteger(string prompt)
    {
        int number;
        bool isValid;
        do
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            isValid = int.TryParse(input, out number);
            if (!isValid || number < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dữ liệu không hợp lệ. Vui lòng nhập một số nguyên.");
                Console.ResetColor();
            }
        } while (!isValid || number < 1);
        return number;
    }
}