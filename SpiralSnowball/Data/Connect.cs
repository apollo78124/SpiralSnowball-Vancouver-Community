using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpiralSnowball.Models;

namespace SpiralSnowball.Data
{
    public class Connect : DbContext 
    {
        public Connect(DbContextOptions<Connect> options)
            : base(options)
        {
        }

        public DbSet<PopularPost> PopularPosts { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
