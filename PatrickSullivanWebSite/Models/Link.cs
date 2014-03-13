using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatrickSullivanWebSite.Models
{
    public class Link
    {
        //public int Id { get; set; }
        public string Desc { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public string AuthorUrl { get; set; }

        public Link()
        { }

        public override bool Equals(object obj)
        {
            var p1 = (Link)obj;
            return this.Url == p1.Url;
        }
    }
}