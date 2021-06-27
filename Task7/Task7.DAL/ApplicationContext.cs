using Microsoft.EntityFrameworkCore;
using System;
using Task7.Core.Entities;

namespace Task7.DAL
{
    //клас для взаэмодії з БД
    public class ApplicationContext : DbContext //:IDisposable
    {
        //таблиця - Links
        public DbSet<Link> Links { get; set; }
        //таблиця - Transition
        public DbSet<Transition> Transitions { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
        {
            //Створює базу даних якщо її немає
            Database.EnsureCreated(); 
        }

    }
}
