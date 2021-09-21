using System;
using System.Collections.Generic;
using System.Linq;

namespace TelefonRehberi
{
    public class Directory : IDirectory
    {
        List<Person> persons;
        public Directory(){
            persons = new List<Person>();
        }
        public void Add()
        {
            Person person = new Person();
            Console.WriteLine("Lütfen isim giriniz: ");
            person.Name = Console.ReadLine();

            Console.WriteLine("Lütfen soyisim giriniz: ");
            person.Surname = Console.ReadLine();

            Console.WriteLine("Lütfen telefon numarası giriniz: ");
            person.PhoneNumber = Console.ReadLine();

            persons.Add(person);
        }
        public void Delete()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string searchPath = Console.ReadLine();
            var result = persons.Where(p => p.Name == searchPath || p.Surname == searchPath).FirstOrDefault();
            if (result == null)
            {
                Console.WriteLine("  Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("  * Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("  * Yeniden denemek için      : (2)");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        return;
                    case 2:
                        Delete();
                        break;
                }
            }
            else
            {
                Console.WriteLine($" {result.Name} {result.Surname} [{result.PhoneNumber}] isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                char select = char.ToUpper(Console.ReadKey().KeyChar);
                switch (select)
                {
                    case 'Y':
                        persons.Remove(result);
                        break;
                    case 'H':
                        break;
                }
            }
        }
        public void GetAll()
        {
            Console.WriteLine("  Telefon Rehberi");
            Console.WriteLine(" ********************************************");
            persons.ForEach(p => { Console.WriteLine($"  isim: {p.Name}");
            Console.WriteLine($"  Soyisim: {p.Surname}");
            Console.WriteLine($"  Telefon Numarası: {p.PhoneNumber}");
            Console.WriteLine($"------------------------------------");
        });
        }
        public void Update()
        {
            Console.WriteLine("Lütfen numarasını düzenlemek istediğiniz kişinin adını yada soyadını giriniz:");
            string searchPath = Console.ReadLine();
            var result = persons.Where(p => p.Name == searchPath || p.Surname == searchPath).FirstOrDefault();
            if (result == null)
            {
                Console.WriteLine("  Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("  * Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("  * Yeniden denemek için      : (2)");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        return;
                    case 2:
                        Delete();
                        break;
                }
            }
            else
            {
                Person person = new Person();
                Console.WriteLine("Lütfen isim giriniz             : ");
                person.Name = Console.ReadLine();
                Console.WriteLine("Lütfen soyisim giriniz          : ");
                person.Surname = Console.ReadLine();
                Console.WriteLine("Lütfen telefon numarası giriniz : ");
                person.PhoneNumber = Console.ReadLine();
                persons.Remove(result);
                persons.Add(person);
            }
        }
    }
}