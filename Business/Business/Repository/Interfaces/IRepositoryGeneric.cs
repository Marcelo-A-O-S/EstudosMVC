using Database.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.Interfaces
{
    public interface IRepositoryGeneric<T> : IGeneric<T> where T : class
    {
    }
}
