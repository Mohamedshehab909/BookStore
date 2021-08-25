using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);

        IQueryable<T> GetAll();

        T Add(T entity);

        T Update(T entity);
        void Delete(int id);
    }
}
