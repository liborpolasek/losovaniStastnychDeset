using System;
using System.Collections.Generic;
using System.Text;

namespace losovaniStastnychDeset
{
    class VypisCisel
    {
        public VypisCisel()
        {

        }

        public void Vypis(List<int> cisla)
        {
            VypisDoKonzole(cisla);
        }

        private void VypisDoKonzole(List<int> cisla)
        {
            foreach (int cislo in cisla)
            {
                Console.WriteLine(cislo);
            }
        }
    }
}
