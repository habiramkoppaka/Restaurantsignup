using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace RestarurantSignup.DataAccessLayer.Repositories
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        protected readonly RestarurantContext _context;

        protected readonly DbSet<T> _dbSet;



        public GenericRepository(RestarurantContext context)                                 // ctor  which  Initi
        {
            _context = context;

            _dbSet = context.Set<T>();


        }
        // adds an entity<T>
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        // removes an entity<T>
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();

        }
        // find the entity<T> based on ID
        public T GetById(int id)
        {
            return _dbSet.Find(id);

        }
        // finf the entity based on name
        public T GetByName(string name)
        {
            return _dbSet.Find(name);
            /* return _context.Set<T>().FirstOrDefault(x=>x.name == name);  */
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Update(T enity)
        {
            _dbSet.Attach(enity);
            _context.Entry(enity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        //public T Get(Expression<Func<T, bool>> where)   //
        ////{
        //throw new NotImplementedException();
        ////}
    }

}
