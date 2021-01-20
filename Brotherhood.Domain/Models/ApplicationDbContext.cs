using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brotherhood.Domain.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Comic> Comics { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Page> Pages { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(useLazyLoadingProxies: true);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comic>()
                        .HasMany(c => c.Chapters)
                        .WithOne(c => c.Comic)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Comic>()
                        .HasMany(g => g.Genders);

            modelBuilder.Entity<Chapter>()
                        .HasMany(p => p.Pages)
                        .WithOne(p => p.Chapter)
                        .OnDelete(DeleteBehavior.NoAction);
            base.OnModelCreating(modelBuilder);
        }
    }
}
