using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Widget;
using Autofac;
using Firebase;
using MonkeyFestWorkshop.Core.Contracts.Platform;
using MonkeyFestWorkshop.Core.DomainServices;
using MonkeyFestWorkshop.Domain.Exceptions;
using MonkeyFestWorkshop.Domain.Models.Menu;
using MonkeyFestWorkshop.Domain.Models.User;
using MonkeyFestWorkshop.Domain.Models.Vehicle;
using MonkeyFestWorkshop.Droid.Adapters;
using MonkeyFestWorkshop.Droid.Infrastructure;
using Newtonsoft.Json;

namespace MonkeyFestWorkshop.Droid.Activities
{
    [Activity]
    public class MainActivity : BaseActivity, IVehicleData
    {
        private RecyclerView recyclerView;
        private const string authenticatedUser = "1111";
        private UserServiceDomain userServiceDomain;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            FirebaseApp.InitializeApp(Application.Context);

            SetDependencies();
            GetUserInfo();
            LoadVehicles();
        }

        private void SetDependencies()
        {
            userServiceDomain = ConfigureDependencies().Resolve<UserServiceDomain>();
        }

        private void GetUserInfo()
        {
            try
            {
                UserInfo userInfo = userServiceDomain.GetUserInfo(authenticatedUser);
                Title = userInfo.Name;
            }
            catch (NetworkException ex)
            {
                Title = string.Empty;
                Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
            }
            catch (System.Exception ex)
            {
                Title = string.Empty;
                Log.Error(ComponentName.ToString(), ex.Message);
                Toast.MakeText(this, "Ha ocurrido un error inesperado.", ToastLength.Short).Show();
            }
        }

        private void ConfigRecyclerView(List<SectionItem> menu)
        {
            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView_vehicles);
            var adapter = new SectionMenuAdapter(menu);
            adapter.OnItemClick += Adapter_OnItemClick;
            recyclerView.SetLayoutManager(new LinearLayoutManager(this));
            recyclerView.SetAdapter(adapter);
        }

        private void LoadVehicles()
        {
            var data = new RealmTimeData(this);
            data.LoadData();
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

        public void ProcessVehicleData(List<SectionItem> sectionItems)
        {
            ConfigRecyclerView(sectionItems);
        }
    }
}

