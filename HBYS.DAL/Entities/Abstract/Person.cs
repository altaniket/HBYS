using HBYS.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBYS.DAL.Entities.Abstract
{
    public abstract class Person:EntityBase
    {
        public string IdentityNo { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }

    }
}
