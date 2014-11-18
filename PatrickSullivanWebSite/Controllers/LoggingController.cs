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
    [EnableCors(origins: "http://www.pdsullivan.com, http://blog.pdsullivan.com", headers: "*", methods: "*")]
    public class LoggingController : ApiController
    {
        BiggyList<LogEntry> Log = Global.SiteDB.LogEntryList;
        BiggyList<LogEntry> BlogLogs = Global.SiteDB.BlogLogEntryList;
        BiggyList<LogEntry> ArchiveLogList = Global.SiteDB.ArchiveLogList;

        // POST api/logging
        [HttpPost]
        [Route("api/logging")]
        public IHttpActionResult Post(LogEntry value)
        {
            value.Date = DateTime.UtcNow.ToString();
            Log.Add(value);
            return Ok();
        }

        // POST api/logging
        [HttpGet]
        [Route("api/ArchiveLogs")]
        public IHttpActionResult ArchiveLogs([FromUri]string password)
        {
            if (password != "ArchiveLogs") //just to make
                return Unauthorized();

            foreach (var item in Log)
            {
                ArchiveLogList.Add(item);
            }
            foreach (var item in BlogLogs)
            {
                ArchiveLogList.Add(item);
            }

            Log.Clear();
            BlogLogs.Clear();

            return Ok();
        }

        // POST api/logging
        [HttpPost]
        [Route("api/blogLog")]
        public IHttpActionResult BlogLog(LogEntry value)
        {
            value.Date = DateTime.UtcNow.ToString();
            BlogLogs.Add(value);
            return Ok();
        }


        [Route("api/alllogging")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var logitems = Log.ToList();
            return Ok(logitems);
        }

        [Route("api/logging")]
        [HttpGet]
        public IHttpActionResult GetLogging()
        {
            var logitems = Log.Where(x =>Convert.ToDateTime(x.Date) > DateTime.UtcNow.AddDays(-5)).ToList();
            return Ok(logitems);
        }


        [Route("api/allBlogLogging")]
        [HttpGet]
        public IHttpActionResult GetAllBlogLogging()
        {
            var logitems = BlogLogs.ToList();
            return Ok(logitems);
        }

        [Route("api/blogLogging")]
        [HttpGet]
        public IHttpActionResult GetBlogLogging()
        {
            var logitems = BlogLogs.Where(x => Convert.ToDateTime(x.Date) > DateTime.UtcNow.AddDays(-5)).ToList();
            return Ok(logitems);
        }

    }
}
