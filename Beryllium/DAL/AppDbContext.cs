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
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Feature> Features { get; set; }





    }
}
