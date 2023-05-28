using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Database.Context;
using System;

namespace Database.Generic
{
    public abstract class Generic<T> : IDisposable, IGeneric<T> where T : class
    {
        //private readonly DbContextOptions contexto;

        private readonly DbContextOptions<Contexto> contextOptions;
        //private readonly Contexto contexto;
        //public Generic(DbContextOptions contexto)
        //{
        //    this.contexto = contexto;
        //}
        //public Generic()
        //{

        //}
        public Generic()
        {
            contextOptions = new DbContextOptions<Contexto>();
            
        }
        public void Add(T entity)
        {
            using (var data = new Contexto(contextOptions))
            {
                data.Set<T>().Add(entity);
                data.Set<T>().Entry(entity).State = EntityState.Added;
                data.SaveChanges();
            }
        }
        public void Delete(T entity)
        {
            using (var data = new Contexto(contextOptions))
            {
                data.Set<T>().Remove(entity);
                data.Set<T>().Entry(entity).State = EntityState.Deleted;
                data.SaveChanges();
            }
        }

        public void Dispose()
        {
            using (var db = new Contexto(contextOptions))
            {
                db.Dispose();
            }
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression)
        {
            using (var data = new Contexto(contextOptions))
            {
                return await data.Set<T>().FindAsync(expression);
            }
        }

        public async Task<List<T>> GetAll()
        {
            using (var data = new Contexto(contextOptions))
            {
                return await data.Set<T>().ToListAsync();
            }
        }

        public void Update(T entity)
        {
            using (var data = new Contexto())
            {
                data.Set<T>().Update(entity);
                data.Set<T>().Entry(entity).State = EntityState.Modified;
                data.SaveChanges();

            }
        }
    }
}
