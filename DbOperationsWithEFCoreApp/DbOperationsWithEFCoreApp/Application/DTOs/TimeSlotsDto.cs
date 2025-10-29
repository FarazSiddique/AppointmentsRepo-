using Newtonsoft.Json;

namespace DbOperationsWithEFCoreApp.Application.DTOs
{
    public class TimeSlotsDto
    {
        public string? AVAILABLE_SLOT { get; set; }
        public string? AVAILABLE_DATE { get; set; }
        //public string? SpecializationName { get; set; }
        //public string? Duration { get; set; }
    }
}
