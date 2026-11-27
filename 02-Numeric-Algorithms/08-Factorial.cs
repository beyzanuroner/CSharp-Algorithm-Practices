using System;

public class Factorial
{
    public static void Run()
    {
        Console.WriteLine("=== FAKTORIYEL HESAPLAMA ===");

        Console.Write("Bir sayi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi < 0)
        {
            Console.WriteLine("Negatif sayilarin faktoriyeli hesaplanamaz.");
            return;
        }

        if (sayi > 20)
        {
            Console.WriteLine("Cok buyuk sayilarin faktoriyeli hesaplanamaz (20'den buyuk sayilar).");
            return;
        }

        long faktoriyel = 1;

        for (int i = 1; i <= sayi; i++)
        {
            faktoriyel *= i;
        }
        
        Console.WriteLine(sayi + "! = " + faktoriyel);
    }
}