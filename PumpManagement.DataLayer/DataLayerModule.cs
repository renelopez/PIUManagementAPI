using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using GenericServices;

namespace PumpManagement.DataLayer
{
    public class DataLayerModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(GetType().Assembly).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(typeof (IListService).Assembly).AsImplementedInterfaces();

            builder.RegisterType<PumpManagementContext>()
                .As<PumpManagementContext>()
                .As<IGenericServicesDbContext>()
                .InstancePerLifetimeScope();

            Database.SetInitializer(new PumpManagementInitializer());
        }
    }
}
