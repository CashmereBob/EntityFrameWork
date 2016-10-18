using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                Student student = new Student()
                {
                    Name = "New student", StudentBirthDate = DateTime.Now.AddYears(-45)
                };
                    ctx.Students.Add(student);
                    ctx.SaveChanges();

                var stud = from x in ctx.Students where x.Name.StartsWith("New") select x;
                Console.WriteLine(stud.First().Name);
                    
                
            }

            Console.ReadKey();

        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StudentBirthDate { get; set; }

    }

    class Education
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
    }

    class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Education> utbildning { get; set; }
    }
}
