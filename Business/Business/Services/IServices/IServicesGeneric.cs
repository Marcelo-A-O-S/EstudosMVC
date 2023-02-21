using Business.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.IServicesGeneric
{
    public interface IServicesGeneric<T>
    {
        
        string Add(T entity);
        string Delete(T entity);
        Task<T> Get(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAll();
    }
}
