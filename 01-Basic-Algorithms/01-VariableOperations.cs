using System;

public class VariableOperations
{
    public static void Run()
    {
        Console.WriteLine("=== MATEMATIKSEL ISLEMLER ===");

        Console.Write("Birinci sayiyi giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ikinci sayiyi giriniz: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        int toplam = sayi1 + sayi2;
        int fark = sayi1 - sayi2;
        int carpim = sayi1 * sayi2;

        Console.WriteLine("Toplam: " + toplam);
        Console.WriteLine("Fark: " + fark);
        Console.WriteLine("Carpim: " + carpim);

        if (sayi2 != 0)
        {
            double bolum = (double)sayi1 / sayi2;
            Console.WriteLine("Bolum: " + bolum);
        }
        else
        {
            Console.WriteLine("Sifira bolme yapilamaz!");
        }
    }
}