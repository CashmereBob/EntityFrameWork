using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var cnx = new ScoolContext())
            {
                Student student = new Student() { Name = "Hej" };
                cnx.students.Add(student);
                cnx.SaveChanges();

                var studenten = from x in cnx.students where x.Name.StartsWith("H") select x;

                Console.WriteLine(studenten.First().Name);


            }

            Console.ReadKey();
        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Edu
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }

    class ScoolContext : DbContext
    {
        public DbSet<Student> students {get; set;}
        public DbSet<Edu> edu { get; set; }
    }
}
