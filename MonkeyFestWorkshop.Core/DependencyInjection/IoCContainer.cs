using Autofac;

namespace MonkeyFestWorkshop.Core.DependencyInjection
{
    public abstract class IoCContainer
    {
        public IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();
            RegisterSharedDependencies(containerBuilder);
            RegisterDependencies(containerBuilder);
            return containerBuilder.Build();
        }

        private void RegisterSharedDependencies(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule<RepositoriesModule>();
            containerBuilder.RegisterModule<DomainModule>();
        }

        protected abstract void RegisterDependencies(ContainerBuilder containerBuilder);
    }
}
