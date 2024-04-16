using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] intArray = { 1, 2, 3, 4, 5 };

        // 請抓出 intArray中
        // 第1、3、5個Element(元素) 目標
        for (int i = 0; i < intArray.Length; i++)
        {
            int currentIndex = (int)i;
            // 取出Array第幾個索引(Index)
            int targetNumber = intArray[i];
            // 目標
            // 第1、3、5個Element(元素) 目標，請注意Array是0開始
            // ||是 或(OR)，任意條件成立就算if成立
            if (currentIndex ==  || currentIndex ==  || currentIndex == )
            {
                Console.WriteLine($"跑到第{i + 1}，數字是{targetNumber}");
            }
        }
    }
}