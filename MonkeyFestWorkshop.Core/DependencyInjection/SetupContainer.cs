using Autofac;

namespace MonkeyFestWorkshop.Core.DependencyInjection
{
    public class SetupContainer
    {
        public IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();
            RegisterDependencies(containerBuilder);
            return containerBuilder.Build();
        }

        private void RegisterDependencies(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule<RepositoriesModule>();
        }
    }
}
