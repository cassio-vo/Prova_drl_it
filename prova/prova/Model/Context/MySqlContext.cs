using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext()
        {
        }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
        }

        public DbSet<Arvore> Arvore { get; set; }

        public DbSet<Colheita> Colheita { get; set; }

        public DbSet<Especie> Especie { get; set; }

        public DbSet<GrupoArvore> GrupoArvore { get; set; }
    }
}
