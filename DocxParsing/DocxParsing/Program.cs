using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using HtmlAgilityPack;
using Newtonsoft.Json;
using OpenXmlPowerTools;

namespace DocxParsing
{
    public struct ImageCollection
    {
        public string Question { get; set; }
        public string Images { get; set; }
    }
    class Program
    {
        public class QuestionList
        {
            public string Question { get; set; }//here can be text if image is ther put img src and and image extracted
            public int questionNo { get; set; }
            public string Answer { get; set; }//here can be text if image is ther put img src and and image extracted
        }

        public class QuestionViewModel
        {
            public string ChapterName { get; set; }
            public string Exercise { get; set; }

            public List<QuestionList> QuestionLists { get; set; }
        }
        private static string ParseDOCX(FileInfo fileInfo)
        {
            try
            {
                byte[] byteArray = File.ReadAllBytes(fileInfo.FullName);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    memoryStream.Write(byteArray, 0, byteArray.Length);
                    using (WordprocessingDocument wDoc =
                                              WordprocessingDocument.Open(memoryStream, true))
                    {
                        int imageCounter = 0;
                        var pageTitle = fileInfo.FullName;
                        var part = wDoc.CoreFilePropertiesPart;
                        if (part != null)
                            pageTitle = (string)part.GetXDocument()
                                                    .Descendants(DC.title)
                                                    .FirstOrDefault() ?? fileInfo.FullName;

                        WmlToHtmlConverterSettings settings = new WmlToHtmlConverterSettings()
                        {
                            AdditionalCss = "body { margin: 1cm auto; max-width: 20cm; padding: 0; }",
                            PageTitle = pageTitle,
                            FabricateCssClasses = true,
                            CssClassPrefix = "pt-",
                            RestrictToSupportedLanguages = false,
                            RestrictToSupportedNumberingFormats = false,
                            ImageHandler = imageInfo =>
                            {
                                ++imageCounter;
                                string extension = imageInfo.ContentType.Split('/')[1].ToLower();
                                ImageFormat imageFormat = null;
                                if (extension == "png") imageFormat = ImageFormat.Png;
                                else if (extension == "gif") imageFormat = ImageFormat.Gif;
                                else if (extension == "bmp") imageFormat = ImageFormat.Bmp;
                                else if (extension == "jpeg") imageFormat = ImageFormat.Jpeg;
                                else if (extension == "tiff")
                                {
                                    extension = "gif";
                                    imageFormat = ImageFormat.Gif;
                                }
                                else if (extension == "x-wmf")
                                {
                                    extension = "wmf";
                                    imageFormat = ImageFormat.Wmf;
                                }

                                if (imageFormat == null) return null;

                                string base64 = null;
                                try
                                {
                                    using (MemoryStream ms = new MemoryStream())
                                    {
                                        imageInfo.Bitmap.Save(ms, imageFormat);
                                        var ba = ms.ToArray();
                                        base64 = System.Convert.ToBase64String(ba);
                                    }
                                }
                                catch (System.Runtime.InteropServices.ExternalException)
                                { return null; }

                                ImageFormat format = imageInfo.Bitmap.RawFormat;
                                ImageCodecInfo codec = ImageCodecInfo.GetImageDecoders()
                                                          .First(c => c.FormatID == format.Guid);
                                string mimeType = codec.MimeType;

                                string imageSource =
                                       string.Format("data:{0};base64,{1}", mimeType, base64);

                                XElement img = new XElement(Xhtml.img,
                                      new XAttribute(NoNamespace.src, imageSource),
                                      imageInfo.ImgStyleAttribute,
                                      imageInfo.AltText != null ?
                                           new XAttribute(NoNamespace.alt, imageInfo.AltText) : null);
                                return img;
                            }
                        };

                        XElement htmlElement = WmlToHtmlConverter.ConvertToHtml(wDoc, settings);
                        var html = new XDocument(new XDocumentType("html", null, null, null),
                                                                                    htmlElement);
                        var htmlString = html.ToString(SaveOptions.DisableFormatting);
                        return htmlString;
                    }
                }
            }
            catch
            {
                return "File contains corrupt data";
            }
        }
        static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo(@"..\..\Sample1.docx");
            var docx = ParseDOCX(fileInfo);
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(docx);

