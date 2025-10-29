using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbOperationsWithEFCoreApp.Core.Entities
{
    public class Location
    {
        [Key]
        public int LocationCode { get; set; }
        public string? LocationName { get; set; }
        public string? Location_Address { get; set; }
        public string? Location_City { get; set; }
        public string? Location_State { get; set; }
        public string? Location_Zip { get; set; }
        public string? Created_By { get; set; }
        public string? Created_Date { get; set; }
        public bool Is_Active { get; set; }

        [ForeignKey(nameof(clinic_Codes))]
        public int clinic_Code { get; set; }
        public Clinics? clinic_Codes { get; set; }

    }
}
