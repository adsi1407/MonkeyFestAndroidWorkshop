
using Android.App;
using Android.Content;
using Android.OS;

namespace MonkeyFestWorkshop.Droid
{
    [Activity(MainLauncher = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
    }
}