            var exNodes = document.DocumentNode.SelectSingleNode(".//body").ChildNodes.Skip(1).ToList();
            var lista = new List<string>();
            for (var index = 0; index < exNodes.Count; index++)
            {

                var exNode = exNodes[index];
                var exNodeInnerText = exNode.InnerText;
                var list = exNodeInnerText.Split(new[] { "Answer" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                lista.AddRange(list);
                var questionViewModel = new QuestionViewModel
                {
                    //ChapterName = "Exercise",
                    Exercise = "Exercise {index}"
                };

            }

            var @join = string.Join(" ", lista.Where(x => x != null));
            var strings = @join.Split(new[] { "Question" }, StringSplitOptions.RemoveEmptyEntries);
            var exImg = document.DocumentNode.SelectSingleNode(".//body").ChildNodes.Skip(1).SelectMany(x => x.ChildNodes).ToList();
            List<ImageCollection> imageCollections = new List<ImageCollection>();
            ImageCollection q = new ImageCollection { Question = "Question 1:" };
            foreach (var htmlNode in exImg)
            {
                var htmlNodeName = htmlNode.Name;
                if (htmlNodeName == "h2")
                {
                    var innerText = htmlNode.SelectSingleNode(".//span").InnerText;
                    q = new ImageCollection { Question = innerText };

                }
                else
                {
                    var attributeValue = htmlNode.SelectSingleNode(".//img")?.GetAttributeValue("src", "");
                    q.Images = attributeValue;
                    imageCollections.Add(q);
                }
            }

            var enumerable = imageCollections.Where(x => x.Images != null).ToList();
            var list1 = document.DocumentNode.SelectNodes(".//img").Select(x => x.GetAttributeValue("src", "")).ToList();

            var questionViewModel1 = new QuestionViewModel
            {
                ChapterName = "ChapterName",
                Exercise = "Exercise 1",
                QuestionLists = new List<QuestionList>
                {
                    new QuestionList
                    {
                        Question = strings[0],
                        Answer = string.Join("\n",enumerable.Where(x=>x.Question=="Question 1:").Select(x=>x.Images)),
                        questionNo = 1
                    }

                }
            };
            foreach (var s in strings.Skip(1))
            {
                var exNo = s.Split(':').FirstOrDefault()?.Trim();
                if (exNo == "1") break;
                questionViewModel1.QuestionLists.Add(new QuestionList
                {
                    Question = s,
                    Answer = string.Join("\n", enumerable.Where(x => x.Question == $"Question {exNo}:").Select(x => x.Images)),
                    questionNo = Int32.Parse(exNo)
                });
            }

            var questionViewModel2 = new QuestionViewModel
            {
                ChapterName = "ChapterName",
                Exercise = "Exercise 2",
                QuestionLists = new List<QuestionList>()
            };

            foreach (var s in strings.Skip(13))
            {
                var exNo = s.Split(':').FirstOrDefault()?.Trim();

                questionViewModel2.QuestionLists.Add(new QuestionList
                {
                    Question = s,
                    Answer = string.Join("\n", enumerable.Where(x => x.Question == $"Question {exNo}:").Select(x=>x.Images)),
                    questionNo = Int32.Parse(exNo)
                });

            }

            List<QuestionViewModel> questionViewModels=new List<QuestionViewModel>{questionViewModel1,questionViewModel2};

            var serializeObject = JsonConvert.SerializeObject(questionViewModels);
            Console.WriteLine();
            //using (WordprocessingDocument doc = WordprocessingDocument.Open
            //    (@"..\..\Sample.docx", false))
            //{

            //    // Add a main document part.
            //    Body body = doc.MainDocumentPart.Document.Body;
            //    string content = body.InnerText;
            //    foreach (var par in body.ChildElements)
            //    {
            //        Console.WriteLine(par.InnerText);

            //        var imageParts = (from graphic in par.Descendants<DocumentFormat.OpenXml.Drawing.Graphic>()
            //            let graphicData = graphic.Descendants<DocumentFormat.OpenXml.Drawing.GraphicData>()
            //                .FirstOrDefault()
            //            let pic = graphicData.ElementAt(0)
            //            let nvPicPrt = pic.ElementAt(0).FirstOrDefault()
            //            let blip = pic.Descendants<DocumentFormat.OpenXml.Drawing.Blip>().FirstOrDefault()
            //            select new
            //            {
            //                Id = blip.GetAttribute("embed", "xr"),
            //                Filename = nvPicPrt.GetAttribute("name", "xpic")
            //            }).ToList();
            //        Console.WriteLine(string.Join("+++",imageParts.Select(x=>x.Filename)));
            //    }

            //}
        }
    }
}
