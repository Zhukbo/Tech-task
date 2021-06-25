using Microsoft.EntityFrameworkCore;
using System;
using Task7.Core.Entities;

namespace Task7.DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Link> Links { get; set; }
        public DbSet<Transition> Transitions { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
        {
            Database.EnsureCreated(); 
        }

    }
}
