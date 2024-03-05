using HBYS.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBYS.DAL.Entities.Concreate
{
    public class Specialty:EntityBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
