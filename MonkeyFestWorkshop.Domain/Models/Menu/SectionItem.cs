using System.Collections.Generic;
using MonkeyFestWorkshop.Domain.Enumerations;
using MonkeyFestWorkshop.Domain.Models.Vehicle;

namespace MonkeyFestWorkshop.Domain.Models.Menu
{
    public class SectionItem
    {
        public string Title { get; set; }
        public SectionType SectionType { get; set; }
        public List<BaseVehicle> Vehicles { get; set; }
    }
}
