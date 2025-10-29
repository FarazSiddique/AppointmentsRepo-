using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbOperationsWithEFCoreApp.Core.Entities
{
    public class DoctorYearlyHoliday
    {
        [Key]
        public int DoctorYearlyHolidayId { get; set; }
        public DateOnly Holiday_From { get; set; }
        public DateOnly Holiday_To { get; set; }
        public string? Holiday_title { get; set; }
        public DateOnly Holiday_date { get; set; }
        public string? Created_By { get; set; }
        public DateOnly Created_Date { get; set; }

        [ForeignKey(nameof(Holiday_ids))]
        public int Holiday_id { get; set; }
        public HOLIDAYS? Holiday_ids { get; set; }


        [ForeignKey(nameof(clinic_Codes))]
        public int clinic_Code { get; set; }
        public Clinics? clinic_Codes { get; set; }


        [ForeignKey(nameof(LocationCodes))]
        public int LocationCode { get; set; }
        public Location? LocationCodes { get; set; }


        [ForeignKey(nameof(DoctorsCodes))]
        public string? DoctorsCode { get; set; }
        public Doctors? DoctorsCodes { get; set; }
    }
}
