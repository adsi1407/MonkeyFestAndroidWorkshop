using System.Collections.Generic;
using System.Linq;
using MonkeyFestWorkshop.DataAccess.Repositories;
using MonkeyFestWorkshop.Domain.Models;

namespace MonkeyFestWorkshop.DataAccess.Implementations.Mock
{
    public class VehicleRepositoryMock : IVehicleRepository<BaseVehicle>
    {
        private readonly List<BaseVehicle> vehicles;

        public VehicleRepositoryMock()
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

        public IEnumerable<BaseVehicle> GetAllVehicles()
        {
            return vehicles;
        }

        public BaseVehicle GetVehicleById(string id)
        {
            return vehicles.FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}
