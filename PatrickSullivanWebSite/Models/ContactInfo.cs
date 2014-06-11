using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatrickSullivanWebSite.Models
{
    public class ContactInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string DateSubmited { get; set; }
        public string Location { get; set; }
        public string ExtraInfo { get; set; }
    }
}
