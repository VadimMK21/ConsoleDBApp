using System;



namespace ConsoleDBApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                Console.WriteLine($"Database path: {db.DbPath}.");

                Console.WriteLine("Введите имя");
                string nm = Console.ReadLine();

                Console.WriteLine("--------------------------------");

                Console.WriteLine("Введите адрес");
                string adr = Console.ReadLine();

                Console.WriteLine("--------------------------------");

                db.Add(new User { name = nm, adress = adr });                
                db.SaveChanges();
                
                foreach (var user in db.Users)
                {
                    Console.WriteLine("{0} | {1}", user.name, user.adress);
                }

            }
        }
    }
}
