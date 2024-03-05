using HBYS.DAL.Entities.Abstract;
using HBYS.DAL.Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBYS.DAL.Mapping
{
    public class DoctorMap:IEntityTypeConfiguration<Doctor>
    {

        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
            builder.Property(x=>x.LastName).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
            builder.Property(x => x.SpecialtyID).IsRequired();


        }
    }
}
