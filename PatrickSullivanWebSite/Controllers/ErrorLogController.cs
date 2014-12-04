using Biggy.JSON;
using PatrickSullivanWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PatrickSullivanWebSite.Controllers
{
    [EnableCors(
        origins: "http://www.pdsullivan.com, http://blog.pdsullivan.com, http://localhost:8100", 
        headers: "*",
        methods: "*")]
    public class ErrorLogController : ApiController
    {
        private BiggyList<ErrorLogItem> errors = Global.SiteDB.ErrorLogList;

        [HttpPost]
        [Route("api/errorlog/post")]
        public IHttpActionResult Post(ErrorLogItem value)
        {
            value.Date = DateTime.Now.ToString();
            errors.Add(value);
            return Ok();
        }

        [HttpGet]
        [Route("api/errorlog/list")]
        public IHttpActionResult GetList()
        {
            return Ok(errors.ToList());
        }

    }
}
