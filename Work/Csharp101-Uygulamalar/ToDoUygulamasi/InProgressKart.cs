using System.Collections.Generic;

namespace ToDoUygulamasi
{
    public class InProgressKart : IKart
    {
        List<Kart> InProgressList;
        public InProgressKart()
        {
            InProgressList = new List<Kart>
            {
                new Kart{
                    Baslik   = "Eğitim",
                    Icerik   = "Lise",
                    Kisi     = 5,
                    Buyukluk = Boyut.L
                }
            };
        }
        public void Add(Kart kart)
        {
            InProgressList.Add(kart);
        }

        public void Delete(Kart kart)
        {
            InProgressList.Remove(kart);
        }

        public List<Kart> List()
        {
            return InProgressList;
        }

        public void Update(Kart kart, List<Kart> newList)
        {
            newList.Add(kart);
            Delete(kart);
        }
    }
}