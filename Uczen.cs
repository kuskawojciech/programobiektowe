using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie
{
    internal class Uczen : Osoba
    {
        string klasa;
        string srednia;
        string jezyk;

        public Uczen(string imie, string nazwisko, string klasa,string srednia, string jezyk) : base(imie, nazwisko)
        {
            this.klasa = klasa;
            this.srednia = srednia;
            this.jezyk = jezyk;

        }

        public override void Zapisz()
        {
            base.Zapisz();
            Console.Write("Podaj klase: ");
            klasa = Console.ReadLine();
            Console.Write("Podaj srednia: ");
            srednia = Console.ReadLine();
            Console.Write("Podaj język, którego się uczy: ");
            jezyk = Console.ReadLine();
            
        }

        public override void Wypisz()
        {
            base.Wypisz();
            Console.WriteLine("Klasa: "+klasa);
            Console.WriteLine("Średnia: "+srednia);
            Console.WriteLine("Język: "+jezyk);
        }


    }
}
