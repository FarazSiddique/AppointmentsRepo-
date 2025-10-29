using DbOperationsWithEFCoreApp.Application.DTOs;
using DbOperationsWithEFCoreApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Net.Mail;

namespace DbOperationsWithEFCoreApp.Infrastructure.Data
{
    public class AppDBContext :DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor_Working_Days_Time>()
        .HasOne(d => d.clinic_Codes)
        .WithMany()
        .HasForeignKey(d => d.clinic_Code)
        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Doctor_Working_Days_Time>()
                .HasOne(d => d.LocationCodes)
                .WithMany()
                .HasForeignKey(d => d.LocationCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Doctor_Working_Days_Time>()
                .HasOne(d => d.DoctorsCodes)
                .WithMany()
                .HasForeignKey(d => d.DoctorsCode)
                .OnDelete(DeleteBehavior.Restrict);

            // DoctorHoliday relationships
            modelBuilder.Entity<DoctorHoliday>()
                .HasOne(d => d.clinic_Codes)
                .WithMany()
                .HasForeignKey(d => d.clinic_Code)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DoctorHoliday>()
                .HasOne(d => d.LocationCodes)
                .WithMany()
                .HasForeignKey(d => d.LocationCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DoctorHoliday>()
                .HasOne(d => d.DoctorsCodes)
                .WithMany()
                .HasForeignKey(d => d.DoctorsCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DoctorHoliday>()
                .HasOne(d => d.Holiday_ids)
                .WithMany()
                .HasForeignKey(d => d.Holiday_id)
                .OnDelete(DeleteBehavior.Restrict);

            // DoctorYearlyHoliday relationships
            modelBuilder.Entity<DoctorYearlyHoliday>()
                .HasOne(d => d.clinic_Codes)
                .WithMany()
                .HasForeignKey(d => d.clinic_Code)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DoctorYearlyHoliday>()
                .HasOne(d => d.LocationCodes)
                .WithMany()
                .HasForeignKey(d => d.LocationCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DoctorYearlyHoliday>()
                .HasOne(d => d.DoctorsCodes)
                .WithMany()
                .HasForeignKey(d => d.DoctorsCode)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DoctorYearlyHoliday>()
                .HasOne(d => d.Holiday_ids)
                .WithMany()
                .HasForeignKey(d => d.Holiday_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TimeSlotsDto>().HasNoKey();

            modelBuilder.Entity<Doctors>().HasData(
                new Doctors() { DoctorsCode= "1", DoctorsName="Zafar",  DoctorsPrefix= "", clinic_Code=1, Address = "", City = "", Date_Of_Birth = "", Gender = "", License_No = "", Email_Address = "", State = "",Zip = "",Created_By = "", Created_Date = "",Is_Active = true},
                new Doctors() { DoctorsCode= "2", DoctorsName="Sara",   DoctorsPrefix= "", clinic_Code=1, Address = "", City = "", Date_Of_Birth = "", Gender = "", License_No = "", Email_Address = "", State = "",Zip = "",Created_By = "", Created_Date = "",Is_Active = true },
                new Doctors() { DoctorsCode= "3", DoctorsName ="Iqbal", DoctorsPrefix = "",clinic_Code=1, Address = "", City = "", Date_Of_Birth = "", Gender = "", License_No = "", Email_Address = "", State = "",Zip = "",Created_By = "", Created_Date = "",Is_Active = true }
                              );
            modelBuilder.Entity<Location>().HasData(
                new Location() {LocationCode = 1, LocationName="Karachi",clinic_Code=1},
                new Location() { LocationCode= 2, LocationName="Lahore", clinic_Code = 2}
                              );
            modelBuilder.Entity<AppoitnmentReasonsList>().HasData(
                new AppoitnmentReasonsList() { REASON_ID = "1", REASON_NAME = "WELL VISIT", clinic_Code = 1, Created_By = "", Created_Date = "", Is_Active = true },
                new AppoitnmentReasonsList() { REASON_ID = "2", REASON_NAME = "EMPLOYEE PHYSICAL", clinic_Code = 1, Created_By = "", Created_Date = "", Is_Active = true },
                new AppoitnmentReasonsList() { REASON_ID = "3", REASON_NAME = "ACCIDENT CASE", clinic_Code = 1, Created_By = "", Created_Date = "", Is_Active = true },
                new AppoitnmentReasonsList() { REASON_ID = "4", REASON_NAME = "INITIAL VISIT", clinic_Code = 1, Created_By = "", Created_Date = "", Is_Active = true },
                new AppoitnmentReasonsList() { REASON_ID = "5", REASON_NAME = "VACCINATIONS", clinic_Code = 1, Created_By = "", Created_Date = "", Is_Active = true }
                              );
            modelBuilder.Entity<Clinics>().HasData(
                new Clinics() {clinic_Code= 1,clinic_Name= "Test",clinic_Type= 'I',clinic_Address="Test",clinic_State= "Test",clinic_LICENSE_NUMBER= "MA64146",clinic_City="Test",clinic_Zip="1",clinic_URL= "http://www.mhaqmd.com",clinic_Phone="",clinic_Alternate_Phone = "",clinic_Tax_Id = "",Office_Manager = "",Email_Address = "muhammadislam@carecloud.com",County = "LmK",Location_Number = "",Created_By = "Sumair",Created_Date = "2018-05-09 15:09:54.3030000",Is_Active = true,PHONE_TYPE = "",PHONE_CODE=5001},
                new Clinics() {clinic_Code= 2,clinic_Name= "MTBC Test",clinic_Type= 'I',clinic_Address="Test",clinic_State= "Test",clinic_LICENSE_NUMBER= "MA64146",clinic_City="Test",clinic_Zip="1",clinic_URL= "http://www.mhaqmd.com",clinic_Phone="",clinic_Alternate_Phone = "",clinic_Tax_Id = "",Office_Manager = "",Email_Address = "muhammadislam@carecloud.com",County = "LmK",Location_Number = "",Created_By = "Sumair",Created_Date = "2018-05-09 15:09:54.3030000",Is_Active = true,PHONE_TYPE = "",PHONE_CODE=5001}
                              
                );

            modelBuilder.Entity<Clinic_Types>().HasData(
                new Clinic_Types() {clinic_Type = 'G', clinic_Type_Description = "Group" },
                new Clinic_Types() {clinic_Type = 'I', clinic_Type_Description = "Individual" },
                new Clinic_Types() {clinic_Type = 'S', clinic_Type_Description = "Supplier" });

            modelBuilder.Entity<CellNo_Types>().HasData(
                new CellNo_Types() {PHONE_CODE= 5001, PHONE_TYPE= "HOME",Created_By="Sumair", Created_Date= "2018-05-09 15:09:54.3030000", Is_Active= true},
                new CellNo_Types() {PHONE_CODE= 5002, PHONE_TYPE= "OFFICE", Created_By="Sumair", Created_Date= "2018-05-09 15:09:54.3030000", Is_Active= true},
                new CellNo_Types() {PHONE_CODE= 5003, PHONE_TYPE= "CELL", Created_By="Sumair", Created_Date= "2018-05-09 15:09:54.3030000", Is_Active= true });

            modelBuilder.Entity<HOLIDAYS>().HasData(
                new HOLIDAYS() { Holiday_id=1, Holiday_date=new DateOnly(2026,02,05) , Holiday_Title="Kashmir Sloidarity Day"},
                new HOLIDAYS() { Holiday_id=2, Holiday_date= new DateOnly(2026,02,21), Holiday_Title="Eid Fitar"},
                new HOLIDAYS() { Holiday_id=3, Holiday_date= new DateOnly(2026,05,01), Holiday_Title="Labour Day"},
                new HOLIDAYS() { Holiday_id=4, Holiday_date= new DateOnly(2026,05,27), Holiday_Title="Eid Azha"}
                );

            modelBuilder.Entity<DoctorHoliday>().HasData(
                new DoctorHoliday() { DoctorHolidayId=1 ,Holiday_id = 1, clinic_Code = 1, DoctorsCode = "1", LocationCode = 1, Created_Date = new DateOnly(2025,10,10), Created_By = "System", IsWorkingDay = true },
                new DoctorHoliday() { DoctorHolidayId = 2, Holiday_id = 1, clinic_Code = 1, DoctorsCode = "1", LocationCode = 1, Created_Date = new DateOnly(2025,10,10), Created_By = "System", IsWorkingDay = false },
                new DoctorHoliday() {DoctorHolidayId = 3, Holiday_id = 1, clinic_Code = 1, DoctorsCode = "1", LocationCode = 1, Created_Date = new DateOnly(2025,10,10), Created_By = "System", IsWorkingDay = false },
                new DoctorHoliday() {DoctorHolidayId = 4, Holiday_id = 1, clinic_Code = 1, DoctorsCode = "1", LocationCode = 1, Created_Date = new DateOnly(2025,10,10), Created_By = "System", IsWorkingDay = true }
                );

             modelBuilder.Entity<Doctor_Working_Days_Time>().HasData(
                new Doctor_Working_Days_Time() { Doctor_Working_Days_Time_ID = 1, clinic_Code = 1, DoctorsCode = "1", LocationCode = 1,Date_From = new DateTime(2025, 10, 14, 12, 30, 0), Date_To= new DateTime(2025, 10, 14, 12, 30, 0),
                    Enable_Break= true,Duration=60,Weekday_Id= "1", Break_Time_From= new DateTime(2025, 10, 14, 12, 30, 0), Break_Time_To= new DateTime(2025, 10, 8, 13, 30, 0),Time_From = new DateTime(2025, 10, 14, 12, 30, 0),
                    Time_To= new DateTime(2025, 10, 14, 13, 30, 0), Created_Date = new DateOnly(2025,10,10), Created_By = "System" }
                
                );

             modelBuilder.Entity<DoctorYearlyHoliday>().HasData(
                new DoctorYearlyHoliday() { DoctorYearlyHolidayId= 1, Holiday_id = 1, clinic_Code = 1, DoctorsCode = "1", LocationCode = 1,Holiday_title= "Kashmir Sloidarity Day", Holiday_date= new DateOnly(2026, 02, 05),  Holiday_From= new DateOnly(2026, 02, 05), Holiday_To= new DateOnly(2026, 02, 05), Created_Date = new DateOnly(2025,10,14), Created_By = "System" },
                new DoctorYearlyHoliday() { DoctorYearlyHolidayId = 2, Holiday_id = 2, clinic_Code = 1, DoctorsCode = "1", LocationCode = 1,Holiday_title= "Eid Fitar", Holiday_date= new DateOnly(2026, 02, 21),  Holiday_From= new DateOnly(2026, 02, 21), Holiday_To= new DateOnly(2026, 02, 21), Created_Date = new DateOnly(2025,10,14), Created_By = "System" },
                new DoctorYearlyHoliday() { DoctorYearlyHolidayId = 3, Holiday_id = 4, clinic_Code = 1, DoctorsCode = "1", LocationCode = 1,Holiday_title= "Eid Azha", Holiday_date= new DateOnly(2026, 05, 27),  Holiday_From= new DateOnly(2026, 05, 27), Holiday_To= new DateOnly(2026, 05, 27), Created_Date = new DateOnly(2025,10,14), Created_By = "System" }
                
                );
        }
        public DbSet<Clinics> Clinics { get; set; }
        public DbSet<Clinic_Types> Clinics_Types { get; set; }
        public DbSet<CellNo_Types> CellNo_Types { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Location> DoctorLocations { get; set; }
        public DbSet<AppoitnmentReasonsList> ReasonsAppointment { get; set; }
        public DbSet<DoctorHoliday> DoctorHoliday { get; set; }
        public DbSet<Doctor_Working_Days_Time> Doctor_Working_Days_Time { get; set; }
        public DbSet<DoctorYearlyHoliday> DoctorYearlyHoliday { get; set; }
        public DbSet<TimeSlotsDto> PatientsAppointment { get; set; }
    
    
    }
}
