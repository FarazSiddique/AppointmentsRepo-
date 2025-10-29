using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DbOperationsWithEFCoreApp.Core.Entities
{
    public class TimeSlotsRequest
    {
        [Required(ErrorMessage = "Practice Code is required")]
        public string? ClinicCode { get; set; }
       
        [Required(ErrorMessage = "Provider Code is required")]
        public string? DoctorsCode { get; set; }

        [Required(ErrorMessage = "Location Code is required")]
        public string? LocationCode { get; set; }

        public string? Date { get; set; }

        [Required(ErrorMessage = "Patient Account is required")]
        public string PatientAccount { get; set; }

        [Required(ErrorMessage = "PateintTimeZone is required")]
        public string PatientTimeZone { get; set; }

        public bool IsTelehealth { get; set; }

        public bool IsFirstAvailable { get; set; }

        public string ReasonId { get; set; }
    }

    public class TimeSlotsRequestStandAlone
    {
        [Required(ErrorMessage = "Practice Code is required")]
        public string PracticeCode { get; set; }

        [Required(ErrorMessage = "Provider Code is required")]
        public string ProviderCode { get; set; }

        [Required(ErrorMessage = "Location Code is required")]
        public string LocationCode { get; set; }

        [Required(ErrorMessage = "Reason ID is required")]
        public string ReasonID { get; set; }

        public string Date { get; set; }

        [Required(ErrorMessage = "PateintTimeZone is required")]
        public string PatientTimeZone { get; set; }

        public bool IsTelehealth { get; set; }

        public bool IsFirstAvailable { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public string Value { get; set; }
    }

    public class TimeSlotsRequestStandAloneDateRange
    {
        [Required(ErrorMessage = "Practice Code is required")]
        public string PracticeCode { get; set; }

        [Required(ErrorMessage = "Provider Code is required")]
        public string ProviderCode { get; set; }

        [Required(ErrorMessage = "Location Code is required")]
        public string LocationCode { get; set; }

        [Required(ErrorMessage = "Reason ID is required")]
        public string ReasonID { get; set; }

        public string StartDate { get; set; }
        public string EndDate { get; set; }

        [Required(ErrorMessage = "PateintTimeZone is required")]
        public string PatientTimeZone { get; set; }

        public bool IsTelehealth { get; set; }

        public bool IsFirstAvailable { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public string Value { get; set; }
    }
}
