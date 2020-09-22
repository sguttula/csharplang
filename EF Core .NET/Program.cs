using System;
using Microsoft.SqlServer;
using System.Linq;
using RandomNameGeneratorLibrary;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Serialization;
using System.IO;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            var id = person.Id;
            var name = person.Name;
            int age = person.Age;
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                var rand = new Random();
                var intRand = new Random();
                id += 1;
                name = rand.GenerateRandomFirstAndLastName();
                age = intRand.Next(20, 60);
                if(age >= 30 && age <= 40)
                {
                    count++;
                    Console.WriteLine("ID: {0}, Name: {1}, Age: {2}", id, name, age);
                }                
            }
            Console.WriteLine();
            Console.WriteLine("Persons selected: {0}/100", count);

            using (var db = new AppDbContext())
            {
                db.Persons.Add(person);
                var selection = db.Persons.Find(2);
                Console.WriteLine();
                Console.WriteLine(selection);

                var querySelection = from p in db.Persons
                                     where (p.Age >= 30) && (p.Age <= 40)
                                     select p;
                db.SaveChanges();
                var tom = querySelection.FirstOrDefault();
                Console.WriteLine(tom);
            }
            
        }

        




    }
}
