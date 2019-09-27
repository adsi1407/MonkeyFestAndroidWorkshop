using System.Collections.Generic;

namespace MonkeyFestWorkshop.Domain.Models.Vehicle
{
    public class Motorcycle : BaseVehicle
    {
        protected override bool ValidatePlate(string plate)
        {
            throw new System.NotImplementedException();
        }

        protected override IEnumerable<string> ValidateVehicle()
        {
            throw new System.NotImplementedException();
        }
    }
}
