using Microsoft.EntityFrameworkCore;
using PrestamosBD.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosBD.Data
{
    public class BDContext : DbContext
    {
        public BDContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Usuario> TablaUsuario { get; set; }
    }
}
