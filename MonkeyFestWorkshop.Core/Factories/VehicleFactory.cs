using System;
using System.Collections.Generic;
using MonkeyFestWorkshop.Domain.Enumerations;
using MonkeyFestWorkshop.Domain.Models.Vehicle;

namespace MonkeyFestWorkshop.Core.Factories
{
    public class VehicleFactory
    {
        private readonly List<BaseVehicle> vehicles;
        private const string categoryNotFound = "La categoría no ha sido implementada";

        public VehicleFactory(List<BaseVehicle> vehicles)
        {
            this.vehicles = vehicles;
        }

        public List<BaseVehicle> Create(VehicleCategory category)
        {
            var items = new List<BaseVehicle>();

            switch (category)
            {
                case VehicleCategory.Normal:
                    items = new NormalVehicles(vehicles).CreateVehicles();
                    break;
                case VehicleCategory.Featured:
                    items = new FeaturedVehicles(vehicles).CreateVehicles();
                    break;
                default:
                    throw new ArgumentException(categoryNotFound);
            }

            return items;
        }
    }
}
