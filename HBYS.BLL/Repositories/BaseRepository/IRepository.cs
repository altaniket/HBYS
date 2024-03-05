using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBYS.BLL.Repositories.BaseRepository
{
    public interface IRepository<T> where T : class, new()
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        List<T> GetAll();
        T GetById(Guid id);
        List<T> Get(Func<T,bool> exp);
    }
}
