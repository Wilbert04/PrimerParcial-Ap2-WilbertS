using Microsoft.EntityFrameworkCore;
using PrimerParcial_Ap2_WIlbertSmith.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial_Ap2_WIlbertSmith.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=DATA\ProductoDB.db");
        }
    }
}
