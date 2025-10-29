using DbOperationsWithEFCoreApp.Application.DTOs;
using DbOperationsWithEFCoreApp.Core.Entities;
using DbOperationsWithEFCoreApp.Core.Interfaces;
using DbOperationsWithEFCoreApp.Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

namespace DbOperationsWithEFCoreApp.Infrastructure.Repositories
{
    public class TimeSlotsRepository : ITimeSlotsRepository
    {
        private readonly AppDBContext _context;

        public TimeSlotsRepository(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TimeSlotsDto>> GetAllTimeSlotsAsync(TimeSlotsRequest timeSlotsRequest)
        {
            //string spName = @"APPOINTMENT_GET_TIME_SLOTS";
            var ClinicCode = new SqlParameter("@ClinicCode", timeSlotsRequest.ClinicCode);
            var DoctorsCode = new SqlParameter("@DoctorsCode", timeSlotsRequest.DoctorsCode);
            var LocationCode = new SqlParameter("@LocationCode", timeSlotsRequest.LocationCode);
            var appointmentDate = new SqlParameter("@Date", timeSlotsRequest.Date);

            var result = await _context.PatientsAppointment
                .FromSqlRaw("EXEC APPOINTMENT_GET_TIME_SLOTS @ClinicCode, @DoctorsCode, @LocationCode, @Date", ClinicCode, DoctorsCode, LocationCode, appointmentDate)
                .ToListAsync();

                 return result;

        }
    }
}
