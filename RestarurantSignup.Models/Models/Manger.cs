using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestarurantSignup.Models.Models
{
   public class Manger
    {
        public int MangerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string MetroArea { get; set; }
        public string  PrimaryPhone { get; set; }         // check which one is better datatype.phone attribute or dirctly
        public int FaxNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<RestarurantAccount> RestarurantAccount { get; set; }
    }
}
