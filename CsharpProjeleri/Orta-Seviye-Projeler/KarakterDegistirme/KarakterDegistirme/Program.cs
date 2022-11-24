using System;

namespace KarakterDegistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kelimelerin arasına boşluk bırakarak giriniz: ");
            string kelimeler = Console.ReadLine();
            string[] kelime = kelimeler.Split();

            foreach (var item in kelime)
            {
                char[] karakter = item.ToCharArray();
                char hafiza = karakter[0];
                karakter[0] = karakter[karakter.Length - 1];
                karakter[karakter.Length - 1] = hafiza;

                foreach (var items in karakter)
                {
                    string yeniKelime = items.ToString();
                    Console.Write(yeniKelime);
                }
            }
            Console.ReadLine();
        }
    }
}
