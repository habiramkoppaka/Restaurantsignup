using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using RestarurantSignup.Models.Models;



namespace RestarurantSignup.DataAccessLayer
{
    public class RestarurantContext : DbContext
    {
        public RestarurantContext() :base ("RestaturantContext")
        {

        }

        public DbSet<Manger> Mangers { get; set; }
        public DbSet<RestarurantAccount> RestarurantAccounts { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
