namespace DbOperationsWithEFCoreApp.Core.Entities
{
    public class PatientsAppointment
    {
        public int Appointment_Id { get; set; }
        public int DoctorsCode { get; set; }
        public int Patient_Account { get; set; }
        public int Facility_Id { get; set; }
        public int Reason_Id { get; set; }
        public string? Notes { get; set; }
        public DateTime Appointment_Date_Time { get; set; }
        public int Appointment_Status_Id { get; set; }
        public int Location_Id { get; set; }
        public string? Time_From { get; set; }
        public int clinic_Code { get; set; }
        public bool IsBreakTime { get; set; }
        public bool IsMeetingTime { get; set; }
        public int Duration { get; set; }
        public int Attending_Physician { get; set; }
        public bool is_NewPatient_Appointment { get; set; }
        public int App_Source { get; set; }
        public int amountcollected { get; set; }
        public string? Eligibility_Remarks { get; set; }
        public bool Reminder_Call { get; set; }
        public int Previous_Balance { get; set; }
        public int patient_arrived { get; set; }
        public DateTime arrived_time { get; set; }
        public bool Arrive_In_Room { get; set; }
        public int Appointment_Room_ID { get; set; }
        public int Appointment_Units { get; set; }
        public DateTime ReScheduleDate { get; set; }
        public string? Created_By { get; set; }
        public DateTime Created_Date { get; set; }
    }
}
