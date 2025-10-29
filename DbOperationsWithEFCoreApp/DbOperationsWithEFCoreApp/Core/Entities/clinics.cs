
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbOperationsWithEFCoreApp.Core.Entities
{
    public class Clinics
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int clinic_Code { get; set; }
        public string? clinic_Name { get; set; }
        public string? clinic_Address { get; set; }
        public string? clinic_State { get; set; }
        public string? clinic_LICENSE_NUMBER { get; set; }
        public string? clinic_City { get; set; }
        public string? clinic_Zip { get; set; }
        public string? clinic_URL { get; set; }
        public string? clinic_Phone { get; set; }
        public string? clinic_Alternate_Phone { get; set; }
        public string? clinic_Tax_Id { get; set; }
        public string? Office_Manager { get; set; }
        public string? Email_Address { get; set; }
        public string? County { get; set; }
        public string? Location_Number { get; set; }
        public string? Created_By { get; set; }
        public string? Created_Date { get; set; }
        public bool Is_Active { get; set; }
        public string? PHONE_TYPE { get; set; }

        public ICollection<AppoitnmentReasonsList>? AppoitnmentReasons { get; set; }
        public ICollection<Location>? DoctorLocations { get; set; } 
        public ICollection<Doctors>? Doctors { get; set; }

        [ForeignKey(nameof(Clinic_Types))]
        public char clinic_Type { get; set; }
        public Clinic_Types? Clinic_Types { get; set; }

        
        [ForeignKey(nameof(PHONE_CODES))]
        public int PHONE_CODE { get; set; }
        public CellNo_Types? PHONE_CODES { get; set; }
    }
}
