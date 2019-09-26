using System.Collections.Generic;
using MonkeyFestWorkshop.Domain.Models;

namespace MonkeyFestWorkshop.DataAccess.Repositories
{
    public interface IVehicleRepository<T> where T : BaseVehicle
    {
        IEnumerable<T> GetAllVehicles();

        T GetVehicleById(string id);
    }
}
