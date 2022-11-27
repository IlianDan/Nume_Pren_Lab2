using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nume_Pren_Lab2.Models;

namespace Nume_Pren_Lab2.Data
{
    public class Nume_Pren_Lab2Context : DbContext
    {
        public Nume_Pren_Lab2Context (DbContextOptions<Nume_Pren_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Nume_Pren_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Nume_Pren_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
