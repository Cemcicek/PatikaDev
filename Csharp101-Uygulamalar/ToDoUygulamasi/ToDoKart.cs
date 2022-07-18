using System.Collections.Generic;

namespace ToDoUygulamasi
{
    public class ToDoKart : IKart
    {
        List<Kart> ToDoList;
        public ToDoKart()
        {
            ToDoList = new List<Kart>
            {
                new Kart{
                    Baslik   = "Teknoloji",
                    Icerik   = "Baskı",
                    Kisi     = 6,
                    Buyukluk = Boyut.M
                },
                new Kart{
                    Baslik   = "Emlak",
                    Icerik   = "Ev&Yazlık",
                    Kisi     = 4,
                    Buyukluk = Boyut.XL
                }
            };
        }
        public void Add(Kart kart)
        {
            ToDoList.Add(kart);
        }

        public void Delete(Kart kart)
        {
            ToDoList.Remove(kart);
        }

        public List<Kart> List()
        {
            return ToDoList;
        }

        public void Update(Kart kart, List<Kart> newList)
        {
            newList.Add(kart);
            Delete(kart);
        }
    }
}