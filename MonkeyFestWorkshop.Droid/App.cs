using Android.App;
using Android.Runtime;
using MonkeyFestWorkshop.Droid.DependencyInjection;

namespace MonkeyFestWorkshop.Droid
{
    [Register("co.com.ceiba.monkey_vehicle_shop.MainApp")]
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
