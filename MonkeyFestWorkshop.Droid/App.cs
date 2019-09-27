using Android.App;
using MonkeyFestWorkshop.Droid.DependencyInjection;

namespace MonkeyFestWorkshop.Droid
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
