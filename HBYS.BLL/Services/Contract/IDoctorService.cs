using HBYS.DAL.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBYS.BLL.Services.Contract
{
    //Dzayn Patternler genellikle Interface üzerinden çalışır.
    public interface IDoctorService
    {
        void Add(Doctor item);
        void Update(Doctor item);
        void Delete(Doctor item);
        List<Doctor> GetAll();
        Doctor GetById(Guid id);
        List<Doctor> Get(Func<Doctor, bool> exp);

        List<Doctor> GetListByName(string name);
    }
}
