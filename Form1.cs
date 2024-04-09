using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace TransformarPDF
{
    class Program
    {
        public static StringBuilder stringbuilder = new StringBuilder();
        public static StringBuilder StringBuilder { get; private set; }

        static void Main(string[] args, StringBuilder stringbuilder)
        {
            String ElArchivo = @"C:\Users\wkldl\Downloads\List_of_dielectric_constants_EN.pdf";
            using (PdfReader reader = new PdfReader(ElArchivo))
            {
                for (int pag = 1; pag <= reader.NumberOfPages; pag++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string text = PdfTextExtractor.GetTextFromPage(reader, pag, strategy);
                    text = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes.(text)))stringbuilder = stringbuilder =sb.Append(text);

                }
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}