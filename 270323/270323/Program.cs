namespace _270323
{
    internal class Program
    {

        static Hrac h = new Hrac("Alfred", 100, true);
    
        static void Main(string[] args)
        {

            Thread thr = new Thread(poskozeni);
            thr.Start();
            thr.Join();

            h.vypis();

            Thread thr1 = new Thread(oziveni);
            thr1.Start();
            thr1.Join();

            h.vypis();

        }

        public static void poskozeni()
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            { 
                int hodnota = r.Next(10);
                h.snizeni(hodnota);
            }
       
        }

        public static void oziveni()
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int hodnota = r.Next(10);
                h.zvyseni(hodnota);
            }

        }
    }
}