using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Transactions.Models;
using Transactions.Repository;
using GenericLib;
using IdentityAccess.Models;

namespace DDDExample.App_Start
{
    public class AutofacWebApiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }


        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
          
            builder.RegisterAssemblyTypes(Assembly.Load("Transactions.Services"))
                      .Where(t => t.Name.EndsWith("Service"))
                      .AsImplementedInterfaces()
                      .InstancePerLifetimeScope()
                      .PropertiesAutowired();

            builder.RegisterAssemblyTypes(Assembly.Load("Transactions.Repository"))
                                                  .AsImplementedInterfaces()
                                                  .InstancePerLifetimeScope()
                                                  .PropertiesAutowired();


            builder.RegisterAssemblyTypes(Assembly.Load("IdentityAccess.Services"))
                     .Where(t => t.Name.EndsWith("Service"))
                     .AsImplementedInterfaces()
                     .InstancePerLifetimeScope()
                     .PropertiesAutowired();

            builder.RegisterAssemblyTypes(Assembly.Load("IdentityAccess.Repository"))
                                                  .AsImplementedInterfaces()
                                                  .InstancePerLifetimeScope()
                                                  .PropertiesAutowired();


            //builder.RegisterModule(new RepositoryModule());
            builder.RegisterType(typeof(TransactionContext)).As(typeof(DbContext))
                .InstancePerLifetimeScope()
                .PropertiesAutowired();

            builder.RegisterType(typeof(IdentityAccessContext)).As(typeof(DbContext))
              .InstancePerLifetimeScope()
              .PropertiesAutowired();

            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork))
                .InstancePerRequest()
                .PropertiesAutowired();  //.InstancePerLifetimeScope();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();


            var resolver = new AutofacWebApiDependencyResolver(Container);

            // Configure Web API with the dependency resolver.
            GlobalConfiguration.Configuration.DependencyResolver = resolver;

            return Container;
        }

    }
}