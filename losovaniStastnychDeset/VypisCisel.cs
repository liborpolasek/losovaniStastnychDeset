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
        private String file;

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
            StreamWriter outputFile = null;
            try
            {
                outputFile = new StreamWriter(file, true);
                outputFile.WriteLine(cislo);
                outputFile.Flush();
                outputFile.Close();
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void VypisDoStringBuilder(int cislo)
        {
            sb.Append(cislo + " ");
        }

        private void SetVypis()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("app.config");

                if (sr.ReadLine().Equals("1")) konzole = true;
                else konzole = false;

                if (sr.ReadLine().Equals("1")) okno = true;
                else okno = false;

                if (sr.ReadLine().Equals("1"))
                {
                    soubor = true;
                    String dateTime = DateTime.Now.ToString().Replace(".", "_").Replace(":", "_");
                    file = "LosovaniStastnych10_" + dateTime + ".txt";
                }
                else soubor = false;

                if (sr.ReadLine().Equals("1")) builder = true;
                else builder = false;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Soubor 'app.config' nebyl nalezen. Vypis je nastaven jen pro konzoli.");
            }
            finally 
            {
                if (sr == null) konzole = true;
            }
        }
    }
}
