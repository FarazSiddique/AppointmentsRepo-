using System.Collections.Generic;
using System.Threading.Tasks;
using DbOperationsWithEFCoreApp.Application.DTOs;
using DbOperationsWithEFCoreApp.Core.Entities;

namespace DbOperationsWithEFCoreApp.Core.Interfaces
{
    public interface IDoctorRepository
    {
        Task<IEnumerable<DoctorDto>> GetAllDoctorsAsync(int PracticeCode);
    }
}
