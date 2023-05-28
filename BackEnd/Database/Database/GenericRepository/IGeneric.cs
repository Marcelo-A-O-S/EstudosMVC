using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Database.Generic
{
    public interface IGeneric<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> Get(Expression<Func<T , bool>> expression);
        void Update(T entity);
        void Add(T entity);
        void Delete(T entity);
    }
}
