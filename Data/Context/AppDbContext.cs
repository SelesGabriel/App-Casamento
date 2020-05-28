using Casamento.Data.Map;
using Casamento.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casamento.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):  base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PessoaMap());
        }
    }
}
