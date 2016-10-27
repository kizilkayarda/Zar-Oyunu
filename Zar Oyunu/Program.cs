using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zar_Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            do // oyun
            {
                int girilenSayi = 0;
                do //sayı girilene kadar dön
                {
                    Console.WriteLine("1-6 arasında bir sayı giriniz");
                    try
                    {
                        girilenSayi = int.Parse(Console.ReadLine());
                        if (girilenSayi < 1 || girilenSayi > 6)
                            throw new Exception("Lütfen 1 ile 6 arasında bir sayı giriniz!");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (true);
                int[,] zarlar = new int[1, 2];
                int[,] zarlarTampon = new int[1, 2];
                int zar1 = 0, zar2 = 0, sayac = 0;
                Random rnd = new Random();
                do
                {
                    zarlar = new int[sayac + 1, 2]; // düşünelim :)

                    for (int i = 0; i < zarlarTampon.Length / 2; i++)
                    {
                        zarlar[i, 0] = zarlarTampon[i, 0];
                        zarlar[i, 1] = zarlarTampon[i, 1];
                    }


                    zar1 = rnd.Next(1, 7);
                    zar2 = rnd.Next(1, 7);

                    zarlar[sayac, 0] = zar1;
                    zarlar[sayac, 1] = zar2;

                    zarlarTampon = zarlar;

                    sayac++;
                    Console.WriteLine(sayac + ". deneme:" + zar1 + "-" + zar2);
                    if (girilenSayi == zar1 && girilenSayi == zar2)
                    {
                        Console.WriteLine(sayac + ". denemede bulundu");
                        break;
                    }
                } while (true);
                Console.WriteLine("Tekrar oynamak için \"E\" tuşuna basınız");
                string secim = Console.ReadLine();
                if (secim.ToLower() != "e")
                    break;
            } while (true);
        }
    }
}
