using System;

namespace Abstract_Sinif
{
    class Program
    {
        static void Main(string[] args)
        {
            NewFocus focus1 = new NewFocus();
            Console.WriteLine(focus1.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus1.KacTekerlektenOlusur());
            Console.WriteLine(focus1.StandartRengiNe().ToString());

            Console.WriteLine("-------------------");

            NewCivic civic1 = new NewCivic();
            Console.WriteLine(civic1.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic1.KacTekerlektenOlusur());
            Console.WriteLine(civic1.StandartRengiNe().ToString());
        }
    }
}
