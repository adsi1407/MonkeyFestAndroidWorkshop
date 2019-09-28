using Android.App;
using Android.Runtime;
using Autofac;
using MonkeyFestWorkshop.Droid.DependencyInjection;

namespace MonkeyFestWorkshop.Droid
{
    [Register("co.com.ceiba.monkey_vehicle_shop.MainApp")]
    public class App: Application
    {
        public override void OnCreate()
        {
            base.OnCreate();
            ConfigureDependencies();
        }

        public ILifetimeScope ConfigureDependencies()
        {
            var concreteIoCContainer = new PlatformIoCContainer();
            IContainer container = concreteIoCContainer.CreateContainer();
            return container.BeginLifetimeScope();
        }
    }
}
