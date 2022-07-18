using System;

namespace ConsoleProgramlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("İsminizi Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi Giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + surname);
            Console.ReadKey();
            
        }
    }
}
