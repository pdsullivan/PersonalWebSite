using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public static List<ContactInfo> GetAllContactItems(string username = "u75851647", string password = "Hobie!1988")
        {
            //u75851647
            WebClient request = new WebClient();
            string url = "ftp://pdsullivan.com/data/" + "contactinfos.json";
            request.Credentials = new NetworkCredential(userName: username, password: password);

            try
            {
                byte[] newFileData = request.DownloadData(url);
                string fileString = System.Text.Encoding.UTF8.GetString(newFileData);

                List<string> slist = fileString.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None).ToList();
                List<ContactInfo> contacts = new List<ContactInfo>();
                foreach (var stringitem in slist)
                {
                    if (stringitem.Trim() == "")
                        continue;
                    dynamic d = JObject.Parse(stringitem);
                    contacts.Add(new ContactInfo()
                    {
                        Name = d.Name,
                        Email = d.Email,
                        Message = d.Message
                    });
                }

                Console.WriteLine(fileString);

                return contacts;
            }
            catch (WebException e)
            {
                // Do something such as log error, but this is based on OP's original code
                // so for now we do nothing.
                throw;
            }
        }

    }
}
