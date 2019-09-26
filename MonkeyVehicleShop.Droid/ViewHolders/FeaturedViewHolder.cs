using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using MonkeyFestWorkshop.Domain.Models;

namespace MonkeyVehicleShop.Droid.ViewHolders
{
    public class FeaturedViewHolder : RecyclerView.ViewHolder
    {
        private TextView brandName;

        public FeaturedViewHolder(View view, Action<int> clickListener) : base(view)
        {
            brandName = view.FindViewById<TextView>(Resource.Id.brandName_textView);
            view.Click += (sender, e) => clickListener(LayoutPosition);
        }

        public void BindData(BaseVehicle vehicle)
        {
            brandName.Text = vehicle.BrandName;
        }
    }
}