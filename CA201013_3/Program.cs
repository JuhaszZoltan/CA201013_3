using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201013_3
{
    class Diak
    {
        public string Nev { get; set; }
        public int Kor { get; set; }
        public int SzulEv
        {
            get
            {
                return DateTime.Now.Year - Kor;
            }
        }

        public int GetSzulEv()
        {
            return DateTime.Now.Year - Kor;
        }
        public Diak() { }
        public Diak(string nev, int kor)
        {
            Nev = nev;
            Kor = kor;
        }
    }

    static class Matek
    {
        static public double pi = 3.14;
        static public int Hatvanyozas(int ezt, int ennyiedikre)
        {
            int x = 1;
            for (int i = 0; i < ennyiedikre; i++)
            {
                x *= ezt;
            }
            return x;
        }
    }
    class Program
    {
        static void Main()
        {
            var d = new Diak { Kor = 30, Nev = "Zoli" };
            Console.WriteLine(d.SzulEv);
            Console.ReadKey();
        }

        static void Tombbel()
        {
            var diakTomb = new Diak[5];
            for (int i = 0; i < diakTomb.Length; i++)
            {
                Console.WriteLine($"{i + 1}. diák neve: ");
                var nev = Console.ReadLine();

                Console.WriteLine($"{i + 1}. diák kor: ");
                var kor = int.Parse(Console.ReadLine());

                //diakTomb[i] = new Diak { Nev = nev, Kor = kor };
                diakTomb[i] = new Diak(nev, kor);
                //diakTomb[i] = new Diak(kor: 12, nev: "Józsi");
            }
        }
        static void Listaval()
        {
            var diakLista = new List<Diak>();
            int sorszam = 1;
            do
            {
                Console.WriteLine($"{sorszam}. diák neve: ");
                var nev = Console.ReadLine();
                Console.WriteLine($"{sorszam}. diák kor: ");
                var kor = int.Parse(Console.ReadLine());

                diakLista.Add(new Diak(nev, kor));
                sorszam++;
                Console.WriteLine("Esc vagy Enter");

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}
