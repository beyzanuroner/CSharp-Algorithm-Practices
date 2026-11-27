using System;

public class WhileDigitCount
{
    public static void Run()
    {
        Console.WriteLine("=== BASAMAK SAYISI BULMA ===");

        Console.Write("Bir sayi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        sayi = Math.Abs(sayi); // Negatif sayilar icin mutlak deger aliyoruz

        int basamakSayisi = 0;

        if (sayi == 0)
        {
            basamakSayisi = 1; // 0 sayisinin basamak sayisi 1'dir
        }
        else
        {
            while (sayi > 0)
            {
                sayi = sayi / 10; // Sayiyi 10'a bolerek basamak sayisini azaltıyoruz
                basamakSayisi++;
            }
        }
        Console.WriteLine("Basamak sayisi: " + basamakSayisi);
    }
}