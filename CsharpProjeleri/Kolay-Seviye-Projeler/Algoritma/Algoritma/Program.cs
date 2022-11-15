using System;

namespace Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir kelime giriniz ve aralarında virgül kullanarak çıkarmak istediğiniz karakterin index' ini girin: ");
            string inpt = Console.ReadLine();
            string[] input = inpt.Split(",");
            string kelime = input[0];
            int cevir = Convert.ToInt32(input[1]);
            string sonuc = kelime.Remove(cevir, 1);
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
