using System;
using HandsOnEFCodeFirst.Context;
using HandsOnEFCodeFirst.Models;
using System.Linq;
using System.Collections.Generic;

namespace HandsOnEFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StudentContext db=new StudentContext())
            {
               // insert new record
                //Student s = new Student() { Sname = "Arjun", Age = 21, Std = "II" };
                //db.Students.Add(s);
                //db.SaveChanges();

                //fectch multiple records
                //Student s = db.Students.Find(1);
                //Console.WriteLine("Welcome {0}", s.Sname);

                //fetch one record using primary key
                //Student s1 = db.Students.SingleOrDefault(i => i.Sname == "Arjun");
                //List<Student> list = db.Students.Where(i => i.Age == 10).ToList();
                //List<Student> list1 = db.Students.Where(i => i.Age == 10 && i.Std=="II").ToList();

                //UPDATE RECORD
                //Student s2 = db.Students.Find(1);
                //s2.Age = 22;//update value
                //db.Students.Update(s2);
                //db.SaveChanges();

                //delete record
                Student s3 = db.Students.SingleOrDefault(i => i.Sname == "Arjun" && i.Age == 21);
                db.Students.Remove(s3);
                db.SaveChanges();

            }
            Console.ReadKey();
        }
    }
}
