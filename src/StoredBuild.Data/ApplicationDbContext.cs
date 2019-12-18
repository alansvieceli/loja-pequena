using Microsoft.EntityFrameworkCore;
using StoredBuild.Domain.Models;

namespace StoredBuild.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories {get; set; }

    }
}