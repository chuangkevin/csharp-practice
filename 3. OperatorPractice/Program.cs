using System;

internal class Program
{
    private static void Main()
    {
        int inputNumber;

        #region 先不用管

        // 用一個迴圈持續要求輸入，直到輸入的是正確格式的數字
        while (true)
        {
            Console.WriteLine("請輸入數字，判斷是否為2、5或同時為2與5的倍數");
            string input = Console.ReadLine();

            // 用來將字串轉換為 int 的方法
            if (Int32.TryParse(input, out inputNumber))
            {
                // 輸入成功後，跳出迴圈
                break;
            }
            else
            {
                // 輸入失敗的情況
                Console.WriteLine("請輸入有效的數字");
            }
        }

        #endregion 先不用管

        // 在這裡使用 inputNumber 做接下來的處理
        Console.WriteLine($"您輸入的數字是: {inputNumber}");

        // 目標
        // 請完成 判斷是否為2的倍數
        if (inputNumber % 2 == 0 && inputNumber % 5 == 0)
        {
            Console.WriteLine("這是2與5的倍數");
        }
        else if (inputNumber % 2 == 0)
        {
            Console.WriteLine("這是2的倍數");
        }
        else if (inputNumber % 5 == 0)
        {
            Console.WriteLine("這是5的倍數");
        }
        else
        {
            Console.WriteLine("這不是2的倍數");
        }
        Console.ReadLine();
    }
}