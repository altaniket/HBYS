using HBYS.DAL.Entities.Concreate;
using HBYS.DAL.Mapping;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBYS.DAL.DataContext
{
    public class HBYSDbContext:IdentityDbContext
    {
        public HBYSDbContext(DbContextOptions options):base(options) {}

        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Specialty> Specialities { get; set; }
        public override int SaveChanges()
        {
            //TODO:
            return base.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new DoctorMap());
            builder.ApplyConfiguration(new PatientMap());
            builder.ApplyConfiguration(new SpecialtyMap());
            builder.ApplyConfiguration(new EntityBaseMap());

            base.OnModelCreating(builder);
        }
    }
}
