using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobeldijasfasz
{
    class Elethossz
    {
        public int Ev { get; set; }
        public string Nev { get; set; }
        public string SzuletesHalalozas { get; set; }
        public string OrszagKod { get; set; }

        public Elethossz(int ev, string nev, string szuletesHalalozas, string orszagKod, int tol, int ig)
        {
            Ev = ev;
            Nev = nev;
            SzuletesHalalozas = szuletesHalalozas;
            OrszagKod = orszagKod;
            Tol = tol;
            Ig = ig;
        }

        private int Tol { get; set; }
            private int Ig { get; set; }
            public int ElethosszEvekben => Tol == -1 || Ig == -1 ? -1 : Ig - Tol;

            public bool IsmertAzElethossz => ElethosszEvekben != -1;

            public Elethossz(string SzuletesHalalozas)
            {
                string[] m = SzuletesHalalozas.Split('-');
                try
                {
                    Tol = int.Parse(m[0]);
                }
                catch (Exception)
                {
                    Tol = -1;
                }
                try
                {
                    Ig = int.Parse(m[1]);
                }
                catch (Exception)
                {
                    Ig = -1;
                }


            }
        }
}

