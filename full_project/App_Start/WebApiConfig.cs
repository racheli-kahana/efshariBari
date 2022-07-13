using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Bll;
using System.Timers;

namespace full_project
{
    public static class WebApiConfig
    {
        
        public static void Register(HttpConfiguration config)
        {
            //אתחול טיימר שיפעל כל שבועיים
            //const long intervalEveryMonth = 360 * 60 * 60 * 1000;
            //Timer checkForTime = new Timer(intervalEveryMonth);
            //checkForTime.Elapsed += new ElapsedEventHandler(Upload.Uploadd);
            //checkForTime.Enabled = true;
            //ובקבלה של הפונקציה צריך לשים את זה:
            // Web API configuration and services
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.EnableCors();
            // Web API routes
            config.MapHttpAttributeRoutes();
            //GlobalSourceTree g = new GlobalSourceTree();
            //g.buildTree();
            //GlobalSourceTree.sTree.insert(null);
            
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
