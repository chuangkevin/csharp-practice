using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //提示使用者輸入字串
        Console.WriteLine("請輸入數字");
        //讓使用者輸入字串
        string input = Console.ReadLine();
        //用一包東西,拿來存取使用者輸入字串，用逗號分割
        string[] inputs = input.Split(',');

        //將這一包東西拿出來做排序(從小到大)
        Console.WriteLine("排序前數字");
        foreach (string beout in inputs)
        {
            Console.WriteLine(beout);
        }
        int[] intArr = new int[inputs.Length];

        for (int i = 0; i < intArr.Length; i++)
        {
            intArr[i] = Convert.ToInt32(inputs[i]);
        }
        Array.Sort(intArr);
        Console.WriteLine("排序後數字");
        foreach (int afout in intArr)
        {
            Console.WriteLine(afout);
        }
        Console.ReadLine();
    }
}