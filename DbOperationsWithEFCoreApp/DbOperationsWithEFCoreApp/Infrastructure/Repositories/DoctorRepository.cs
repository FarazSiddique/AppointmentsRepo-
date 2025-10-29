using DbOperationsWithEFCoreApp.Application.DTOs;
using DbOperationsWithEFCoreApp.Core.Entities;
using DbOperationsWithEFCoreApp.Core.Interfaces;
using DbOperationsWithEFCoreApp.Infrastructure.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Infrastructure.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly AppDBContext _context;

        public DoctorRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DoctorDto>> GetAllDoctorsAsync(int clinic_Code)
        {
            try
            {
            return await _context.Doctors
                    .Where(d => d.clinic_Code == clinic_Code && d.Is_Active)
                    .Select(d => new DoctorDto
                    {
                        DoctorsCode=d.DoctorsCode,
                        DoctorsName=d.DoctorsName
                    })
                    .ToListAsync();
              }
            catch (Exception ex)
            {
                Console.WriteLine("Exception", ex);
                return null;
            }
        }
    }
}
