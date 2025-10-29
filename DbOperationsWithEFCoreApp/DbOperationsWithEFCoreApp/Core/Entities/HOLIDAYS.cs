using System.ComponentModel.DataAnnotations;

namespace DbOperationsWithEFCoreApp.Core.Entities
{
    public class HOLIDAYS
    {
        [Key]
        public int Holiday_id { get; set; }
        public DateOnly Holiday_date { get; set; }
        public string? Holiday_Title { get; set; }

        public ICollection<DoctorHoliday>? DoctorHolidays { get; set; }
    }
}
