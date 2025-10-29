
using System.ComponentModel.DataAnnotations;

namespace DbOperationsWithEFCoreApp.Core.Entities
{
    public class CellNo_Types
    {


        [Key]   
        public int PHONE_CODE { get; set; }
        public string? PHONE_TYPE { get; set; }
        public string? Created_By { get; set; }
        public string? Created_Date { get; set; }
        public bool Is_Active { get; set; }

        public ICollection<Clinics>? Clinics { get; set; }
       
    }
}
