using HBYS.BLL.Repositories.BaseRepository;
using HBYS.DAL.DataContext;
using HBYS.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HBYS.BLL.Repositories.Concreate
{
    public class BaseRepository<T> : IRepository<T> where T : class, new()
    {
        private readonly HBYSDbContext db;
        public BaseRepository(HBYSDbContext context)
        {
            db= context;
        }

        public void Add(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }
        public void Delete(T item)
        {
            //db.Set<T>().Remove(item);
            //db.SaveChanges();

            //TODO: bir nesnenin propertylerini teslim eder.

            var propertyInfos = item.GetType().GetProperties();
            foreach (PropertyInfo pInfo in propertyInfos)
            {
                if(pInfo.Name=="Status")
                {
                    pInfo.SetValue(item, Enum.ToObject(pInfo.PropertyType, Status.Deleted)); //veri atamasını yapıyoruz.
                }
            }
            Update(item);
        }

        public List<T> Get(Func<T, bool> exp)
        {
          return  db.Set<T>().Where(exp).ToList();
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(Guid id)
        {
            return db.Set<T>().Find(id);
        }

        public void Update(T item)
        {
            db.Set<T>().Update(item);
            db.SaveChanges();
        }
    }
}
