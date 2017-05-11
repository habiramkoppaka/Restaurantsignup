using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestarurantSignup.Models.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Descrption { get; set; }
        public string ItemImage { get; set; }
        public string Quantity { get; set; }
        public string deliveryOption { get; set; }
        public int OfferedDay { get; set; }                         // can  be datatype be enum with  and days
        public string ServeTimeIn { get; set; }
        public string ServetimeOut { get; set; }
        public string TimeToPrepare { get; set; }
        public decimal Price { get; set; }



                                  // foriegn Key



        public IList<Menu> Menus { get; set; }
    }
}
