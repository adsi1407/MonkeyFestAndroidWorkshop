using System.Collections.Generic;
using System.Linq;
using MonkeyFestWorkshop.Domain.Models.Vehicle;

namespace MonkeyFestWorkshop.Core.Factories
{
    public class FeaturedVehicles: BaseVehiclesList
    {
        public FeaturedVehicles(List<BaseVehicle> vehicles): base(vehicles)
        {
        }

        public override List<BaseVehicle> CreateVehicles()
        {
            return Vehicles.Where(x => x.Featured).Select(x => x).ToList();
        }
    }
}
