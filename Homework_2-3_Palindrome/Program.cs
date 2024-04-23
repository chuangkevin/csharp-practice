using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // 回文判斷
        // 如果輸入 : 「上海自來水來自海上」
        // 則為是
        Console.WriteLine("請輸入一段文字，用以判斷是否為回文");
        string input = Console.ReadLine();
        char[] inputArr = input.ToArray();
        // 找出中間數，迴圈只要跑到中間數字，判斷是否都倆倆相同
        // 上海自來水來自海上
        // 我是是我
        // 0 1 2 3
        var breakNumber = inputArr.Length / 2;
        // 假設前後都是一樣，如果有不一樣則設為false
        bool isSame = true;
        for (int i = 0; i < breakNumber; i++)
        {
            // 最後一個數字是Length -1
            // 以中間為分割，則
            // 第一個是Arr[0]
            // 最後是Length-1-0

            // 第二個是Arr[1]
            // 倒數第二個是Length-1-1

            // 所以得出
            // 從中間切開，Arr[i]的反面就是Arr[Arr.Length-1-i]
            if (inputArr[i] != inputArr[inputArr.Length - 1 - i])
            {
                isSame = false;
            }
        }
        Console.WriteLine($"是否為回文 : {isSame}");

        Console.ReadLine();
    }
}