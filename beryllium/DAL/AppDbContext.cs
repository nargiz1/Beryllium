using Beryllium.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        { }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Offer> Offers { get; set; }

    }
}
