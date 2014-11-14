using Biggy.JSON;
using PatrickSullivanWebSite.AppStart;
using PatrickSullivanWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using System.Web.SessionState;

namespace PatrickSullivanWebSite
{
    public class SiteDB 
    {
        public BiggyList<Link> Links;
        public BiggyList<ContactInfo> ContactInfos;
        public BiggyList<LogEntry> LogEntryList;
        public BiggyList<LogEntry> BlogLogEntryList;
        public BiggyList<LogEntry> ArchiveLogList;
        public SiteDB()
        {

            Links = new BiggyList<Link>(dbPath: HttpRuntime.AppDomainAppPath);
            ContactInfos = new BiggyList<ContactInfo>(dbPath: HttpRuntime.AppDomainAppPath);
            LogEntryList = new BiggyList<LogEntry>(dbPath: HttpRuntime.AppDomainAppPath);
            BlogLogEntryList = new BiggyList<LogEntry>(dbPath: HttpRuntime.AppDomainAppPath, dbName: "blogLog");
            ArchiveLogList = new BiggyList<LogEntry>(dbPath: HttpRuntime.AppDomainAppPath, dbName: "archiveLog");

            #region adding links

            //adding links test
            if (Links.Count <  1)
            {
               Links.Add( new Link()
               {
                   Url = "http://9to5mac.com/" , 
                   Type = "link" ,
                   Desc = "9to5Mac", 
                   Text = " Apple Intelligence"
               });

               Links.Add(new Link()
               {
                   Url = "http://blog.stackexchange.com/", 
                   Type = "link" , 
                   Desc = "StackExchange Blog"
               });

                Links.Add(new Link()
                {
                    Url = "https://github.com/pdsullivan",
                    Desc = "My Github Account",
                    Type = "link", 
                    Text = " (Not much on there at the moment)"
                });

                Links.Add(new Link()
                {
                    Url = "http://webdevchecklist.com/",
                    Desc = "Web Development Checklist",
                    Type = "dev"
                });

                Links.Add(new Link()
                {
                    Url = "http://sidewaffle.com/",
                    Desc = "SideWaffle",
                    Type = "dev"
                });

                Links.Add(new Link()
                {
                    Url = "http://dotnetrocks.com/",
                    Desc = ".Net Rocks",
                    Type = "podcast"
                });

                Links.Add(new Link()
                {
                    Url = "http://hanselminutes.com/",
                    Desc = "Hanselminutes",
                    Type = "podcast",
                    Text = " by ",
                    Author = "Scott Hanselman",
                    AuthorUrl = "http://www.hanselman.com/"
                });

                Links.Add(new Link()
                {
                    Url = "https://itunes.apple.com/us/podcast/id393751871",
                    Desc = "Yet Another Podcast",
                    Text = " by ",
                    Author = "Jesse Liberty",
                    AuthorUrl = "https://jesseliberty.com/",
                    Type = "podcast"
                });

                Links.Add(new Link()
                {
                    Url = "http://blog.stackoverflow.com/category/podcasts/",
                    Desc = "StackExchange Podcast",
                    Type = "podcast"
                });

                Links.Add(new Link()
                {
                    Url = "http://herdingcode.com/",
                    Desc = "Herding Code Podcast",
                    Type = "podcast"
                });
            }

            #endregion
        }
    }
    
    
    
    public class Global : System.Web.HttpApplication
    {
        public static SiteDB SiteDB { get; set; }

        protected void Application_Start(object sender, EventArgs e)
        {
            SiteDB = new SiteDB();
            
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

    }
}
