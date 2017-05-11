using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestarurantSignup.Models.Models
{
    public class Location
    {
        public int LocationID { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public string County { get; set; }
        public string LocationName { get; set; }
        public string LocationPhone { get; set; }         // check which one is better datatype.phone attribute or dirctly
        public int LocationFaxNumber { get; set; }

        public int RestarurantID { get; set; }                      // foriegn Key



        public virtual IList<Menu> Menu { get; set; }

    }
}
