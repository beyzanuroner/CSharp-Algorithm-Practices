using System;

public class ForLoopSum
{
    public static void Run()
    {
        Console.WriteLine("=== 1'DEN 100'E KADAR ÇİFT SAYILARIN TOPLAMI ===");

        int toplam = 0;

        for (int i = 1; i <= 100; i++)
        {
            if(i % 2 == 0) // Sadece cift sayilari toplamak icin
            {
                toplam += i;
            }
        }

        Console.WriteLine("Toplam: " + toplam);
    }
}