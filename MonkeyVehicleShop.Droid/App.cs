using Android.App;
using MonkeyVehicleShop.Droid.DependencyInjection;

namespace MonkeyVehicleShop.Droid
{
    public class App: Application
    {
        public override void OnCreate()
        {
            base.OnCreate();
            var ioCContainer = new PlatformIoCContainer();
            ioCContainer.CreateContainer();
        }
    }
}
