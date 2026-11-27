using System;

public class ArraySearch
{
    public static void Run()
    {
        Console.WriteLine("=== DIZIDE ELEMAN ARAMA ===");

        int[] sayilar = {10, 25, 30, 45, 50};

        Console.Write("Aramak istediginiz sayiyi giriniz: ");
        int arananSayi = Convert.ToInt32(Console.ReadLine());

        bool bulunduMu = false;

        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i] == arananSayi)
            {
                bulunduMu = true;
                Console.WriteLine("Sayı dizide bulundu!");
                Console.WriteLine("Index numarası: " + i);
                break;
            }
        }

        if (!bulunduMu)
        {
            Console.WriteLine("Sayı dizide bulunamadı.");
        }

    }
}