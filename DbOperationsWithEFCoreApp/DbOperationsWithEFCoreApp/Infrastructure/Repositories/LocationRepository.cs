using DbOperationsWithEFCoreApp.Application.DTOs;
using DbOperationsWithEFCoreApp.Core.Entities;
using DbOperationsWithEFCoreApp.Core.Interfaces;
using DbOperationsWithEFCoreApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Infrastructure.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly AppDBContext _context;

        public LocationRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LocationDto>> GetAllLocationsAsync(int clinic_Code)
        {
            return await _context.DoctorLocations
                .Where(l => l.clinic_Code == clinic_Code && l.Is_Active)
                .Select(l => new LocationDto
                {
                    LocationCode=l.LocationCode,
                    LocationName=l.LocationName
                })
                .ToListAsync();
        }
    }
}
