using System.Collections.Generic;

namespace MonkeyFestWorkshop.Domain.Models
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
