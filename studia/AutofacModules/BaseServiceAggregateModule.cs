using Autofac;
using Library.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.AutofacModules
{
    public class BaseServiceAggregateModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<BaseServiceAggregate>()
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}