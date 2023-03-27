
using System.Collections.Concurrent;

namespace _200323
{
    internal class Program
    {
        static Citac c = new Citac(50);
        static List<int> s = new List<int>();
        static       ConcurrentBag<int> cb = new ConcurrentBag<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

/*            Thread thr = new Thread(milSnizeni);
            thr.Start();
            thr.Join();
*/

            Thread thr2 = new Thread(milZvyseni);
            thr2.Start();
            thr2.Join();

            //   c.Snizeni();
            //   c.Zvyseni();


            c.Vypis();
            //Console.WriteLine(c);



            Thread thr3 = new Thread(Listicek);
            thr3.Start();
            thr3.Join();

            Thread thr4 = new Thread(Listicek);
            thr4.Start();
            thr4.Join();



            if (s.Count == 2000000) {
                Console.WriteLine("s");
            }
            else { Console.WriteLine("n"); }

        

        Thread thr5 = new Thread(Listicek1);
        thr5.Start();
            thr5.Join();

            Thread thr6 = new Thread(Listicek1);
        thr6.Start();
            thr6.Join();



            if (cb.Count == 2000000) {
                Console.WriteLine("s");
            }
            else { Console.WriteLine("n"); }

        }

       public static void milSnizeni()
        {
            for (int i = 0; i < 1000000 ; i++)
            {
                c.Snizeni();
            }
        }

        public static void milZvyseni()
        {
            for (int i = 0; i < 1000000; i++)
            {
                c.Zvyseni();
            }
        }

        public static void Listicek()
        {
            Random r = new Random(10);
            for (int i = 0; i < 1000000; i++)
            {
                int wtd = r.Next(10); 
                s.Add(wtd);
            }
   
        }

        public static void Listicek1()
        {
            Random r = new Random(10);
            List<Task> bagAddTasks = new List<Task>();
            for (int i = 0; i < 1000000; i++)
            {
                int wtd = r.Next(10);
                bagAddTasks.Add(Task.Run(() => cb.Add(wtd)));

            }
            Task.WaitAll(bagAddTasks.ToArray());
        }


    }
}