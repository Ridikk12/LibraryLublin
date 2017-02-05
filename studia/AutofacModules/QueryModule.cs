using Autofac;
using Data.Queries;
using Library.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.AutofacModules
{
    public class QueryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<QueryProcessor>()
              .AsImplementedInterfaces()
              .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(IQuery).Assembly)
                .AsClosedTypesOf(typeof(IQueryHandler<,>))
                 .InstancePerLifetimeScope();



        }

    }
}