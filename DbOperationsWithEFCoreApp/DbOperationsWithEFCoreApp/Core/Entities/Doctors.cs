using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbOperationsWithEFCoreApp.Core.Entities
{
    public class Doctors
    {
        [Key]
        public string? DoctorsCode { get; set; }
        public string? DoctorsName { get; set; }
        public string? DoctorsPrefix { get; set; }
        public string? Gender { get; set; }
        public string? Email_Address { get; set; }
        public string? License_No { get; set; }
        public string? Date_Of_Birth { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Created_By { get; set; }
        public string? Created_Date { get; set; }
        public bool Is_Active { get; set; }

        [ForeignKey(nameof(clinic_Codes))]
        public int clinic_Code { get; set; }
        public Clinics? clinic_Codes { get; set; }
    }
}
