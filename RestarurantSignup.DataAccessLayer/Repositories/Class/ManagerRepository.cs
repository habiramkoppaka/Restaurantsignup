using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestarurantSignup.DataAccessLayer.Repositories.Interface;
using RestarurantSignup.Models.Models;

namespace RestarurantSignup.DataAccessLayer.Repositories.Class
{
    public class ManagerRepository:GenericRepository<Manger>,IManagerRespository     // Implement methods which are declared in Imanager Repositiory
    {
        private readonly RestarurantContext context;

        public ManagerRepository(RestarurantContext context):base(context)
        {
            this.context = context;

        }


    }
}
