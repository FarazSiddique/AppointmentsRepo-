using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbOperationsWithEFCoreApp.Core.Entities
{
    public class AppoitnmentReasonsList
    {
        [Key]
        public string? REASON_ID { get; set; }
        public string? REASON_NAME { get; set; }
        public string? Created_By { get; set; }
        public string? Created_Date { get; set; }
        public bool Is_Active { get; set; }

        [ForeignKey(nameof(clinic_Codes))]
        public int clinic_Code { get; set; }
        public Clinics? clinic_Codes { get; set; }

    }
}
