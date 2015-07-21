using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Microsoft.Owin;
using Newtonsoft.Json.Serialization;
using Owin;
using PumpManagement.API;

[assembly: OwinStartup(typeof(Startup))]
namespace PumpManagement.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Loading a new configuration.
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
              name: "PumpAPI",
              routeTemplate: "api/{controller}/{action}"
          );


            // Loading formatters.
            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();


            // Resolving Dependencies
            var builder = new ContainerBuilder();
            builder.RegisterModule(new DataLayer.DataLayerModule());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());


            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            app.UseWebApi(config);
        }
    }
}