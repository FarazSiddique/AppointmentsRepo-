using DbOperationsWithEFCoreApp.Application.DTOs;
using DbOperationsWithEFCoreApp.Core.Entities;

namespace DbOperationsWithEFCoreApp.Core.Interfaces
{
    public interface IReasonRepository
    {
        Task<IEnumerable<AppointmentReasonDto>> GetAllReasonsAsync(int clinic_Code);
    }
}
