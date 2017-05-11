using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestarurantSignup.Models.Models;
using RestarurantSignup.DataAccessLayer.Repositories.Interface;
using RestarurantSignup.DataAccessLayer.Repositories;

namespace RestarurantSignup.DataAccessLayer.Repositories.Class
{
    public class MenuRepository : GenericRepository<Menu>, IMenuRepository
    {
        // Menu Repository class that implements specfic to IMenuRespository

        private readonly RestarurantContext context;
        public MenuRepository(RestarurantContext context) : base(context)
        {
            this.context = context;
        }
    }
}
