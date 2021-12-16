using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WebAppDisney.Models;

namespace WebAppDisney.Data
{
    public class DisneyDbContext:DbContext
    {
        public DisneyDbContext(DbContextOptions<DisneyDbContext> options) : base(options) { }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<PeliculaSerie> PeliculasSeries { get; set; }
        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
