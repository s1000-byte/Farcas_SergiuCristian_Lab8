using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crisan_AndreaMaria_Lab8.Models;

namespace Crisan_AndreaMaria_Lab8.Data
{
    public class Crisan_AndreaMaria_Lab8Context : DbContext
    {
        public Crisan_AndreaMaria_Lab8Context (DbContextOptions<Crisan_AndreaMaria_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Crisan_AndreaMaria_Lab8.Models.Book> Book { get; set; }

        public DbSet<Crisan_AndreaMaria_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Crisan_AndreaMaria_Lab8.Models.Category> Category { get; set; }
    }
}
