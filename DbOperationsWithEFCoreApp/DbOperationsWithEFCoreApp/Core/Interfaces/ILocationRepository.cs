using DbOperationsWithEFCoreApp.Application.DTOs;
using DbOperationsWithEFCoreApp.Core.Entities;

namespace DbOperationsWithEFCoreApp.Core.Interfaces
{
    public interface ILocationRepository
    {
        Task<IEnumerable<LocationDto>> GetAllLocationsAsync(int clinic_Code);
    }
}
