﻿using Autofac;
using Autofac.Integration.Mvc;
using Presentation.Controllers;
using Repositories.Interfaces;
using System.Reflection;
using System.Web.Mvc;

namespace Presentation.AutoFac
{
    public class IoCBuilder
    {
       public static void Build()
        {
            ContainerBuilder builder = new ContainerBuilder();

            // Register dependencies in controllers
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // building EF implementations
            // this means if you get "IUintOfWork" just provide implementations of "UnitOfWork" present in "Repositories.Implementations.EF"
            builder.RegisterType<Repositories.Implementations.NH.UnitOfWork>().As<IUnitOfWork>();
            //builder.RegisterType<Repositories.Implementations.EF.UnitOfWork>().As<IUnitOfWork>();
            

            var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}