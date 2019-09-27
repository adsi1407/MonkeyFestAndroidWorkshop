using System;
using System.Collections.Generic;
using System.Linq;
using Android.Support.V7.Widget;
using Android.Views;
using MonkeyFestWorkshop.Domain.Enumerations;
using MonkeyFestWorkshop.Domain.Models.Vehicle;
using MonkeyFestWorkshop.Droid.ViewHolders;

namespace MonkeyFestWorkshop.Droid.Adapters
{
    public class VehiclesAdapter: RecyclerView.Adapter
    {
        private List<BaseVehicle> vehicles;
        public EventHandler<BaseVehicle> OnItemClick;

        public VehiclesAdapter(List<BaseVehicle> vehicles)
        {
            this.vehicles = vehicles;
        }

        public override int ItemCount => vehicles.Count;

        public override int GetItemViewType(int position)
        {
            if (vehicles.ElementAt(position).Featured)
            {
                return (int)SectionType.Featured;
            }
            else
            {
                return (int)SectionType.Classic;
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            BaseVehicle vehicle = vehicles.ElementAt(position);
            if (vehicle.Featured)
            {
                FeaturedViewHolder viewHolder = holder as FeaturedViewHolder;
                viewHolder.BindData(vehicle);
            }
            else
            {
                VehicleViewHolder viewHolder = holder as VehicleViewHolder;
                viewHolder.BindData(vehicle);
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            if (viewType == (int)SectionType.Featured)
            {
                View view = LayoutInflater.FromContext(parent.Context).Inflate(Resource.Layout.featured_vehicle_item, parent, false);
                return new FeaturedViewHolder(view, OnClick);
            }
            else
            {
                View view = LayoutInflater.FromContext(parent.Context).Inflate(Resource.Layout.vehicle_item, parent, false);
                return new VehicleViewHolder(view, OnClick);
            }
        }

        private void OnClick(int position)
        {
            BaseVehicle vehicle = vehicles.ElementAt(position);
            OnItemClick?.Invoke(this, vehicle);
        }
    }
}
