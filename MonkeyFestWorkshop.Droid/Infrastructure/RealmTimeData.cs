using System.Collections.Generic;
using System.Linq;
using Android.Util;
using Firebase.Database;
using MonkeyFestWorkshop.Core.Contracts.Platform;
using MonkeyFestWorkshop.Core.Factories;
using MonkeyFestWorkshop.Domain.Enumerations;
using MonkeyFestWorkshop.Domain.Models.Menu;
using MonkeyFestWorkshop.Domain.Models.Vehicle;

namespace MonkeyFestWorkshop.Droid.Infrastructure
{
    public class RealmTimeData : Java.Lang.Object, IValueEventListener
    {
        private readonly IVehicleData vehicleData;
        private readonly DatabaseReference reference;
        private VehicleFactory vehicleFactory;
        private const string Tag = "RealmTimeData";

        public RealmTimeData(IVehicleData vehicleData)
        {
            this.vehicleData = vehicleData;

            FirebaseDatabase database = FirebaseDatabase.Instance;
            reference = database.GetReference("vehicle");
        }

        public void LoadData()
        {
            reference.AddValueEventListener(this);
        }

        public void OnCancelled(DatabaseError error)
        {
            Log.Debug(Tag, error.Code.ToString());
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

                if (dataSnapshot.Child("featured").Value is Java.Lang.Boolean)
                {
                    var featured = dataSnapshot.Child("featured").Value as Java.Lang.Boolean;
                    car.Featured = featured.BooleanValue();
                }
                
                list.Add(car);
            }

            vehicleFactory = new VehicleFactory(list);
            List<BaseVehicle> orderList = vehicleFactory.Create(VehicleCategory.Normal);
            List<BaseVehicle> featuredVehicles = vehicleFactory.Create(VehicleCategory.Featured);

            List<SectionItem> sectionItems = new List<SectionItem>();

            var featuredItems = new SectionItem
            {
                Title = "Destacados",
                Vehicles = featuredVehicles,
                SectionType = SectionType.Featured
            };

            var classicItems = new SectionItem
            {
                Title = "Vehículos",
                Vehicles = orderList,
                SectionType = SectionType.Classic
            };

            sectionItems.Add(featuredItems);
            sectionItems.Add(classicItems);

            vehicleData.ProcessVehicleData(sectionItems);
        }
    }
}
