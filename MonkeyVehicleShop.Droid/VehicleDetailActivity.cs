using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using MonkeyFestWorkshop.Domain.Models;
using Newtonsoft.Json;

namespace MonkeyVehicleShop.Droid
{
    [Activity]
    public class VehicleDetailActivity : AppCompatActivity
    {
        private BaseVehicle vehicle;
        private TextView line;
        private TextView model;
        private TextView plate;
        private TextView brandName;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.vehicle_detail);

            GetViews();
            GetExtras();
            SetLabels();
        }

        private void GetViews()
        {
            line = FindViewById<TextView>(Resource.Id.line_textView);
            model = FindViewById<TextView>(Resource.Id.model_textView);
            plate = FindViewById<TextView>(Resource.Id.plate_textView);
            brandName = FindViewById<TextView>(Resource.Id.brandName_textView);
        }

        private void SetLabels()
        {
            line.Text = vehicle.Line;
            model.Text = vehicle.Model;
            plate.Text = vehicle.Plate;
            brandName.Text = vehicle.BrandName;
        }

        private void GetExtras()
        {

            vehicle = JsonConvert.DeserializeObject<Car>(Intent.Extras.GetString("vehicle"));
        }
    }
}
