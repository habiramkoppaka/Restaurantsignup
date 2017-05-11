using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarurantSignup.Models.Models
{
    public class RestarurantAccount
    {
        public int RestarurantAccountID { get; set; }
        public string RestarurantName { get; set; }
        public string Image { get; set; }                  // how to store image
        public cusine Cuisine { get; set; }

        public enum cusine
        {
            asian,
            american

        }

        

        //public int MangerID { get; set; }                 // When to keep foreign key ,When to key naviagation property

        public virtual Manger Mangers { get; set; }

        public virtual IList<Location> Location { get; set; }
    }
}
