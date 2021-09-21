using System;

namespace TelefonRehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory directory = new Directory();
            
            while (true)
            {

                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                Console.WriteLine(" (1) Yeni Numara Kaydetmek");
                Console.WriteLine(" (2) Varolan Numarayı Silmek");
                Console.WriteLine(" (3) Varolan Numarayı Güncelleme");
                Console.WriteLine(" (4) Rehberi Listelemek");
                Console.WriteLine(" (5) Rehberde Arama Yapmak");
                Console.WriteLine(" (9) Çıkış Yap");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        directory.Add();
                        break;
                    case 2:
                        directory.Delete();
                        break;
                    case 3:
                        directory.Update();
                        break;
                    case 4:
                        directory.GetAll();
                        break;
                    case 9:
                        return;
                }
            }
        }
    }
}
