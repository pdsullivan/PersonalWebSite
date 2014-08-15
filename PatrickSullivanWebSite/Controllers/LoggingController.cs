using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Biggy;
using Biggy.JSON;
using PatrickSullivanWebSite.Models;

namespace PatrickSullivanWebSite.Controllers
{
    [EnableCors(origins: "http://www.pdsullivan.com", headers: "*", methods: "*")]
    public class LoggingController : ApiController
    {
        BiggyList<LogEntry> Log = Global.SiteDB.LogEntryList;

        // POST api/logging
        [HttpPost]
        public IHttpActionResult Post(LogEntry value)
        {
            Log.Add(value);
            return Ok();
        }

        [Route("api/alllogging")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var logitems = Log.ToList();
            return Ok(logitems);
        }
    }
}
