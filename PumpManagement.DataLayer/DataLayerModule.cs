using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using PumpManagement.DataLayer.QueryCommandObjects;

namespace PumpManagement.DataLayer
{
    public class DataLayerModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<PumpManagementContext>()
                .As<PumpManagementContext>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ListSongsQuery>().As<ListSongsQuery>();

            Database.SetInitializer(new PumpManagementInitializer());
        }
    }
}
