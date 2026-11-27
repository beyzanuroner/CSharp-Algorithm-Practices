using System;

public class SwitchCaseCalculator
{
    public static void Run()
    {
        Console.WriteLine("=== HESAP MAKINESI ===");

        Console.Write("Birinci sayiyi giriniz: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ikinci sayiyi giriniz: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Islem seciniz (+, -, *, /): ");
        string islem = Console.ReadLine() ?? "";

        switch (islem)
        {
            case "+":
                Console.WriteLine("Sonuc: " + (sayi1 + sayi2));
                break;

            case "-":
                Console.WriteLine("Sonuc: " + (sayi1 - sayi2));
                break;

            case "*":
                Console.WriteLine("Sonuc: " + (sayi1 * sayi2));
                break;
            case "/":
                if (sayi2 != 0)
                {
                    Console.WriteLine("Sonuc: " + (sayi1 / sayi2));
                }
                else
                {
                    Console.WriteLine("Hata: Sifira bolme hatasi!");
                }
                break;

            default:
                Console.WriteLine("Gecersiz islem secimi!");
                break;
        }
    }
}