using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;

namespace ConsoleDBApp
{
    class Context : DbContext
    {
        protected Context() : base("DbConnectionString")
        {

        }
    }
}
