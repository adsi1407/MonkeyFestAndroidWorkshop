using System.Collections.Generic;
using MonkeyFestWorkshop.Domain.Models;

namespace MonkeyFestWorkshop.Droid
{
    public class VehiclesList
    {
        private readonly List<BaseVehicle> vehicles;

        public VehiclesList()
        {
            vehicles = new List<BaseVehicle>();

            var car = new Car();
            car.Id = "1";
            car.BrandName = "Mazda";
            car.Line = "3";
            car.Model = "2019";
            car.Plate = "XXX111";
            vehicles.Add(car);

            var motorcycle = new Motorcycle();
            motorcycle.Id = "2";
            vehicles.Add(motorcycle);
        }

        public List<BaseVehicle> GetVehicles()
        {
            return vehicles;
        }
    }
}
