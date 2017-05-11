using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestarurantSignup.DataAccessLayer.Repositories
{
    public interface IRepository<T> where T : class
    {

        // add the entity
        void Add(T entity);


        // delete the entity
        void Delete(T entity);

        // update based on entity
        void Update(T enity);



        //returns elements based on ID
        T GetById(int id);


        //returns element based name
        T GetByName(string Name);



        // returns list of elements
        IEnumerable<T> GetAll();





        // gets an entity using delegate
        //T Get(Expression<Func<T, bool>> where);


    }
}
