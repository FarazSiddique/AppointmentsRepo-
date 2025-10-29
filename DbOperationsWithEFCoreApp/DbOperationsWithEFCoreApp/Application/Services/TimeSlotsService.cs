using DbOperationsWithEFCoreApp.Application.DTOs;
using DbOperationsWithEFCoreApp.Core.Entities;
using DbOperationsWithEFCoreApp.Core.Interfaces;

namespace DbOperationsWithEFCoreApp.Application.Services
{
    public class TimeSlotsService
    {
        private readonly ITimeSlotsRepository _timeSlotsRepository;

        public TimeSlotsService(ITimeSlotsRepository timeSlotsRepository)
        {
            _timeSlotsRepository = timeSlotsRepository;
        }

        public async Task<IEnumerable<TimeSlotsDto>> GetAllTimeSlotsAsync(TimeSlotsRequest timeSlotsRequest)
        {
            return await _timeSlotsRepository.GetAllTimeSlotsAsync(timeSlotsRequest);
        }
    }
}
