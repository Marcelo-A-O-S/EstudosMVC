using Business.Repository.Interfaces;
using Database.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class RepositoryGeneric<T>: Generic<T>, IRepositoryGeneric<T> where T : class
    {
    }
}
