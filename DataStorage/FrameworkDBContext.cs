using DataStorage.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStorage
{
    public class FrameworkDBContext : DbContext
    {
        public FrameworkDBContext(DbContextOptions<FrameworkDBContext> options) : base(options)
        {
        }
        public DbSet<Apartments> Apartments { get; set; }
        public DbSet<ApartmentsBooked> ApartmentsBooked { get; set; }
        public DbSet<User> Users { get; set; }
    }

    /// <summary>
    /// Для Миграций
    /// </summary>
    public class FrameworkDBContextFactory : IDesignTimeDbContextFactory<FrameworkDBContext>
    {
        public FrameworkDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FrameworkDBContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ServiceApartmentsDB;Trusted_Connection=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("DataStorage"));

            return new FrameworkDBContext(optionsBuilder.Options);
        }
    }
}
