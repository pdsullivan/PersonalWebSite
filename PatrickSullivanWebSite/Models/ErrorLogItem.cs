using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatrickSullivanWebSite.Models
{
    public class ErrorLogItem
    {
        public string AppName { get; set; }
        public string Event { get; set; }
        public string Message { get; set; }
        public object Details { get; set; }
        public string Date { get; set; }
    }
}