using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;

namespace PatrickSullivanWebSite.AppStart
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            var formatters = GlobalConfiguration.Configuration.Formatters;
            var jsonFormatter = formatters.JsonFormatter;
            var settings = jsonFormatter.SerializerSettings;
            settings.Formatting = Formatting.Indented;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            //var errconfig = (CustomErrorsSection)ConfigurationManager.GetSection("system.web/customErrors");

            //IncludeErrorDetailPolicy errorDetailPolicy;

            //switch (errconfig.Mode)
            //{
            //    case CustomErrorsMode.RemoteOnly:
            //        errorDetailPolicy
            //            = IncludeErrorDetailPolicy.LocalOnly;
            //        break;
            //    case CustomErrorsMode.On:
            //        errorDetailPolicy
            //            = IncludeErrorDetailPolicy.Never;
            //        break;
            //    case CustomErrorsMode.Off:
            //        errorDetailPolicy
            //            = IncludeErrorDetailPolicy.Always;
            //        break;
            //    default:
            //        throw new ArgumentOutOfRangeException();
            //}

            //GlobalConfiguration.Configuration.IncludeErrorDetailPolicy = errorDetailPolicy;

        }
    }
}