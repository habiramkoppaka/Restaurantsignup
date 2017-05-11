using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestarurantSignup.Models.Models;
using RestarurantSignup.DataAccessLayer.Repositories.Interface;

namespace RestarurantSignup.DataAccessLayer.Repositories
{
    public class ItemRepository : GenericRepository<Item>, IItemRepository
    {
        private readonly RestarurantContext context;
        public ItemRepository(RestarurantContext context) : base(context)
        {

            this.context = context;

        }


        public IEnumerable<Item> GetItemsByMenu(string Name)
        {

            throw new NotImplementedException(); // need to use include beacuse items are retrived usng menu
        }
    }
}
