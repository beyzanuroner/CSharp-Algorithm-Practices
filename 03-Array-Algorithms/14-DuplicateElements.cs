using System;

public class DuplicateElements
{
    public static void Run()
    {
        Console.WriteLine("=== TEKRAR EDEN ELEMANLARI BULMA ===");

        int[] sayilar = { 10, 20, 30, 20, 40, 10, 50 };

        bool tekrarVarMi = false;

        for (int i = 0; i < sayilar.Length; i++)
        {
            for (int j = i + 1; j < sayilar.Length; j++)
            {
                if (sayilar[i] == sayilar[j])
                {
                    Console.WriteLine("Tekrar eden sayi: " + sayilar[i]);

                    tekrarVarMi = true;
                    break;
                }           
            }
        }

        if (!tekrarVarMi)
        {
            Console.WriteLine("Tekrar eden sayi yok.");
        }
    }
}