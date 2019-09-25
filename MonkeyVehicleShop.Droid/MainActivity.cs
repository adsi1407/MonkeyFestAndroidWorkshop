using System.Collections.Generic;
using Android.App;
using System.Linq;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Util;
using Firebase;
using Firebase.Database;
using MonkeyFestWorkshop.Domain.Models;
using Newtonsoft.Json;

namespace MonkeyVehicleShop.Droid
{
    [Activity]
    public class MainActivity : AppCompatActivity, IValueEventListener
    {
        private RecyclerView recyclerView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            FirebaseApp.InitializeApp(Application.Context);
            LoadVehicles();
        }

        private void ConfigRecyclerView(List<BaseVehicle> list)
        {
            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView_vehicles);
            var adapter = new VehiclesAdapter(list);
            adapter.OnItemClick += Adapter_OnItemClick;
            recyclerView.SetLayoutManager(new LinearLayoutManager(this));
            recyclerView.SetAdapter(adapter);
        }

        private void LoadVehicles()
        {
            FirebaseDatabase database = FirebaseDatabase.Instance;
            DatabaseReference reference = database.GetReference("vehicle");
            reference.AddValueEventListener(this);
        }

        private void Adapter_OnItemClick(object sender, BaseVehicle vehicle)
        {
            GoToDetailsActivity(vehicle);
        }

        private void GoToDetailsActivity(BaseVehicle vehicle)
        {
            var intent = new Intent(this, typeof(VehicleDetailActivity));
            var extras = new Bundle();
            extras.PutString("vehicle", JsonConvert.SerializeObject(vehicle));

            intent.PutExtras(extras);

            StartActivity(intent);

        }

        public void OnCancelled(DatabaseError error)
        {
            Log.Debug(ComponentName.PackageName, error.Code.ToString());
        }

        public void OnDataChange(DataSnapshot snapshot)
        {
            List<BaseVehicle> list = new List<BaseVehicle>();
            for (int i = 0; i < snapshot.ChildrenCount; i++)
            {
                DataSnapshot dataSnapshot = snapshot.Child(i.ToString());

                var car = new Car
                {
                    Id = dataSnapshot.Child("id").Value.ToString(),
                    Plate = dataSnapshot.Child("plate").Value.ToString(),
                    Model = dataSnapshot.Child("model").Value.ToString(),
                    Line = dataSnapshot.Child("line").Value.ToString(),
                    BrandName = dataSnapshot.Child("brand_name").Value.ToString(),
                    Price = dataSnapshot.Child("price").Value.ToString()
                };

                list.Add(car);
            }

            List<BaseVehicle> orderList = list.OrderByDescending((x) =>  x.Price).ToList();

            ConfigRecyclerView(orderList);
        }
    }
}

