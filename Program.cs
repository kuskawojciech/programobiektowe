using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {

          

            Osoba o1 = new Osoba("","");
            Uczen u1 = new Uczen("", "","","","");
            Osoba o2 = new Osoba("", "");
            Uczen u2 = new Uczen("", "", "", "", "");

            o1.Zapisz();
            Console.WriteLine();
            o2.Zapisz();
            Console.WriteLine();
            u1.Zapisz();
            Console.WriteLine();
            u2.Zapisz();
            Console.WriteLine();

            List<Osoba> osoby = new List<Osoba>();
            osoby.Add(o1);
            osoby.Add(o2);
            osoby.Add(u2);
            osoby.Add(u1);

            foreach(Osoba ps in osoby)
            {
                ps.Wypisz();
                Console.WriteLine();
            }

            BinaryFormatter bf3 = new BinaryFormatter();

            using (Stream fStream = new FileStream("Osoby.dat", FileMode.Create, FileAccess.Write))
            {
                
                bf3.Serialize(fStream, osoby);
                
            }


            Console.ReadKey();

        }
    }
}
