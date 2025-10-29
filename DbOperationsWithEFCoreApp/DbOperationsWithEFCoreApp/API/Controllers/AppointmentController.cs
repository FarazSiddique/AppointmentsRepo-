using DbOperationsWithEFCoreApp.Application.Services;
using DbOperationsWithEFCoreApp.Core.Entities;
using DbOperationsWithEFCoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace DbOperationsWithEFCoreApp.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        //private readonly AppDBContext _appDBContext;
        private readonly DoctorService _doctorService;
        private readonly LocationService _locationService;
        private readonly ReasonService _reasonService;
        private readonly TimeSlotsService _slotsService;

        public AppointmentController(DoctorService doctorService, LocationService locationService, ReasonService reasonService, TimeSlotsService timeSlotsService)
        {
            _doctorService = doctorService;
            _locationService = locationService;
            _reasonService = reasonService;
            _slotsService = timeSlotsService;

        }
        [HttpGet("doctor")]
        public async Task<IActionResult> Provider(int clinic_Code)
        {
            var result = await _doctorService.GetAllDoctorsAsync(clinic_Code);

            return Ok(result);
        }

        [HttpGet("drLocation")]
        public async Task<IActionResult> GetLocations(int clinic_Code)
        {
            var locations = await _locationService.GetAllLocationsAsync(clinic_Code);
            return Ok(locations);
        }

        [HttpGet("reasons")]
        public async Task<IActionResult> GetReasons(int clinic_Code)
        {
            var reasons = await _reasonService.GetAllReasonsAsync(clinic_Code);
            return Ok(reasons);
        }

        [HttpPost("GettimeSlots")]
        public async Task<IActionResult> GetTimeSlots(TimeSlotsRequest timeSlotsRequest)
        {
            try
            {
                var reasons = await _slotsService.GetAllTimeSlotsAsync(timeSlotsRequest);
                return Ok(reasons);

            }
            catch (Exception)
            {
                return BadRequest(new ResponseResult<string>
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError,
                    Message = "internal server error",
                    Data = null
                });
            }

        }
    }
}
