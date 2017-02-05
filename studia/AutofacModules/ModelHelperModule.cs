using Autofac;
using Library.ModelHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.AutofacModules
{
    public class ModelHelperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterAssemblyTypes(typeof(IModelHelper).Assembly)
                .AssignableTo<IModelHelper>()
                .InstancePerLifetimeScope();
        }
    }
}