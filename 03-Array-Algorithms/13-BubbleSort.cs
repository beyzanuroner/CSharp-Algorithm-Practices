
using System;

public class BubbleSort
{
    public static void Run()
    {
        Console.WriteLine("=== BUBBLE SORT ===");

        int[] sayilar = { 5, 3, 8, 1, 2 };

        Console.WriteLine("Siralamadan once:");

        foreach (int sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }

        for (int i = 0; i < sayilar.Length - 1; i++)
        {
            for (int j = 0; j < sayilar.Length - 1 - i; j++)
            {
                if (sayilar[j] > sayilar[j + 1])
                {
                    int gecici = sayilar[j];

                    sayilar[j] = sayilar[j + 1];

                    sayilar[j + 1] = gecici;
                }
            }
        }

        Console.WriteLine("\nSiralamadan sonra:");

        foreach (int sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }
    }
}
