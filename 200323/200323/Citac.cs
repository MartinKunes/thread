using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200323
{
    internal class Citac
    {

        int hodnota;

        public Citac(int hodnota)
        {
            this.hodnota = hodnota;
        }

        public int Hodnota
        {
            get { return hodnota; }   
            set { hodnota = value; }
        }


        public void Snizeni()
        {
            hodnota--;
            
        }

        public void Zvyseni()
        {
            hodnota++;
         
        }

        public void Vypis()
        {
            Console.WriteLine(hodnota);  

        }




    }

}
