using System;

public class FibonacciSeries
{
    public static void Run()
    {
        Console.WriteLine("=== FIBONACCI SERISI ===");

        Console.Write("Kac adet sayi yazdirilsin? ");
        int adet = Convert.ToInt32(Console.ReadLine());

        int ilkSayi = 0;
        int ikinciSayi = 1;

        if (adet < 0)
        {
            Console.WriteLine("Lutfen pozitif bir sayi giriniz.");
            return;
        }

        for (int i = 1; i <= adet; i++)
        {
            Console.Write(ilkSayi + " ");

            int sonrakiSayi = ilkSayi + ikinciSayi;

            ilkSayi = ikinciSayi;
            ikinciSayi = sonrakiSayi;
        }
    }
}