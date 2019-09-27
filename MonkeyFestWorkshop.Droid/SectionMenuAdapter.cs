using System;
using System.Collections.Generic;
using System.Linq;
using Android.Support.V7.Widget;
using Android.Views;
using MonkeyFestWorkshop.Domain.Models;

namespace MonkeyFestWorkshop.Droid
{
    public class SectionMenuAdapter : RecyclerView.Adapter
    {
        private List<SectionItem> sectionList;
        public EventHandler<BaseVehicle> OnItemClick;

        public SectionMenuAdapter(List<SectionItem> sectionList)
        {
            this.sectionList = sectionList;
        }

        public override int ItemCount => sectionList.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            SectionItem item = sectionList.ElementAt(position);
            VehiclesAdapter adapter = new VehiclesAdapter(item.Vehicles);
            adapter.OnItemClick += OnItemClick;
            SectionItemViewHolder viewHolder = holder as SectionItemViewHolder;
            viewHolder.BindData(item, adapter);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.FromContext(parent.Context).Inflate(Resource.Layout.section_item, parent, false);
            return new SectionItemViewHolder(view);
        }
    }
}
