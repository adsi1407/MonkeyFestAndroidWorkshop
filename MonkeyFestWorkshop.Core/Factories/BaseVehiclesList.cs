using System;
using System.Collections.Generic;
using MonkeyFestWorkshop.Domain.Models.Vehicle;

namespace MonkeyFestWorkshop.Core.Factories
{
    public abstract class BaseVehiclesList
    {
        protected readonly List<BaseVehicle> Vehicles;

        protected BaseVehiclesList(List<BaseVehicle> vehicles)
        {
            Vehicles = vehicles;
        }

        public abstract List<BaseVehicle> CreateVehicles();
    }
}
