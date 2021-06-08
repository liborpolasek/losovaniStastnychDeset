using System;
using System.IO;

using losovaniStastnychDeset.TahaniCisel;

namespace losovaniStastnychDeset
{
    public class Program
    {
        static void Main(string[] args)
        {
            ITahaniCisel tahani;
            int hodKostkou;

            Console.WriteLine("Zadejte cislo hozene kostkou:");
            while (true)
            {
                int.TryParse(Console.ReadLine(), out int n);
                if (n >= 1 && n <= 6)
                {
                    hodKostkou = n;
                    break;
                } 
                else
                {
                    Console.WriteLine("Nebylo zadano cislo mezi 1 a 6. Zadejte nove cislo:");
                }
            }

            switch (hodKostkou)
            {
                case 1:
                    tahani = new TahaniCisel1();
                    break;
                case 2:
                    tahani = new TahaniCisel2();
                    break;
                case 3:
                    tahani = new TahaniCisel3();
                    break;
                case 4:
                    tahani = new TahaniCisel4();
                    break;
                case 5:
                    tahani = new TahaniCisel5();
                    break;
                case 6:
                    tahani = new TahaniCisel6();
                    break;
                default:
                    tahani = new TahaniCisel1();
                    break;
            }

            VypisCisel vypis = new VypisCisel();
            DateTime start = DateTime.Now;
            for (int i = 0; i <= 9; i++)
            {
                vypis.Vypis(tahani.NextNumber());
            }
            DateTime end = DateTime.Now;

            Report rep = new Report(tahani.getNumbers(), start, end, "Petr Novak", "Eva Nova");
            rep.ExportToTxt();

        }
    }
}
