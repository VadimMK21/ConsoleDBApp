using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;

namespace ConsoleDBApp
{
    public class Context : DbContext
    {        
        public string DbPath { get; private set; }
        public Context()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}UsersDB.sqlite";
            //DbPath = "UsersDB.sqlite";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<User> Users { get; set; }

        /*
        string dbConstring = "Data Source=UsersDB.sqlite";
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=UsersDB.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
        */
    }
}
