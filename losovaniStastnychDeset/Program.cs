using System;
using System.IO;

using losovaniStastnychDeset.TahaniCisel;

namespace losovaniStastnychDeset
{
    class Program
    {
        static void Main(string[] args)
        {
            ITahaniCisel tahani;
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
                    tahani = new TahaniCisel1();
                    break;
                case 4:
                    tahani = new TahaniCisel1();
                    break;
                case 5:
                    tahani = new TahaniCisel1();
                    break;
                case 6:
                    tahani = new TahaniCisel1();
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
        }
    }
}
