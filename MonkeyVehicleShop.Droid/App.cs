using Android.App;

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
