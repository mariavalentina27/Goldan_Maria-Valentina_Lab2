using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Goldan_Maria_Valentina_lab2.Models;

namespace Goldan_Maria_Valentina_lab2.Data
{
    public class Goldan_Maria_Valentina_lab2Context : DbContext
    {
        public Goldan_Maria_Valentina_lab2Context (DbContextOptions<Goldan_Maria_Valentina_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Goldan_Maria_Valentina_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Goldan_Maria_Valentina_lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Goldan_Maria_Valentina_lab2.Models.Author> Author { get; set; }

        public DbSet<Goldan_Maria_Valentina_lab2.Models.Category> Category { get; set; }

        public DbSet<Goldan_Maria_Valentina_lab2.Models.BookCategory> BookCategory { get; set; }
    }
}
