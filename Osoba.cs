using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie
{
    internal class Osoba
    {
        string imie;
        string nazwisko;


        public Osoba (string imie,string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;

        }

        public virtual void Wypisz()
        {
            Console.WriteLine("Imie: "+imie);
            Console.WriteLine("Nazwisko: "+nazwisko);
        }

        public virtual void Zapisz()
        {
            Console.Write("Podaj imie: ");
            imie = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            nazwisko = Console.ReadLine();
            
        }
        


    }
}
