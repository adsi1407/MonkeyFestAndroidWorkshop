using System;
using Autofac;
using MonkeyFestWorkshop.Core.DomainServices;

namespace MonkeyFestWorkshop.Core.DependencyInjection
{
    public class DomainModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(UserServiceDomain)).PropertiesAutowired();
        }
    }
}
