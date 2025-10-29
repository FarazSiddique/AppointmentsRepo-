using DbOperationsWithEFCoreApp.Application.DTOs;
using DbOperationsWithEFCoreApp.Core.Entities;
using DbOperationsWithEFCoreApp.Core.Interfaces;

namespace DbOperationsWithEFCoreApp.Application.Services
{
    public class ReasonService
    {
        private readonly IReasonRepository _reasonRepository;

        public ReasonService(IReasonRepository reasonRepository)
        {
            _reasonRepository = reasonRepository;
        }

        public async Task<IEnumerable<AppointmentReasonDto>> GetAllReasonsAsync(int clinic_Code)
        {
            return await _reasonRepository.GetAllReasonsAsync(clinic_Code);
        }
    }
}
