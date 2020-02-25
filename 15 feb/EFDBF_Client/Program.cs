using EFDBF.Models;
using System;

namespace EFDBF_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (practiceDBContext db = new practiceDBContext())
            {
                Product p = new Product() { Id = 1, Name = "agvdd", Price = 1200, Stock = 1, Gst = 12 };
                db.Add(p);
                db.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}
