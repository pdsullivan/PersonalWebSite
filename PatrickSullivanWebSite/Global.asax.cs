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
        public BiggyList<ErrorLogItem> ErrorLogList;
        public SiteDB()
        {

            Links = new BiggyList<Link>(dbPath: HttpRuntime.AppDomainAppPath);
            ContactInfos = new BiggyList<ContactInfo>(dbPath: HttpRuntime.AppDomainAppPath);
            LogEntryList = new BiggyList<LogEntry>(dbPath: HttpRuntime.AppDomainAppPath);
            BlogLogEntryList = new BiggyList<LogEntry>(dbPath: HttpRuntime.AppDomainAppPath, dbName: "blogLog");
            ArchiveLogList = new BiggyList<LogEntry>(dbPath: HttpRuntime.AppDomainAppPath, dbName: "archiveLog");

            ErrorLogList = new BiggyList<ErrorLogItem>(dbPath: HttpRuntime.AppDomainAppPath, dbName: "errorLogList");

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
