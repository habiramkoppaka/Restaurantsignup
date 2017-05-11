using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestarurantSignup.Models.Models;
using RestarurantSignup.DataAccessLayer.Repositories.Interface;

namespace RestarurantSignup.Service.Services
{

    public interface IRestarurantAccountService
    {
        IEnumerable<RestarurantAccount> GetAll(string name = null);
        RestarurantAccount GetRestarurantAccountbyId(int id);
        RestarurantAccount GetRestarurantAccountName(string name);
        void CreateRestarurantAccount(RestarurantAccount resacc);
        void DeleteRestarurantAccount(RestarurantAccount resacc);
    }
    public class RestarurantAccountService : IRestarurantAccountService
    {
        private readonly IRestaurantRepository restarurantaccount;

        public RestarurantAccountService(IRestaurantRepository restarurantaccount)
        {
            this.restarurantaccount = restarurantaccount;
        }





        public void CreateRestarurantAccount(RestarurantAccount resacc)
        {
            restarurantaccount.Add(resacc);


        }

        public void DeleteRestarurantAccount(RestarurantAccount resacc)
        {
            restarurantaccount.Delete(resacc);
        }

        public IEnumerable<RestarurantAccount> GetAll(string name = null)
        {
            return
                 string.IsNullOrEmpty(name)
                 ? restarurantaccount.GetAll()
                 : restarurantaccount.GetAll().Where(c => c.RestarurantName == name);
        }

        public RestarurantAccount GetRestarurantAccountbyId(int id)
        {
            return restarurantaccount.GetById(id);
        }

        public RestarurantAccount GetRestarurantAccountName(string name)
        {
            return restarurantaccount.GetByName(name);
        }
    }
}
