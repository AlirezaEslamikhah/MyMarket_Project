using Microsoft.EntityFrameworkCore;
using P8.Server.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P9.Shared;


namespace P9.Server.DB
{
    public class ClotheDbContext : DbContext
    {
        public ClotheDbContext(DbContextOptions<ClotheDbContext> options)
            : base(options)
        {}
        public DbSet<Clothe> Clothes {get; set;}
        // public DbSet<User> users {get;set;}
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}