using Microsoft.EntityFrameworkCore;
using mvc1.Models;

namespace mvc1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Produto> Produtos { get; set; }
    }
}