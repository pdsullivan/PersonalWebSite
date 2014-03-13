using PatrickSullivanWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PatrickSullivanWebSite.Controllers
{
    public class PodcastsController : ApiController
    {
        public IHttpActionResult GetAllPodcasts()
        {
            var db = new List<Link>();
            db = (from x in Global.SiteDB.Links
                  where x.Type == "podcast"
                  select x).ToList();
            return Ok(db);
        }
    }
}
