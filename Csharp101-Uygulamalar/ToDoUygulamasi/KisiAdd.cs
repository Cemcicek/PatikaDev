using System.Collections.Generic;

namespace ToDoUygulamasi
{
    public class KisiAdd : IKisi
    {
        List<Kisi> Takim;
        public KisiAdd(){
            Takim = new List<Kisi>{
                new Kisi{ Id=1, Ad="Cem", Soyad="Çiçek"},
                new Kisi{ Id=2, Ad="Ahmet", Soyad="Yılmaz"},
                new Kisi{ Id=3, Ad="Duru", Soyad="Demir"},
                new Kisi{ Id=4, Ad="Aslı", Soyad="Aslan"},
                new Kisi{ Id=5, Ad="İsmail", Soyad="Çelik"}
            };
        }
        public List<Kisi> List()
        {
            return Takim;
        }
    }
}