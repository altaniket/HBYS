using HBYS.BLL.Repositories.BaseRepository;
using HBYS.BLL.Repositories.Concreate;
using HBYS.BLL.Services.Contract;
using HBYS.DAL.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBYS.BLL.Services
{
    public class DoctorService:IDoctorService
    {
        IRepository<Doctor> doctorRepository;
        public DoctorService(IRepository<Doctor> repository)
        {
            doctorRepository = repository;
        }
        public void Add(Doctor doctor)
        {
            doctorRepository.Add(doctor);
        }

        public void Delete(Doctor item)
        {
            doctorRepository.Delete(item);
        }

        public List<Doctor> Get(Func<Doctor, bool> exp)
        {
            return doctorRepository.Get(exp);
        }

        public List<Doctor> GetAll()
        {
            return doctorRepository.GetAll();
        }

        public Doctor GetById(Guid id)
        {
            return doctorRepository.GetById(id);
        }

        public List<Doctor> GetListByName(string name)
        {
            return doctorRepository.Get(x=>x.FirstName==name);
        }

        public void Update(Doctor item)
        {
            doctorRepository.Update(item);
        }
    }
}
