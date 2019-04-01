using Microsoft.EntityFrameworkCore;

namespace health_record_app.Models
{
    public class HealthRecordAppContext : DbContext
    {
        public HealthRecordAppContext(DbContextOptions<HealthRecordAppContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder) => base.OnModelCreating(builder);

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Illness> Illnesses { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Patient> Patient { get; set; }

    }
}
