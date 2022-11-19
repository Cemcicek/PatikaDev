using System;

namespace KarakterTerstenYazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle giriniz: ");
            string sentence = Console.ReadLine();

            char[] character = sentence.ToCharArray();
            string reverse = string.Empty;

            for (int i = character.Length - 1; i > -1; i--)
            {
                reverse += character[i];
            }
            Console.WriteLine(reverse);
        }
    }
}
