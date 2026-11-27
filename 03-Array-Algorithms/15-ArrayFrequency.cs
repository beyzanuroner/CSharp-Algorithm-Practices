using System;

public class ArrayFrequency
{
    public static void Run()
    {
        Console.WriteLine("=== DIZI FREKANS HESAPLAMA ===");

        int[] sayilar = { 10, 20, 10, 30, 20, 10 };

        bool[] kontrolEdildi = new bool[sayilar.Length];

        for (int i = 0; i < sayilar.Length; i++)
        {
            if (kontrolEdildi[i])
            {
                continue; // Bu sayi zaten kontrol edildi, atla
            }

            int frekans = 0;

            for (int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[i] == sayilar[j])
                {
                    frekans++;
                    kontrolEdildi[j] = true; // Bu sayiyi kontrol edildi olarak işaretle
                }
            }
            Console.WriteLine(sayilar[i] + " sayisi " + frekans + " kez tekrar ediyor.");
        }
    }
}
