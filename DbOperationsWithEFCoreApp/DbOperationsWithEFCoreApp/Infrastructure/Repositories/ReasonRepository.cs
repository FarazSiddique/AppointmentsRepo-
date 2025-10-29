using DbOperationsWithEFCoreApp.Application.DTOs;
using DbOperationsWithEFCoreApp.Core.Entities;
using DbOperationsWithEFCoreApp.Core.Interfaces;
using DbOperationsWithEFCoreApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Infrastructure.Repositories
{
    public class ReasonRepository : IReasonRepository
    {
        private readonly AppDBContext _context;

        public ReasonRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AppointmentReasonDto>> GetAllReasonsAsync(int clinic_Code)
        {
            return await _context.ReasonsAppointment
                                 .Where(r=> r.clinic_Code == clinic_Code && r.Is_Active)
                                 .Select(r => new AppointmentReasonDto
                                 {
                                     REASON_ID = r.REASON_ID,
                                     REASON_NAME = r.REASON_NAME
                                 })
                                  .ToListAsync();
        }

    }
}
