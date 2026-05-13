using ExoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ExoApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext(DbContextOptions<ExoContext> options)
            : base(options)
        {
        }

        public DbSet<Projeto> Projetos { get; set; }

        public DbSet<Projeto> Usuarios { get; set; }

    }
}