using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int length = 0;
        int width = 0;

        while (true)
        {
            Console.WriteLine("請輸入矩形長度");
            string input = Console.ReadLine();

            if (IsValidInput(input))
            {
                length = Convert.ToInt32(input);
                break;
            }
            Console.WriteLine("請輸入正確數字");
        }

        while (true)
        {
            Console.WriteLine("請輸入矩形高度");
            string input = Console.ReadLine();

            if (IsValidInput(input))
            {
                width = Convert.ToInt32(input);
                break;
            }
            Console.WriteLine("請輸入正確數字");
        }

        Rectangle rectangle = new Rectangle()
        {
            Length = length,
            Width = width,
        };
        Console.WriteLine(rectangle);
        Console.ReadLine();

        bool IsValidInput(string input)
        {
            return Int32.TryParse(input, out _);
        }
    }

    public class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Perimeter => (Length + Width) * 2;
        public int Area => Length * Width;

        public override string ToString()
        {
            return $"長:{Length}"
                + Environment.NewLine
                + $"寬:{Width}"
                + Environment.NewLine
                + $"周長:{Perimeter}"
                + Environment.NewLine
                + $"面積:{Area}";
        }
    }
}