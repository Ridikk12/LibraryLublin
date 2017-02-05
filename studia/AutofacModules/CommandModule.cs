using Autofac;
using Autofac.Core;
using Data.Commands;
using Data.Context;
using Library.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.AutofacModules
{
    public class CommandModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CommandProcessor>()
              .AsImplementedInterfaces()
              .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(IHandler).Assembly)
                .AsClosedTypesOf(typeof(ICommandHandler<>))
                 .InstancePerLifetimeScope();



        }
    }
}