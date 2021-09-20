using System;
using System.IO;
using System.Collections;
using System.Linq;


namespace ConsoleDBApp
{
    class Program
    {
        static void Main(string[] args)
        {

            
            using (var db = new Context())
            {
                string path = Directory.GetCurrentDirectory();

                Console.WriteLine($"Database path: {path}\\{db.DbPath}.");

                Console.WriteLine("Введите имя");
                string nm = Console.ReadLine();

                Console.WriteLine("--------------------------------");

                Console.WriteLine("Введите адрес");
                string adr = Console.ReadLine();

                Console.WriteLine("--------------------------------");

                db.Add(new User { name = nm, adress = adr });                
                db.SaveChanges();

                Console.OutputEncoding = System.Text.Encoding.Unicode;

                foreach (var user in db.Users)
                {
                    Console.WriteLine("{0} | {1}", user.name, user.adress);
                }
                // Поиск по части имени
                Console.WriteLine("Введите имя");
                string findnm = Console.ReadLine();

                var result = from ed in db.Users
                             where ed.name.Contains(findnm.ToUpper())
                             select new
                             {
                                 Name = ed.name,
                                 Adress = ed.adress,
                                 Phone = ed.phone
                             };
                foreach (var us in result)
                {
                        Console.WriteLine("{0} | {1} -- {2}", us.Name, us.Adress, us.Phone);
                }
                
                Console.ReadKey();
            }
        }
    }
}
