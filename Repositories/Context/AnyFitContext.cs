
using Microsoft.EntityFrameworkCore;
using AnyFit.Models;

namespace AnyFit.Repositories.Context
{
    public class AnyFitContext : DbContext
    {
        public DbSet<User> Usuer { get; set; }
        public DbSet<Academy> Academy { get; set; }

        public AnyFitContext(DbContextOptions<AnyFitContext> options) :
            base(options)
        {

        }
    }
}