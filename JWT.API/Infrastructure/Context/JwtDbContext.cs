using JWT.API.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace JWT.API.Infrastructure.Context
{
    public class JwtDbContext : DbContext
    {
        public JwtDbContext(DbContextOptions<JwtDbContext> options):base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}
