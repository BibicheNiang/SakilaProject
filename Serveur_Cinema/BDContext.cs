using Serveur_Cinema.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serveur_Cinema
{
    public class BDContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Payement> Payements { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Film_Actor> Film_Actors { get; set; }
        public DbSet<Film_Category> Film_Categories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public BDContext() : base("name=myProject")
        {
            Database.SetInitializer<BDContext>(new DropCreateDatabaseIfModelChanges<BDContext>());
        }
    }
}
