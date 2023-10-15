
using Microsoft.EntityFrameworkCore;
using WebUi.Models;

namespace WebUi.Data;
    public class CreativeDbContext : DbContext
    {
        public DbSet<Banner> Banners {get; set;}
        public DbSet<About> Abouts {get; set;}
        public DbSet<Service> Services {get; set;}
        public DbSet<Category> Categories {get; set;}
        public DbSet<Portfolio> Portfolios {get; set;}

    }
