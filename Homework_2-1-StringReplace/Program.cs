using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int low = 1;
        int high = 100;
        // 2的倍數=> 螃蟹
        // 3的倍數=> 章魚
        // 同時為2與3的倍數=> 金槍魚
        for (int i = low; i <= high; i++)
        {
            string toShow = i.ToString();
            if (i % 2 == 0 && i % 3 == 0)
            {
                toShow = "金槍魚";
            }
            else if (i % 2 == 0)
            {
                toShow = "螃蟹";
            }
            else if (i % 3 == 0)
            {
                toShow = "章魚";
            }
            Console.WriteLine(toShow);
        }
        Console.ReadLine();
    }
}