using HBYS.DAL.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBYS.DAL.Mapping
{
    public class EntityBaseMap : IEntityTypeConfiguration<EntityBase>
    {
        public void Configure(EntityTypeBuilder<EntityBase> builder)
        {
            builder.Property(x => x.CreatedBy).IsRequired(required: false);
            builder.Property(x => x.CreatedDate).IsRequired(required: false);
            builder.Property(x => x.Status).IsRequired(required: false);


        }
    }
}
