using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarurantSignup.Models.Models
{
    public class Menu
    {
        public int MenuID { get; set; }
        public Menulist MenuName { get; set; }


        public int LocationID { get; set; }             // forign Key
                      // forign Key


        public virtual Location Locations { get; set; }



        public virtual IList<Item> Item { get; set; }
    }

    public enum Menulist
    {
        BreakFast,
        Lunch,
        Dinner,
        AllDay

    }
}
