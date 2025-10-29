using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbOperationsWithEFCoreApp.Core.Entities
{
    public class Doctor_Working_Days_Time
    {
        [Key]
        public int Doctor_Working_Days_Time_ID { get; set; }
        public string? Weekday_Id { get; set; }
        public DateTime Time_From { get; set; }
        public DateTime Time_To { get; set; }
        public DateTime Break_Time_From { get; set; }
        public DateTime Break_Time_To { get; set; }
        public bool Enable_Break { get; set; }
        public DateTime Date_From { get; set; }
        public DateTime Date_To { get; set; }
        public int Duration { get; set; }
        public string? Created_By { get; set; }
        public DateOnly Created_Date { get; set; }

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
