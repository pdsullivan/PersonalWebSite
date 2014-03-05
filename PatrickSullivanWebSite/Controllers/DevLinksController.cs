using PatrickSullivanWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PatrickSullivanWebSite.Controllers
{
    public class DevLinksController : ApiController
    {
        public IHttpActionResult GetAllDevLinks()
        {
            var db = new List<Link>()
            {               

                new Link(){Url = "http://webdevchecklist.com/" , 
                            Desc = "Web Development Checklist"},
                new Link(){Url = "http://sidewaffle.com/",
                            Desc= "SideWaffle"}

            };
            return Ok(db);
        }
    }
}
