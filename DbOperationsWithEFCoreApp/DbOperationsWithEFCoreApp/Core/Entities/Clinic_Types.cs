using System.ComponentModel.DataAnnotations;

namespace DbOperationsWithEFCoreApp.Core.Entities
{
    public class Clinic_Types
    {
        [Key]
        public char clinic_Type { get; set; }
        public string? clinic_Type_Description { get; set; }

        public ICollection<Clinics>? Clinics { get; set; }
    }
}
