using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] intArray = { 7, 1, 9, 8, 5 };

        // 請印出intArray裡面的所有元素
        // 目標
        foreach (int i in intArray)
        {
            Console.WriteLine(i);
        }
        // 目標 數完數字後，告知使用者數完了
        Console.WriteLine($"數完了，共有{intArray.Length}個數字");
        Console.ReadLine();
    }
}