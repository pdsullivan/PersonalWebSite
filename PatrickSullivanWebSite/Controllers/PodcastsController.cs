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
            var db = new List<Link>()
            {
                new Link() {Url = "http://dotnetrocks.com/", Desc = ".Net Rocks"},
                new Link(){Url = "https://itunes.apple.com/us/podcast/id393751871" , 
                            Desc = "Yet Another Podcast",
                            Text = " by ",
                            Author = "Jesse Liberty",
                            AuthorUrl = "https://jesseliberty.com/"},

                new Link(){Url = "http://blog.stackoverflow.com/category/podcasts/" , 
                            Desc = "StackExchange Podcast"},
                
                new Link(){Url = "http://herdingcode.com/" , 
                            Desc = "Herding Code Podcast"}

            };
            return Ok(db);
        }
    }
}
