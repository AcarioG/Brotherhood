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

        public DbSet<Comics> Comics { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<PagesComics> PagesComics { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(useLazyLoadingProxies: true);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comics>()
                        .HasMany(c => c.Chapters)
                        .WithOne(c => c.Comic);

            modelBuilder.Entity<Chapter>()
                        .HasMany(p => p.Pages)
                        .WithOne(p => p.Chapter);
            base.OnModelCreating(modelBuilder);
        }
    }
}
