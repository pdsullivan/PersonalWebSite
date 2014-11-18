using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatrickSullivanWebSite.Models
{
    public class LogEntry
    {
        public string Message { get; set; }
        public object Details { get; set; }
        public string Date { get; set; }
        public string Source { get; set; }

    }
}