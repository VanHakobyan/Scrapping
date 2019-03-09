using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocxParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WordprocessingDocument doc = WordprocessingDocument.Open
                (@"E:\Download\Sample.docx", false))
            {
               
                // Add a main document part.
                Body body = doc.MainDocumentPart.Document.Body;
                string content = body.InnerText;
                foreach (var par in body.ChildElements)
                {
                    Console.WriteLine(par.InnerText);

                    var imageParts = (from graphic in par.Descendants<DocumentFormat.OpenXml.Drawing.Graphic>()
                        let graphicData = graphic.Descendants<DocumentFormat.OpenXml.Drawing.GraphicData>()
                            .FirstOrDefault()
                        let pic = graphicData.ElementAt(0)
                        let nvPicPrt = pic.ElementAt(0).FirstOrDefault()
                        let blip = pic.Descendants<DocumentFormat.OpenXml.Drawing.Blip>().FirstOrDefault()
                        select new
                        {
                            Id = blip.GetAttribute("embed", "xr"),
                            Filename = nvPicPrt.GetAttribute("name", "xpic")
                        }).ToList();
                    Console.WriteLine(string.Join("+++",imageParts.Select(x=>x.Filename)));
                }

            }
        }
    }
}
