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

        public DbSet<Arvore> Arvores { get; set; }

        public DbSet<Colheita> Colheitas { get; set; }

        public DbSet<Especie> Especies { get; set; }

        public DbSet<GrupoArvore> GruposArvore { get; set; }
    }
}
