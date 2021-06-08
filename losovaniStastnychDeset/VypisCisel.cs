using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace losovaniStastnychDeset
{
    public class VypisCisel
    {
        private StringBuilder sb;
        private bool konzole, okno, soubor, builder;

        public VypisCisel()
        {
            sb = new StringBuilder();
            SetVypis();
        }

        public StringBuilder GetStringBuilder()
        {
            return sb;
        }

        public void Vypis(int cislo)
        {
            if (konzole) VypisDoKonzole(cislo);
            if (okno) VypisDoOutputOkna(cislo);
            if (soubor) VypisDoSouboru(cislo);
            if (builder) VypisDoStringBuilder(cislo);
        }

        private void VypisDoKonzole(int cislo)
        {
            Console.WriteLine(cislo);
        }

        private void VypisDoOutputOkna(int cislo)
        {
            Debug.WriteLine(cislo);
        }

        private void VypisDoSouboru(int cislo)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter("LosovaniStastnych10.txt", true))
            {
                outputFile.WriteLine(cislo);
            }
        }

        private void VypisDoStringBuilder(int cislo)
        {
            sb.Append(cislo + " ");
        }

        private void SetVypis()
        {
            using (StreamReader sr = new StreamReader("app.config"))
            {
                if (sr.ReadLine().Equals("1")) konzole = true;
                else konzole = false;

                if (sr.ReadLine().Equals("1")) okno = true;
                else okno = false;

                if (sr.ReadLine().Equals("1")) soubor = true;
                else soubor = false;

                if (sr.ReadLine().Equals("1")) builder = true;
                else builder = false;
            }
        }
    }
}
