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
    public class PatientMap : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");

        }
    }
}
