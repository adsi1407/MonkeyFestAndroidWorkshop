using Android.Content;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using MonkeyFestWorkshop.Domain.Models;

namespace MonkeyVehicleShop.Droid
{
    public class SectionItemViewHolder : RecyclerView.ViewHolder
    {
        private readonly Context context;
        private readonly TextView title;
        private readonly RecyclerView list;

        public SectionItemViewHolder(View itemView) : base(itemView)
        {
            context = itemView.Context;
            title = itemView.FindViewById<TextView>(Resource.Id.sectionTitle_textView);
            list = itemView.FindViewById<RecyclerView>(Resource.Id.recyclerView_items);
        }

        public void BindData(SectionItem sectionItem, RecyclerView.Adapter adapter)
        {
            title.Text = sectionItem.Title;
            if (sectionItem.SectionType == SectionType.Featured)
            {
                list.SetLayoutManager(new LinearLayoutManager(context, LinearLayoutManager.Horizontal, false));
            }
            else
            {
                list.SetLayoutManager(new LinearLayoutManager(context));
            }
            list.SetAdapter(adapter);
        }
    }
}
