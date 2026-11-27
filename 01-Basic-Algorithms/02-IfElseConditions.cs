using System;

public class IfElseConditions
{
    public static void Run()
    {
        Console.WriteLine("=== POZİTİF - NEGATİF - SIFIR KONTROLÜ ===");

        Console.Write("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi > 0)
        {
            Console.WriteLine("Girilen sayı pozitiftir.");
        }
        else if (sayi < 0)
        {
            Console.WriteLine("Girilen sayı negatiftir.");
        }
        else
        {
            Console.WriteLine("Girilen sayı sıfırdır.");
        }
    }
}