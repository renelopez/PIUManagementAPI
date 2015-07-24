using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Microsoft.Owin;
using Newtonsoft.Json.Serialization;
using Owin;
using PumpManagement.API;
using PumpManagement.API.Controllers;
using PumpManagement.DataLayer;
using PumpManagement.DataLayer.QueryCommandObjects;

[assembly: OwinStartup(typeof(Startup))]
namespace PumpManagement.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Loading a new configuration.
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();


            // Loading formatters.
            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            jsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            // Resolving Dependencies
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterModule(new DataLayerModule());

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);


            // Configuring Mappings
            DataLayerMapping.AutoMapperStart();

            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);
            app.UseWebApi(config);
        }
    }
}