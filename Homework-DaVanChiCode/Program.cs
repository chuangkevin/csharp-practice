using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //依照使用者輸入的數字，決定顯示數字區間繼續遊戲或者結束，並且檢查是否超出範圍。
        int low = 1;
        int high = 100;
        //生成一個亂數，介於1~100之間
        Random random = new Random();
        int targetNumber = random.Next(1, 100);
        //提示使用者請輸入數字
        Console.WriteLine($"請輸入一個數字，範圍{low}~{high}");
        string input = Console.ReadLine();
        int userInputNumber = Convert.ToInt32(input);

        //判斷使用者輸入的數字是不是正確的
        while (userInputNumber != targetNumber)
        {
            if (userInputNumber > high || userInputNumber < low)//判斷使用者的數字區間是不是超過
            {
                Console.WriteLine($"數字是{low}到{high}，請重新輸入");
                string innerinput1 = Console.ReadLine();
                userInputNumber = Convert.ToInt32(innerinput1);
                continue;
            }
            if (userInputNumber > targetNumber)
            {
                high = userInputNumber;
            }
            else
            {
                low = userInputNumber;
            }
            Console.WriteLine($"數字是{low}到{high}，請再猜看看");
            string innerinput2 = Console.ReadLine();
            userInputNumber = Convert.ToInt32(innerinput2);
        }
        //使用者答對，顯示結果。
        Console.WriteLine("答對了");

        Console.ReadLine();
    }
}