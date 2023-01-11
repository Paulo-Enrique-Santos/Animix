using Animix.Domain.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace Animix.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<Animation> Animation { get; set; }
        public DbSet<Character> Character { get; set; }
        public DbSet<CharacterTransaction> CharacterTransaction { get; set; }
        public DbSet<Marketplace> Marketplace { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserTransaction> UserTransaction { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
