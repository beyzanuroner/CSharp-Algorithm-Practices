using System;

class VariableOperations
{
    static void Main()
    {
        // Kullanıcıdan iki sayı alıyorum.
        Console.Write("Birinci sayıyı giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı giriniz: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        // Matematiksel işlemler
        int toplam = sayi1 + sayi2;
        int fark = sayi1 - sayi2;
        int carpim = sayi1 * sayi2;

        // Sonuçları ekrana yazdırıyorum.
        Console.WriteLine($"Toplam: {toplam}");
        Console.WriteLine($"Fark: {fark}");
        Console.WriteLine($"Çarpım: {carpim}");

        // Sıfıra bölme kontrolü
        if (sayi2 != 0)
        {
            double bolum = (double)sayi1 / sayi2;
            Console.WriteLine($"Bölüm: {bolum}");
        }
        else
        {
            Console.WriteLine("Bir sayı sıfıra bölünemez!");
        }
    }
}