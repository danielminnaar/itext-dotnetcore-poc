using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using iText;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;

namespace itext_dotnetcore_poc.Controllers
{
    [Route("api/[controller]")]
    public class iTextController : Controller
    {
        [HttpGet]
        public string Get()
        {
            var ms = new MemoryStream();
            var writer = new PdfWriter(ms);
            var pdf = new PdfDocument(writer);
            var document = new Document(pdf);
            var info = new iText.Kernel.Version();
            string result = "ab-itext-dotnetcore-poc: " + info.GetProduct() + "," + info.GetRelease() + "," + info.GetVersion();
            // result.Content = new StreamContent(ms);
            // result.Content.Headers.ContentType = 
            //     new MediaTypeHeaderValue("application/octet-stream");
            return result;
        }

    }
}
