using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("請輸入台幣金額：");
        string input = Console.ReadLine();

        // 將輸入轉換成double
        double NTD = Convert.ToDouble(input);

        // 顯示輸入轉換成NTD 這種字串顯示方式叫做String Format
        Console.WriteLine($"您輸入的台幣金額為：{NTD} 新台幣");

        // 轉換成美元的匯率
        double rate = 0.32;

        // 換算成美金
        double output = NTD / rate;

        // 顯示換算後的美金金額
        Console.WriteLine($"換算成美金為：{output} 美元");

        // 一般Console程式會用這個，讓畫面停留，直到使用者再按下任意鍵才關掉
        Console.ReadLine();
    }
}