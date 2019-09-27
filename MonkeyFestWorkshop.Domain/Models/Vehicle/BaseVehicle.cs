using System.Collections.Generic;

namespace MonkeyFestWorkshop.Domain.Models.Vehicle
{
    public abstract class BaseVehicle
    {
        public string Id { get; set; }

        public string Line { get; set; }

        public string BrandName { get; set; }

        public string Plate { get; set; }

        public string Model { get; set; }

        public string Price { get; set; }

        public bool Featured { get; set; }

        protected abstract bool ValidatePlate(string plate);

        protected abstract IEnumerable<string> ValidateVehicle();
    }
}
