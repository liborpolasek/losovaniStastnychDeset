using System;
using System.Collections.Generic;
using System.Text;

namespace losovaniStastnychDeset
{
    public class Report
    {
        private readonly List<int> cisla;
        private readonly DateTime start;
        private readonly DateTime end;
        private readonly String losujici;
        private readonly String notar;

        private String header;
        private String body;
        private String footer;

        public Report(List<int> cisla, DateTime start, DateTime end, String losujici, String notar)
        {
            this.cisla = cisla;
            this.start = start;
            this.end = end;
            this.losujici = losujici;
            this.notar = notar;
            SetBody();
        }

        private void SetBody()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Losovana cisla jsou: ");
            foreach(int i in cisla)
            {
                sb.Append(i);
                sb.Append(" ");
            }
            sb.AppendLine();
            sb.Append("Losujicim byl: ");
            sb.AppendLine(losujici);
            sb.Append("Notarem byl: ");
            sb.AppendLine(notar);
            sb.Append("Losovat se zacalo v: ");
            sb.AppendLine(start.ToString());
            sb.Append("Losovani skoncilo v: ");
            sb.AppendLine(end.ToString());
            body = sb.ToString();
        }

        public void SetHeader(String text)
        {
            this.header = text;
        }

        public void SetFooter(String text)
        {
            this.footer = text;
        }

        public void ExportToTxt()
        {

        }

        public void ExportToHtml()
        {

        }

        public void ExportToPdf()
        {

        }

        public void ExportToBitmap()
        {

        }
    }
}
