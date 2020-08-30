using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyMDB.Models
{
    public class MyMDBContext : DbContext
    {
        public MyMDBContext (DbContextOptions<MyMDBContext> options)
            : base(options)
        {
        }

        public DbSet<MyMDB.Models.Movie> Movie { get; set; }
        public DbSet<MyMDB.Models.Star> Star { get; set; }


    }
}
