using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] intArray = { 7, 1, 9, 8, 5 };

        // 這個不用做，只是要知道Console.WriteLine的出現時機
        foreach (int i in intArray)
        {
            switch (i)
            {
                case 0:
                    {
                        Console.WriteLine($"{i}出現了");
                    }
                    break;

                case 1:
                    {
                        Console.WriteLine($"{i}出現了");
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine($"{i}出現了");
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine($"{i}出現了");
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine($"{i}出現了");
                    }
                    break;

                case 5:
                    {
                        Console.WriteLine($"{i}出現了");
                    }
                    break;

                case 6:
                    {
                        Console.WriteLine($"{i}出現了");
                    }
                    break;

                case 7:
                    {
                        Console.WriteLine($"{i}出現了");
                    }
                    break;

                case 8:
                    {
                        Console.WriteLine($"{i}出現了");
                    }
                    break;

                case 9:
                    {
                        Console.WriteLine($"{i}出現了");
                    }
                    break;
            }
        }

        Console.WriteLine("迴圈跑完了");
    }
}