using System.Collections.Generic;
using System.Linq;
using MonkeyFestWorkshop.DataAccess.Repositories;
using MonkeyFestWorkshop.Domain.Models.Vehicle;

namespace MonkeyFestWorkshop.DataAccess.Implementations.Mock
{
    public class VehicleRepositoryMock : IVehicleRepository<BaseVehicle>
    {
        private readonly List<BaseVehicle> vehicles;

        public VehicleRepositoryMock()
        {
            vehicles = new List<BaseVehicle>();

            var car1 = new Car();
            car1.Id = "1";
            car1.BrandName = "Mazda";
            car1.Line = "Automóvil";
            car1.Model = "2019";
            car1.Plate = "AAA112";
            car1.Price = "$10,200";
            vehicles.Add(car1);

            var car2 = new Car();
            car2.Id = "2";
            car2.BrandName = "Renult";
            car2.Line = "Automóvil";
            car2.Model = "2018";
            car2.Plate = "AAA113";
            car2.Price = "$11,200";
            vehicles.Add(car2);

            var car3 = new Car();
            car3.Id = "3";
            car3.BrandName = "Hyundai";
            car3.Line = "Automóvil";
            car3.Model = "2017";
            car3.Plate = "AAA114";
            car3.Price = "$12,200";
            vehicles.Add(car3);

            var motorcycle1 = new Motorcycle();
            motorcycle1.Id = "4";
            motorcycle1.BrandName = "BMW";
            motorcycle1.Line = "Motocicleta";
            motorcycle1.Model = "2016";
            motorcycle1.Plate = "AAA115";
            motorcycle1.Price = "$13,200";
            vehicles.Add(motorcycle1);

            var motorcycle2 = new Motorcycle();
            motorcycle2.Id = "5";
            motorcycle2.BrandName = "Suzuki";
            motorcycle2.Line = "Motocicleta";
            motorcycle2.Model = "2015";
            motorcycle2.Plate = "AAA116";
            motorcycle2.Price = "$14,200";
            vehicles.Add(motorcycle2);

            var car6 = new Car();
            car6.Id = "6";
            car6.BrandName = "Mercedez";
            car6.Line = "Automóvil";
            car6.Model = "2014";
            car6.Plate = "AAA117";
            car6.Price = "$15,200";
            vehicles.Add(car6);

            var car7 = new Car();
            car7.Id = "7";
            car7.BrandName = "Hino";
            car7.Line = "Automóvil";
            car7.Model = "2013";
            car7.Plate = "AAA117";
            car7.Price = "$16,200";
            vehicles.Add(car7);
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
