using EFProject.Context;
using EFProject.Models;
using System;
using EFProject;

namespace EF_Client1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {
                Item p = new Item()
                {
                    Item_name = "BFS",
                    Item_price=1000
                };
                Order o = new Order()
                {
                    OrderDate = Convert.ToDateTime("2.12.2020"),
                    DeliveryDate = Convert.ToDateTime("1.04.2020"),
                    Item_Id=4
                   


                };
                db.Add(p);
                db.Add(o);
                db.SaveChanges();
                    
            }
        }
    }
}
