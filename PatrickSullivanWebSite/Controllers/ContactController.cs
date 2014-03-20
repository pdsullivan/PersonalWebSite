using Biggy.JSON;
using PatrickSullivanWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PatrickSullivanWebSite.Controllers
{
    public class ContactController : ApiController
    {
        BiggyList<ContactInfo> Conts = Global.SiteDB.ContactInfos;

        // GET api/contact
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/contact/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/contact
        [HttpPost]
        public void Post(ContactInfo value)
        {
            //Conts.Add(value);
            Console.WriteLine(value);
        }

        // PUT api/contact/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/contact/5
        public void Delete(int id)
        {
        }
    }

}
