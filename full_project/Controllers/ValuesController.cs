using Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bll.DataGov;
using System.Web.Http.Cors;
using System.Threading.Tasks;
using System.Web;
using System.Diagnostics;
using System.IO;


namespace full_project.Controllers
{

    public class file
    {
        public string file1 { get; set; }
    }

    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class ValuesController : ApiController
    {



        // GET api/values
        //public IEnumerable<string> Get()




        //{

        //}

        // GET api/values/5
        //פונקציה המקבלת קובץ של מתכון ושומרת אותו בסי שארפ ומחלצת את הניתוב שלו ושולחת
        // לקבלת תוכן המתכון כסטרינג ToGetString  את הניתוב לפונקציה
        public async Task<Dictionary<string, double>> PostFromData()
        {
           
            Ocr o = new Ocr();
            // Check if the request contains multipart/form-data.
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }

            string root = HttpContext.Current.Server.MapPath("~/App_Data");
            var provider = new MultipartFormDataStreamProvider(root);
            try
            {
                var content = new StreamContent(HttpContext.Current.Request.GetBufferlessInputStream(true));
                foreach (var header in Request.Content.Headers)
                {
                    content.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
                await content.ReadAsMultipartAsync(provider);
                string uploadingFileName = provider.FileData.Select(x => x.LocalFileName).FirstOrDefault();
                string originalFileName = String.Concat(root, "\\" + (provider.Contents[0].Headers.ContentDisposition.FileName).Trim(new Char[] { '"' }));
                var filename = provider.Contents[0].Headers.ContentDisposition.FileName;
                if (File.Exists(originalFileName))
                {
                    File.Delete(originalFileName);
                }
                File.Move(uploadingFileName, originalFileName);
                return o.ToGetString(originalFileName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
                return null;
            }

        }



        //public void Get()
        //{
        //    Ocr o = new Ocr(/*"C: /Users/user1/Desktop/R.pdf"*/);




        //}

        // POST api/values
        //static readonly Dictionary<Guid, Update> updates = new Dictionary<Guid, Update>();

        //public void Post(file update)
        //{

        //    string file = update.file1;
        //    //Ocr o = new Ocr(update);
        //    //string base64 = System.Convert.ToString(file);

        //    //var img = update.FromStream(new MemoryStream(Convert.FromBase64String(file)));

        //}


        // PUT api/values/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
