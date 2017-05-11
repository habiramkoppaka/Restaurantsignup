using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestarurantSignup.Models.Models;

namespace RestarurantSignup.DataAccessLayer.Repositories.Interface
{
    public interface IItemRepository : IRepository<Item>                  // specfic interface where we can  add methods only related To Items
    {
        IEnumerable<Item> GetItemsByMenu(string Name);

    }
}
