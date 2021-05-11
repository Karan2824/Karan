using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Karan.Models;

namespace Karan.Data
{
    public class KaranContext : DbContext
    {
        public KaranContext (DbContextOptions<KaranContext> options)
            : base(options)
        {
        }

        public DbSet<Karan.Models.Author> Author { get; set; }

        public DbSet<Karan.Models.Book> Book { get; set; }

        public DbSet<Karan.Models.Customer> Customer { get; set; }
    }
}
