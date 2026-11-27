using System;

public class EvenOddNumber
{
    public static void Run()
    {
        Console.WriteLine("=== TEK - CIFT SAYI KONTROLU ===");

        Console.Write("Bir tam sayi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi % 2 == 0)
        {
            Console.WriteLine(sayi + " sayisi cift sayidir.");
        }
        else
        {
            Console.WriteLine(sayi + " sayisi tek sayidir.");
        }
    }
}
