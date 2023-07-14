// See https://aka.ms/new-console-template for more information

using System;
public class HelloMath
{
    public static void Main(string[] args)
    {
        int sayi = -1;
        int sayi2;
        int sayi3;
        int sayi4;
        int toplam = 0;
        int faktoriyel = 1;
        int ciftToplam = 0;
        int BeşinKatlarıToplam = 0;

        Console.Write("Toplam hesabı için bir sayı girin:");
        while (!int.TryParse(Console.ReadLine(), out sayi))
        {
            Console.Write("Lütfen sadece sayi giriniz: ");
        }
        while (sayi < 0)
        {
            Console.Write("Lütfen pozitif sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine().ToString());
        }

        //sayi = Convert.ToInt32(Console.ReadLine().ToString());
        for (int i = 1; i <= sayi; i++)
        {
            toplam += i;
        }
        Console.WriteLine("0'den " + sayi + " sayısına kadar olan sayıların toplamı = " + toplam);
        Console.WriteLine("--------------------");

        Console.Write("Faktöriyel hesabı için bir sayı girin: ");
        while (!int.TryParse(Console.ReadLine(), out sayi2))
        {
            Console.Write("Lütfen sadece pozitif sayı giriniz: ");
        }
        while (sayi2 < 0)
        {
            Console.Write("Lütfen sayı giriniz: ");
            string giris = Console.ReadLine();
            int.TryParse(giris, out sayi2);
        }
        if (sayi2 > 0)
        {
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi2; i++)
            {
                faktoriyel *= i;
            }
            Console.WriteLine(sayi2 + "! = " + faktoriyel);
        }
        else if (sayi2 == 0)
        {
            Console.Write(" 0! = 1 ");
        }

        Console.WriteLine("--------------------");

        Console.WriteLine("Çift sayıların toplamı için sayı giriniz: ");
        while (!int.TryParse(Console.ReadLine(), out sayi3))
        {
            Console.Write("Lütfen sadece sayi giriniz: ");
        }
        while (sayi3 < 0)
        {
            Console.Write("Lütfen pozitif sayı giriniz: ");
            sayi3 = Convert.ToInt32(Console.ReadLine().ToString());
        }
        //sayi3 = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= sayi3; i += 2)
        {
            ciftToplam += i;
        }
        Console.WriteLine(sayi3 + " e kadar olan çift sayıların toplamı: " + ciftToplam);
        Console.WriteLine("--------------------");

        Console.WriteLine("Beşin katlarının toplamı için sayı giriniz: ");
        while (!int.TryParse(Console.ReadLine(), out sayi4))
        {
            Console.Write("Lütfen sadece sayi giriniz: ");
        }
        while (sayi4 < 0)
        {
            Console.Write("Lütfen pozitif sayı giriniz: ");
            sayi4 = Convert.ToInt32(Console.ReadLine().ToString());
        }
        //sayi4 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= sayi4; i++)
        {
            if (i % 5 == 0)
            {
                BeşinKatlarıToplam += i;
            }
        }
        Console.WriteLine(sayi4 + " e kadar olan 5'in katları toplamı: " + BeşinKatlarıToplam);

        Console.WriteLine("--------------------");
    }
}
