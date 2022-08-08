using Core.Entities;
using Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class MVCDbContext : IdentityDbContext<ApplicationUser>
    {
        public const string MvcConnectionString =
            "Data Source=.;Initial Catalog=MVC;Integrated Security=True";
        public MVCDbContext(DbContextOptions<MVCDbContext> options) : base(options) {}

        public DbSet<Cast> Cast { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Crew> Crew { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<MovieCast> MovieCast { get; set; }
        public DbSet<MovieCrew> MovieCrew { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Shipper> Shipper { get; set; }
        public DbSet<Trailer> Trailer { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        
    }
}
