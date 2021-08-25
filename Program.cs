using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace ConsoleDBApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {                                              
                Console.WriteLine();
                
                db.Add(new User { name = "Сідоренко Сідор Сідорович" });
                db.SaveChanges();
                               
                Console.WriteLine($"Database path: {db.DbPath}.");
            }
        }
    }
}
