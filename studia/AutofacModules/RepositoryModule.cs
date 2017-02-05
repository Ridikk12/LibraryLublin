using Autofac;
using Autofac.Core;
using Data.Context;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Autofac
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<AppContextEF>().
                InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(AppContextEF).Assembly)
                .AsImplementedInterfaces()
                .AssignableTo<IRepositoryBase>()
                .InstancePerLifetimeScope();
        }
    }
}