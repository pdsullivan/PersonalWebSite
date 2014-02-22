using PatrickSullivanWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PatrickSullivanWebSite.Controllers
{
    public class LinksController : ApiController
    {
        public IHttpActionResult GetAllLinks()
        {
            var db = new List<Link>()
            {
                new Link(){Url = "https://itunes.apple.com/us/podcast/id393751871" , 
                            Desc = "Yet Another Podcast",
                            Text = " by ",
                            Author = "Jesse Liberty",
                            AuthorUrl = "https://jesseliberty.com/"},

                new Link(){Url = "http://9to5mac.com/" , 
                            Desc = "9to5Mac Apple Intelligence"},

                new Link(){Url = "http://blog.stackexchange.com/" , 
                            Desc = "StackExchange Blog"},

                new Link(){Url = "http://blog.stackoverflow.com/category/podcasts/" , 
                            Desc = "StackExchange Podcast"},

                new Link(){Url = "https://github.com/pdsullivan", 
                            Desc = "My Github Account", 
                            Text = " (Not much on there at the moment)"}
            };
            return Ok(db);
        }
    }
}
