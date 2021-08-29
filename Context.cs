using Microsoft.EntityFrameworkCore;
using System;

namespace ConsoleDBApp
{
    public class Context : DbContext
    {        
        public string DbPath { get; private set; }
        public Context()
        {            
            DbPath = "UsersDB.sqlite";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<User> Users { get; set; }        
    }
}
