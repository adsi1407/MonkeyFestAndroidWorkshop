using Autofac;
using MonkeyFestWorkshop.DataAccess.Implementations.Mock;
using MonkeyFestWorkshop.DataAccess.Repositories;

namespace MonkeyFestWorkshop.Core.DependencyInjection
{
    public class RepositoriesModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
#if MOCK

            builder.RegisterType<UserRepositoryMock>().As<IUserRepository>();

#else

            builder.RegisterType<UserRepository>().As<IUserRepository>();

#endif
        }
    }
}
