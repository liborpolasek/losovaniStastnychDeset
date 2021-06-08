using System;
using System.Collections.Generic;
using System.Text;

namespace losovaniStastnychDeset
{
    public class TahaniCisel1 : ITahaniCisel
    {
        private List<int> tazenaCisla;

        public TahaniCisel1()
        {
            this.tazenaCisla = new List<int>();
        }

        public List<int> getNumbers()
        {
            this.tazenaCisla.Sort();
            return this.tazenaCisla;
        }

        public int NextNumber()
        {
            Random r = new Random();
            int number = r.Next(1, 80);

            while (this.tazenaCisla.Contains(number))
            {
                number = r.Next(1, 80);
            }
            this.tazenaCisla.Add(number);
            return number;
        }
    }
}
