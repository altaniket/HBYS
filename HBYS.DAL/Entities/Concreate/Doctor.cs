using HBYS.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBYS.DAL.Entities.Concreate
{
    public class Doctor:Person
    {

        public Guid SpecialtyID { get; set; }

        //Navigate Prop
        public Specialty Specialty { get; set; }

    }
}
