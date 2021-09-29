using Microsoft.EntityFrameworkCore;
using System;
using Common;

namespace Data
{
    public class Database : DbContext
    {
        public DbSet<Account> Account { get; set; }
        public DbSet<Common.Recovery> Recoveries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"DataSource=data.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
            .HasOne<Common.Recovery>(s => s.recovery)
            .WithOne(ad => ad.account)
            .HasForeignKey<Common.Recovery>(ad => ad.accountId);
        }
    }
}
