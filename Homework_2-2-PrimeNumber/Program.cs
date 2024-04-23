using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int low = 1;
        int high = 200;

        for (int i = low; i <= high; i++)
        {
            // 質數判斷
            // 第二個迴圈用來從頭跟自己相除，
            // 如果有滿足除了1與自己本身以外的數字就不是質數
            // 因為自己跟1絕對可以被整除，所以迴圈不需要從1開始，不用到自己就結束
            // 例如 55，則檢查範圍就是2~54
            bool isDivisionable = false;
            for (int j = 2; j < i; j++)
            {
                isDivisionable = i % j == 0;
                if (isDivisionable)
                {
                    break;
                }
            }
            // 跑完迴圈就檢查剛剛的迴圈有沒有人成功整除
            // 沒成功表示是質數
            if (isDivisionable == false)
            {
                Console.WriteLine(i);
            }
            // 判斷完這次條件，把儲存狀態用的變數恢復原狀
            isDivisionable = false;
        }
        Console.ReadLine();
    }
}