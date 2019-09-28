using System.Collections.Generic;
using MonkeyFestWorkshop.Domain.Models.Menu;

namespace MonkeyFestWorkshop.Core.Contracts.Platform
{
    public interface IVehicleData
    {
        void ProcessVehicleData(List<SectionItem> sectionItems);
    }
}
