using System;
using System.Diagnostics.SymbolStore;

internal class Program
{
    private static void Main(string[] args)
    {
        int inputLayer = 0;
        while (true)
        {
            Console.WriteLine("請輸入層數(1~9)");
            string input = Console.ReadLine();

            bool isValidNumber = Int32.TryParse(input, out inputLayer);
            bool isValidRange = inputLayer > 0 && inputLayer < 10;
            if (isValidNumber is true && isValidRange)
            {
                break;
            }
            Console.WriteLine("請輸入正確層數");
        }
        for (int i = inputLayer; i > 0; i--)
        {
            // 補空格，空格數量是總數-目前的層數
            for (int k = 0; k < inputLayer - i; k++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine("\r");
        }
        Console.ReadLine();
    }
}