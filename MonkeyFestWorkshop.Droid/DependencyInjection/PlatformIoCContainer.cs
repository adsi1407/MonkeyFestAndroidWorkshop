using Autofac;
using MonkeyFestWorkshop.Core.Contracts.Platform;
using MonkeyFestWorkshop.Core.DependencyInjection;
using MonkeyFestWorkshop.Droid.DependencyInjection.Strategies;

namespace MonkeyFestWorkshop.Droid.DependencyInjection
{
    public class PlatformIoCContainer : IoCContainer
    {
        protected override void RegisterDependencies(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<NetworkStrategy>().As<INetworkStrategy>();
        }
    }
}
