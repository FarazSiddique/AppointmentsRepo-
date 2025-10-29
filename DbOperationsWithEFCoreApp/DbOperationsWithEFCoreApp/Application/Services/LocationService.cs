using DbOperationsWithEFCoreApp.Application.DTOs;
using DbOperationsWithEFCoreApp.Core.Entities;
using DbOperationsWithEFCoreApp.Core.Interfaces;

namespace DbOperationsWithEFCoreApp.Application.Services
{
    public class LocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public async Task<IEnumerable<LocationDto>> GetAllLocationsAsync(int clinic_Code)
        {
            return await _locationRepository.GetAllLocationsAsync(clinic_Code);
        }
    }
}
