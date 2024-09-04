using LibrosCrudClnArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibrosCrudClnArch.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Libro> Libro { get; set; }
    }
}
