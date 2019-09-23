using System;
using System.Collections.Generic;
using System.Linq;
using Android.Support.V7.Widget;
using Android.Views;
using MonkeyFestWorkshop.Domain.Models;

namespace MonkeyVehicleShop.Droid
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

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            BaseVehicle vehicle = vehicles.ElementAt(position);
            VehicleViewHolder viewHolder = holder as VehicleViewHolder;
            viewHolder.BindData(vehicle);

        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.FromContext(parent.Context).Inflate(Resource.Layout.vehicle_item, parent, false);
            return new VehicleViewHolder(view, OnClick);
        }

        private void OnClick(int position)
        {
            BaseVehicle vehicle = vehicles.ElementAt(position);
            OnItemClick?.Invoke(this, vehicle);
        }
    }
}
