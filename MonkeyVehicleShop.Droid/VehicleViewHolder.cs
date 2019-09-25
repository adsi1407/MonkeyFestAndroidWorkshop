using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using MonkeyFestWorkshop.Domain.Models;

namespace MonkeyVehicleShop.Droid
{
    public class VehicleViewHolder : RecyclerView.ViewHolder
    {
        private ImageView vehicleImage;
        private TextView brandName;
        private TextView line;
        private TextView price;

        public VehicleViewHolder(View itemView, Action<int> clickListener) : base(itemView)
        {
            vehicleImage = itemView.FindViewById<ImageView>(Resource.Id.vehicle_imageView);
            brandName = itemView.FindViewById<TextView>(Resource.Id.vehicle_brand_textView);
            line = itemView.FindViewById<TextView>(Resource.Id.vehicle_line_textView);
            price = itemView.FindViewById<TextView>(Resource.Id.price_textView);

            itemView.Click += (sender, e) => clickListener(LayoutPosition);
        }

        public void BindData(BaseVehicle vehicle)
        {
            brandName.Text = vehicle.BrandName;
            line.Text = vehicle.Line;
            price.Text = vehicle.Price;
        }
    }
}
