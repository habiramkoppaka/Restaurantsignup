using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestarurantSignup.DataAccessLayer.Repositories.Interface;
using RestarurantSignup.Models.Models;

namespace RestarurantSignup.DataAccessLayer.Repositories.Class
{
    public class RestaurantRepository : GenericRepository<RestarurantAccount>, IRestaurantRepository
    {
        private readonly RestarurantContext context;
        public RestaurantRepository(RestarurantContext context) : base(context)
        {

            this.context = context;
        }

        public void GetNameByCuisine(string name)
        {
           // context.Set<RestarurantAccount>().FirstOrDefault(x => x.Cuisine. == name);

        }
    }

}