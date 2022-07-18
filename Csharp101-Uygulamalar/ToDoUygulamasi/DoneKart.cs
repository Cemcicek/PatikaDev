using System.Collections.Generic;

namespace ToDoUygulamasi
{
    public class DoneKart : IKart
    {
        List<Kart> DoneList;
        public DoneKart(){
            DoneList = new List<Kart> {};
        }

        public void Add(Kart kart)
        {
            DoneList.Add(kart);
        }

        public void Delete(Kart kart)
        {
            DoneList.Remove(kart);
        }

        public List<Kart> List()
        {
            return DoneList;
        }

        public void Update(Kart kart, List<Kart> newList)
        {
            newList.Add(kart);
            Delete(kart);
        }
    }
}