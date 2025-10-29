using DbOperationsWithEFCoreApp.Core.Interfaces;
using DbOperationsWithEFCoreApp.Core.Entities;
using DbOperationsWithEFCoreApp.Application.DTOs;

namespace DbOperationsWithEFCoreApp.Application.Services
{
    public class DoctorService
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task<IEnumerable<DoctorDto>> GetAllDoctorsAsync(int clinic_Code)
        {
            return await _doctorRepository.GetAllDoctorsAsync(clinic_Code);
        }
    }
}
