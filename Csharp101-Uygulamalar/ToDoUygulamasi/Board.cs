using System;

namespace ToDoUygulamasi
{
    public class Board : IBoard
    {
        ToDoKart toDoKart;
        InProgressKart ınProgressKart;
        DoneKart doneKart;
        Kart kart;
        KisiAdd kisi;

        public Board(){
            toDoKart = new ToDoKart();
            ınProgressKart = new InProgressKart();
            doneKart = new DoneKart();
            kart = new Kart();
            kisi = new KisiAdd();
            
            Console.WriteLine
            (
                "Lütfen yapmak istediğiniz işlemi seçiniz\n" +
                "****************************************\n" +
                "(1) Board Listelemek\n" +
                "(2) Board'a Kart Eklemek\n" +
                "(3) Board'dan Kart Silmek\n" +
                "(4) Kart Taşımak"
            );

            switch (Console.ReadLine())
            {
                case "1":
                    List();
                    break;
                case "2":
                    Add();
                    break;
                case "3":
                    Delete();
                    break;
                case "4":
                    Update();
                    List();
                    break;
                default:
                    break;
            }
            
        }
        public void Add()
        {
            Console.Write("Başlık Giriniz: ");
            kart.Baslik = Console.ReadLine();

            Console.Write("İçerik Giriniz: ");
            kart.Icerik = Console.ReadLine();

            Console.Write("Büyüklük Seçiniz -> Xs(1), S(2), M(3), L(4), Xl(5): ");
            kart.Buyukluk = (Boyut)int.Parse(Console.ReadLine());

            Console.Write("Kişi Id giriniz: ");
            kart.Kisi = int.Parse(Console.ReadLine());

            int temp = 0;
            foreach (var member in kisi.List())
            {
                if (member.Id == kart.Kisi)
                {
                    temp ++;
                    toDoKart.Add(kart);
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Hatalı giriş yaptınız, girilen Id' ye aiy bir kullanıcı bulunamadı.");
            }
            else
            {
                Console.WriteLine("Kart ekleme işlemi gerçekleşti.");
            }
        }
        public void Delete()
        {
            Console.WriteLine("Silmek istedğiniz kartı seçiniz.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string baslik = Console.ReadLine();

            int temp = 0;
            foreach (var item in toDoKart.List())
            {
                if (item.Baslik == baslik)
                {
                    temp ++;
                    toDoKart.Delete(item);
                    Console.WriteLine("Silme işleminiz gerçekleşti.");
                    break;
                }
            }
            foreach (var item in ınProgressKart.List())
            {
                if (item.Baslik == baslik)
                {
                    temp++;
                    ınProgressKart.Delete(item);
                    Console.WriteLine("Silme işleminiz gerçekleşti.");
                    break;
                }
            }
            foreach (var item in doneKart.List())
            {
                if (item.Baslik == baslik)
                {
                    temp++;
                    doneKart.Delete(item);
                    Console.WriteLine("Silme işleminiz gerçekleşti.");
                    break;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart tahtada bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Silmeyi sonlandırmak için: 1 seçiniz. ");
                Console.WriteLine("Yeniden denemek için : 2 seçiniz. ");
                string selected = Console.ReadLine();
                switch (selected)
                {
                    case "1":
                        break;
                    case "2":
                        Delete();
                        break;
                }

            }
        }
        public void List()
        {
            Console.WriteLine("ToDo List\n" + "****************************************");
            if (toDoKart.List().Count == 0)
            {
                Console.WriteLine("Liste Boş");
            }
            else
            {
                foreach (var kart in toDoKart.List())
                {
                    Console.WriteLine("Başlık      :{0}", kart.Baslik);
                    Console.WriteLine("İçerik      :{0}", kart.Icerik);
                    Console.WriteLine("Atanan Kişi :{0}", kart.Kisi);
                    Console.WriteLine("Büyüklük    :{0}", kart.Buyukluk);
                }
            }

            Console.WriteLine("***** In Progress List *****");
            if (ınProgressKart.List().Count == 0)
            {
                Console.WriteLine("Liste Boş");
            }
            else
            {
                foreach (var kart in ınProgressKart.List())
                {
                    Console.WriteLine("Başlık      :{0}", kart.Baslik);
                    Console.WriteLine("İçerik      :{0}", kart.Icerik);
                    Console.WriteLine("Atanan Kişi :{0}", kart.Kisi);
                    Console.WriteLine("Büyüklük    :{0}", kart.Buyukluk);
                }
            }

            Console.WriteLine("***** Done List *****");
            if (doneKart.List().Count == 0)
            {
                Console.WriteLine("Liste Boş");
            }
            else
            {
                foreach (var kart in doneKart.List())
                {
                    Console.WriteLine("Başlık      :{0}", kart.Baslik);
                    Console.WriteLine("İçerik      :{0}", kart.Icerik);
                    Console.WriteLine("Atanan Kişi :{0}", kart.Kisi);
                    Console.WriteLine("Büyüklük    :{0}", kart.Buyukluk);
                    Console.WriteLine("-");
                }
            }
        }
        public void Update()
        {
            Console.WriteLine("Değiştirmek istediğiniz kartı seçin.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string baslik = Console.ReadLine();
            Console.WriteLine("***** Bulunan kart bilgileri *****");
            int temp = 0;
            foreach (var item in toDoKart.List())
            {
                if (item.Baslik == baslik)
                {
                    temp ++;
                    Console.WriteLine("Başlık : {0}", item.Baslik);
                    Console.WriteLine("İçerik : {0}", item.Icerik);
                    Console.WriteLine("Kişi : {0}", item.Kisi);
                    Console.WriteLine("Büyüklük : {0}", item.Buyukluk);
                    Console.WriteLine("Line : ToDo");

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                    Console.WriteLine("(1) ToDo");
                    Console.WriteLine("(2) In Progress");
                    Console.WriteLine("(3) Done");

                    string selected = Console.ReadLine();
                    switch (selected)
                    {
                        case "1":
                            Console.WriteLine("Taşımak istediğin kart bu Line'da!");
                            break;
                        case "2":
                            toDoKart.Update(item, ınProgressKart.List());
                            Console.WriteLine("Taşıma işlemi gerçekleştirildi.");
                            break;
                        case "3":
                            toDoKart.Update(item, doneKart.List());
                            Console.WriteLine("Taşıma işlemi gerçekleştirildi.");
                            break;
                    }
                }
                break;
            }

            foreach (var item in ınProgressKart.List())
            {
                if (item.Baslik == baslik && temp == 0)
                {
                    temp++;
                    Console.WriteLine("Başlık : {0}", item.Baslik);
                    Console.WriteLine("İçerik : {0}", item.Icerik);
                    Console.WriteLine("Kişi : {0}", item.Kisi);
                    Console.WriteLine("Büyüklük : {0}", item.Buyukluk);
                    Console.WriteLine("Line : InProgress ");

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                    Console.WriteLine("(1) ToDo");
                    Console.WriteLine("(2) In Progress");
                    Console.WriteLine("(3) Done");

                    string selected = Console.ReadLine();

                    switch (selected)
                    {
                        case "1":
                            ınProgressKart.Update(item, toDoKart.List());
                            Console.WriteLine("Taşıma işlemi gerçekleştirildi.");
                            break;
                        case "2":
                            Console.WriteLine("Taşımak istediğin kart bu Line'da!");
                            break;
                        case "3":
                            ınProgressKart.Update(item, doneKart.List());
                            Console.WriteLine("Taşıma işlemi gerçekleştirildi.");
                            break;
                    }
                }
                break;
            }
            
            foreach (var item in doneKart.List())
            {
                if (item.Baslik == baslik && temp == 0)
                {
                    temp++;
                    Console.WriteLine("Başlık : {0}", item.Baslik);
                    Console.WriteLine("İçerik : {0}", item.Icerik);
                    Console.WriteLine("Kişi : {0}", item.Kisi);
                    Console.WriteLine("Büyüklük : {0}", item.Buyukluk);
                    Console.WriteLine("Line : Done ");

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                    Console.WriteLine("(1) ToDo");
                    Console.WriteLine("(2) In Progress");
                    Console.WriteLine("(3) Done");

                    string selected = Console.ReadLine();

                    switch (selected)
                    {
                        case "1":
                            doneKart.Update(item, toDoKart.List());
                            Console.WriteLine("Taşıma işlemi gerçekleştirildi.");
                            break;
                        case "2":
                            doneKart.Update(item, ınProgressKart.List());
                            Console.WriteLine("Taşıma işlemi gerçekleştirildi.");
                            break;

                        case "3":
                            Console.WriteLine("Taşımak istediğin kart bu Line'da!");
                            break;
                    }
                }
                break;
            }

            if (temp == 0)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Taşıma işlemini sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için : (2)");

                string selected = Console.ReadLine();
                switch (selected)
                {
                    case "1":
                        break;
                    case "2":
                        Update();
                        break;
                }
            }
        }
    }
}