using Hospital.Models;
using Hospital.Models.Bill;
using Hospital.Models.Hospital;
using Hospital.Models.Lab;
using Hospital.Models.Patient;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Repository
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<tbl_Lab> tbl_Lab { get; set; }
        public DbSet<tbl_TestPrice> tbl_TestPrice { get; set; }
        public DbSet<tbl_Bill> tbl_Bill { get; set; }
        public DbSet<tbl_Insurance> tbl_Insurance { get; set; }
        public DbSet<tbl_Contacts> tbl_Contacts { get; set; }
        public DbSet<tbl_Hospital> tbl_Hospital { get; set; }
        public DbSet<tbl_Rooms> tbl_Rooms { get; set; }
        public DbSet<tbl_RoomStatus> tbl_RoomStatus { get; set; }
        public DbSet<tbl_StatusType> tbl_StatusType { get; set; }
        public DbSet<tbl_Appointment> tbl_Appointment { get; set; }
        public DbSet<tbl_City> tbl_City { get; set; }
        public DbSet<tbl_Country> tbl_Country { get; set; }
        public DbSet<tbl_Department> tbl_Department { get; set; }
        public DbSet<tbl_PayRoll> tbl_PayRoll { get; set; }
        public DbSet<tbl_States> tbl_States { get; set; }
        public DbSet<tbl_Supplier> tbl_Supplier { get; set; }
        public DbSet<tbl_User> tbl_User { get; set; }

    }

}
