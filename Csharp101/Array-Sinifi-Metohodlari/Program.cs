using System;

namespace Array_Sinifi_Metohodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            // Sort
            Console.WriteLine("---------Array Sort---------");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            // Clear
            Console.WriteLine("---------Array Clear---------");
            Array.Clear(sayiDizisi, 2, 2);//sayiDizisi elemanlarını kullanarak 2.index ten itibaren 2 tane elemanı sıfırlar.(2.index dahil)
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            // Reverse
            Console.WriteLine("---------Array Reverse---------");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            // IndexOf
            Console.WriteLine("---------Array IndexOf---------");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            // Resize
            Console.WriteLine("---------Array Resize---------");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
        }
    }
}
