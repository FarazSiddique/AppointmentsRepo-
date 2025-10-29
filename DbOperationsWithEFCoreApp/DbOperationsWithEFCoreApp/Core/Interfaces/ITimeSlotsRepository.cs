using DbOperationsWithEFCoreApp.Application.DTOs;
using DbOperationsWithEFCoreApp.Core.Entities;

namespace DbOperationsWithEFCoreApp.Core.Interfaces
{
    public interface ITimeSlotsRepository
    {
        Task<IEnumerable<TimeSlotsDto>> GetAllTimeSlotsAsync(TimeSlotsRequest timeSlotsRequest);
    }
}
