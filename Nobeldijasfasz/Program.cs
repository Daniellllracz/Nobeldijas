using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Nobeldijasfasz
{
    class Program
    {
        static void Main(string[] args)
        {
            var dijazotak = new List<Dijazotak>();
            using var sr = new StreamReader(@"..\..\..\src\orvosi_nobeldijak.txt",
            Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream) dijazotak.Add(new(sr.ReadLine()));

            Console.WriteLine($"3.feladat {dijazotak.Count}fő");
            var f4 = dijazotak.Max(d => d.Ev);
            Console.WriteLine($"4.feladat {f4}ben");
            Console.Write("Kérem adja meg egy ország kódját: ");
            string ok = Console.ReadLine();
            var f5 = dijazotak.Where(d => d.Orszag == ok).ToList();
            if (f5.Count == 0) Console.WriteLine("\t A megadott országnak nem volt díjazotja");
            else if (f5.Count == 1)
            {
                Console.WriteLine("\t A megadott országnak dijazotja");
                Console.WriteLine($"\tNév {f5[0].Nev}");
                Console.WriteLine($"\tNév {f5[0].Ev}");
                Console.WriteLine($"\tNév {f5[0].SztSztr}");
            }

            


            
        }
    }
}
