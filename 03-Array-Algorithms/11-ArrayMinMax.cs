using System;

public class ArrayMinMax
{
    public static void Run()
    {
        Console.WriteLine("=== DIZIDE EN KUCUK VE EN BUYUK SAYI ===");

        int[] sayilar = new int[5];

        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write((i + 1) + ". sayiyi giriniz: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        int enKucuk = sayilar[0];
        int enBuyuk = sayilar[0];

        for (int i = 1; i < sayilar.Length; i++)
        {
            if (sayilar[i] < enKucuk)
            {
                enKucuk = sayilar[i];
            }
            if (sayilar[i] > enBuyuk)
            {
                enBuyuk = sayilar[i];
            }
        }

        Console.WriteLine("En kucuk sayi: " + enKucuk);
        Console.WriteLine("En buyuk sayi: " + enBuyuk);
    }
}