using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _270323
{
    internal class Hrac
    {

        string jmeno;
        int zdravi;
        bool zivej;

        private Object o = new object();

        public string Jmeno { get { return jmeno; } set { jmeno = value; } }

        public int Zdravi { get { return zdravi; } set { zdravi = value; } }
        public bool Zivej { get { return zivej; } set { zivej = value; } }


        public Hrac(string jmeno, int zdravi, bool zivej)
        {
            Jmeno = jmeno;
            Zdravi = zdravi;
            Zivej = zivej;
        }


        public void zvyseni(int hodnota) {

            lock (o)
            {
                if (zdravi > 0)
                {
                    zdravi += hodnota;
                }
                else if (zdravi < 0)
                {

                    zivej = false;
                    Console.WriteLine("hráč není živej");
                }


            }

        }

        public void snizeni(int hodnota)
        {

            lock (o)
            {
                if (zdravi > 0)
                {
                    zdravi -= hodnota;
                }
                else if (zdravi < 0)
                {

                    zivej = false;
                    Console.WriteLine("hráč není živej");
                }


            }

        }

    



        public void vypis() {
            Console.WriteLine(jmeno + " " + zdravi + " " + zivej);
        }



    }
}
