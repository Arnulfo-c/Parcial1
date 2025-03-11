using Microsoft.EntityFrameworkCore;
using Parcial1.Models;

namespace Parcial1.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Carreras> Carreras { get; set; }
    }
}