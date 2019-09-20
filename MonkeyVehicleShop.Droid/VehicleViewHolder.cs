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

        public VehicleViewHolder(View itemView) : base(itemView)
        {
            vehicleImage = itemView.FindViewById<ImageView>(Resource.Id.vehicle_imageView);
            brandName = itemView.FindViewById<TextView>(Resource.Id.vehicle_brand_textView);
        }

        public void BindData(BaseVehicle vehicle)
        {
            brandName.Text = vehicle.BrandName;
        }
    }
}
