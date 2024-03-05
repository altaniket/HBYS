using HBYS.DAL.Entities.Abstract;
using HBYS.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBYS.DAL.Entities.Concreate
{
    public class Patient:Person
    {
        public string Anamnesis { get; set; }
        public DateTime? Appointment { get; set; }
        public Gravidity gravidity { get; set; }


    }
}
