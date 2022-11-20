using System;

namespace AlanHesaplama
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesaplama yapmak istediğiniz şekili seçiniz: ");
            Console.WriteLine("*************************************************** ");
            Console.WriteLine("Daire veya Küre                        (1)");
            Console.WriteLine("Üçgen veya Üçgen Prizma                (2)");
            Console.WriteLine("Kare veya Küp                          (3)");
            Console.WriteLine("Dikdörtgen veya Dikdörtgenler Prizması (4)");
            int sekil = Convert.ToInt32(Console.ReadLine());

            switch (sekil)
            {

                case 1:
                    Daire.Hesaplama();
                    break;

                case 2:
                    Ücgen.Hesaplama();
                    break;

                case 3:
                    Kare.Hesaplama();
                    break;

                case 4:
                    Dikdortgen.Hesaplama();
                    break;

                default:
                    HataMesaji.Hata();
                    break;
            }
            Console.ReadLine();
        }
    }

    public class BoyutSecimi
    {
        public static void Secim()
        {
            Console.WriteLine("Boyut seçiniz: ");
            Console.WriteLine("Çevre (1)");
            Console.WriteLine("Alan  (2)");
            Console.WriteLine("Hacim (3)");
        }
    }

    public class Daire
    {
        public static void Hesaplama()
        {
            Console.WriteLine("Yarıçap uzunluğunu giriniz: ");
            int r = Convert.ToInt32(Console.ReadLine());
            BoyutSecimi.Secim();
            int boyut = Convert.ToInt32(Console.ReadLine());

            switch (boyut)
            {
                case 1:
                    double cevre = 2 * Math.PI * r;
                    Console.WriteLine("Çevre: " + cevre);
                    break;

                case 2:
                    double alan = Math.PI * Math.Pow(r, 2);
                    Console.WriteLine("Alan: " + alan);
                    break;

                case 3:
                    double hacim = (4 * Math.PI * Math.Pow(r, 3) / 3);
                    Console.WriteLine("Hacim", + hacim);
                    break;
                default:
                    HataMesaji.Hata();
                    break;
            }
        }
    }
    
    public class Dikdortgen
    {
        public static void Hesaplama()
        {
            Console.WriteLine("Kısa kenarın uzunluğu giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun kenarın uzunluğunu giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            BoyutSecimi.Secim();
            int boyut = Convert.ToInt32(Console.ReadLine());

            switch (boyut)
            {
                case 1:
                    double cevre = 2 * (a + b);
                    Console.WriteLine("Çevre: " + cevre);
                    break;

                case 2:
                    double alan = a * b;
                    Console.WriteLine("Alan: " + alan);
                    break;

                case 3:
                    Console.WriteLine("Yükseklik: ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    double hacim = a * b * c;
                    Console.WriteLine("Hacim: " + hacim);
                    break;

                default:
                    HataMesaji.Hata();
                    break;
            }
        }
    }

    public class Kare
    {
        public static void Hesaplama()
        {
            Console.WriteLine("Lütfen kenar uzunluğu giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());

            BoyutSecimi.Secim();
            int boyut = Convert.ToInt32(Console.ReadLine());

            switch (boyut)
            {
                case 1:
                    double cevre = 4 * a;
                    Console.WriteLine("Çevre: " + cevre);
                    break;

                case 2:
                    double alan = Math.Pow(a, 2);
                    Console.WriteLine("Alan: " + alan);
                    break;

                case 3:
                    double hacim = Math.Pow(a, 3);
                    Console.WriteLine("Hacim: " + hacim);
                    break;

                default:
                    HataMesaji.Hata();
                    break;

            }
        }

    }

    public class Ücgen
    {
        public static void Hesaplama()
        {
            Console.WriteLine("1. Kenar uzunluğunu giriniz :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. kenar uzunluğunu giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. kenar uzunluğunu giriniz: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. kenara ait yüksekliği giriniz:");
            int h = Convert.ToInt32(Console.ReadLine());

            BoyutSecimi.Secim();
            int boyut = Convert.ToInt32(Console.ReadLine());

            switch (boyut)
            {
                case 1:
                    double cevre = a + b + c;
                    Console.WriteLine("Çevre: " + cevre);
                    break;

                case 2:
                    double alan = (c * h) / 2;
                    Console.WriteLine("Alan: " + alan);
                    break;

                case 3:
                    Console.WriteLine("Yükseklik giriniz:");
                    int h1 = Convert.ToInt32(Console.ReadLine());
                    double hacim = (c * h * h1) / 2;
                    Console.WriteLine("Hacim: " + hacim);
                    break;

                default:
                    HataMesaji.Hata();
                    break;

            }
        }
    }

    public class HataMesaji
    {
        public static void Hata()
        {
            Console.WriteLine("\a Hatalı tuşlama yaptınız!");
        }
    }

}
