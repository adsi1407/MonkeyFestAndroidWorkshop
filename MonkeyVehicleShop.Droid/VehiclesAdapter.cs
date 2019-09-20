using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using MonkeyFestWorkshop.Domain.Models;

namespace MonkeyVehicleShop.Droid
{
    public class VehiclesAdapter: RecyclerView.Adapter
    {
        private List<BaseVehicle> vehicles;

        public VehiclesAdapter(List<BaseVehicle> vehicles)
        {
            this.vehicles = vehicles;
        }

        public override int ItemCount => vehicles.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            throw new NotImplementedException();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            throw new NotImplementedException();
        }
    }
}
