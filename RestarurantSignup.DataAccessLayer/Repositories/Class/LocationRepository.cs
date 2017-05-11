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
    public class LocationRepository:GenericRepository<Location>,ILocationRepository
    {
        private readonly RestarurantContext context;

        public LocationRepository(RestarurantContext context):base(context)
        {
            this.context = context;
        }

    }
}
