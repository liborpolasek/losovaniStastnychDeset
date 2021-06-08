using System;
using System.IO;

using losovaniStastnychDeset.TahaniCisel;

namespace losovaniStastnychDeset
{
    class Program
    {
        static void Main(string[] args)
        {
            ITahaniCisel tahani = null;
            int hodKostkou = 1;
            switch (hodKostkou)
            {
                case 1:
                    tahani = new TahaniCisel1();
                    break;
                case 2:
                    tahani = new TahaniCisel2();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    tahani = new TahaniCisel1();
                    break;
            }

            using (StreamReader sr = new StreamReader(@"app.config"))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            DateTime start = DateTime.Now;
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(tahani.NextNumber());
            }
            DateTime end = DateTime.Now;

            tahani.getNumbers().ForEach(i => Console.Write("{0}\t", i));
        }
    }
}
