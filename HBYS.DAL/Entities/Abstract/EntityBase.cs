using HBYS.DAL.Entities.Contract;
using HBYS.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBYS.DAL.Entities.Abstract
{
    public abstract class EntityBase:IEntityBase
    {
        public Guid Id { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public Status? Status { get; set; }

    }
}
