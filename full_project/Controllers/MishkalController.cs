using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bll;

namespace full_project.Controllers
{
    public class MishkalController : ApiController
    {
        ClsDb db = new ClsDb();
        //שליפה
        // GET: api/Mishkal
        //public object Get()
        //{
            

        //    var res = db.getAllMishkal();
        //    return res.Data;
        //}
        //שליפה ע"י id
        // GET: api/Mishkal/5
        public string Get(int id)
        {
            return "value";
        }
        // הוספה
        // POST: api/Mishkal
        public void Post([FromBody]string value)
        {

        }
        //עדכון
        // PUT: api/Mishkal/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Mishkal/5
        public void Delete(int id)
        {
        }
    }
}
