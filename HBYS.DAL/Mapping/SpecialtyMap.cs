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
    public class SpecialtyMap : IEntityTypeConfiguration<Specialty>
    {
        public void Configure(EntityTypeBuilder<Specialty> builder)
        {
            builder.Property(x=>x.Code).IsRequired().HasMaxLength(100).HasColumnType("text");
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnType("text");
            builder.Property(x => x.Description).IsRequired(false).HasMaxLength(250).HasColumnType("text");
            
        }
    }
}
