using BL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected ApplicationDbContext _Context;
        public BaseRepository(ApplicationDbContext Context)
        {
            this._Context = Context;
        }

        public T Add(T entity)
        {
            _Context.Set<T>().Add(entity);
            return entity;
        }

        public IQueryable<T> GetAll()
        {
            return _Context.Set<T>();
        }

        public T GetById(int id)
        {
            return _Context.Set<T>().Find(id);
        }

        public T Update(T entity)
        {
            _Context.Update(entity);
            return entity;
        }


        public void Delete(int id)
        {
            var entity = _Context.Set<T>().Find(id);
            _Context.Set<T>().Remove(entity);
        }
    }
}
