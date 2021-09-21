using System.Collections.Generic;

namespace ToDoUygulamasi
{
    public interface IKart{
        List<Kart> List();
        void Add(Kart kart);
        void Delete(Kart kart);
        void Update(Kart kart, List<Kart> newList);
    }
}