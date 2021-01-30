using Bootcamp.Attributes_Reflection.Business;
using Bootcamp.Attributes_Reflection.CustomSql;
using Bootcamp.Attributes_Reflection.Models;
using System;
using System.Collections.Generic;

namespace Bootcamp.Attributes_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            Master master = new Master() { Id = 1, Name = "masterUser" };
            Admin admin = new Admin() { Id = 2, Name = "AdminUser" };
            Student student = new Student() { Id = 3, Name = "StudentUser" };


            List<Lesson> lessons = new List<Lesson>();

            lessons.Add(new Lesson(10, "Kimya", master));
            //lessons.Add(new Lesson(11, "Fizik", student));

            List<Customer> customers = new List<Customer>()
            {
               new Customer{ Id = 1, Name = "Burak", Age = 30, BirtDate = new DateTime(1990,12,07) },
               new Customer{ Id = 2, Name = "Alya Ece", Age = 4, BirtDate = new DateTime(2016,10,13) },
               new Customer{ Id = 3, Name = "Umur Kaan", Age = 3, BirtDate = new DateTime(2017,10,20) }
            };

            SqlGenerator sqlGenerator = new SqlGenerator();
            var insertScipts = sqlGenerator.BuildInsertScript(customers, "Customers");







            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
