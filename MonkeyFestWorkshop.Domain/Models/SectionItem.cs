using System.Collections.Generic;

namespace MonkeyFestWorkshop.Domain.Models
{
    public class SectionItem
    {
        public string Title { get; set; }
        public SectionType SectionType { get; set; }
        public List<BaseVehicle> Vehicles { get; set; }
    }
}
