using P04Zawodnicy.Shared.Domain;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P02ZawodnicyNoweOkna.Tools
{
    internal class PDFManager
    {
        private readonly string sciezka;

        public PDFManager(string sciezka)
        {
            this.sciezka = sciezka;
        }

        public void WygenerujPDF(Zawodnik[] zawodnicy)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Raport zawodnicy";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            // Draw the text
            for (int i = 0; i < zawodnicy.Length; i++)
            {
                gfx.DrawString(zawodnicy[i].ImieNazwisko, font, XBrushes.Aqua, 20, 50 + 25 * i);
            }

            // Save the document...
          //  const string filename = "HelloWorld.pdf";
            document.Save(sciezka);
        }
    }
}
