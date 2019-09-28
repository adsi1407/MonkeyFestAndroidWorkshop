using System.Collections.Generic;
using System.Linq;
using MonkeyFestWorkshop.Domain.Models.Vehicle;

namespace MonkeyFestWorkshop.Core.Factories
{
    public class NormalVehicles: BaseVehiclesList
    {
        public NormalVehicles(List<BaseVehicle> vehicles) : base(vehicles)
        {
        }

        public override List<BaseVehicle> CreateVehicles()
        {
            return Vehicles.Where(x => !x.Featured).Select(x => x).OrderByDescending((x) => x.Price).ToList();
        }
    }
}
