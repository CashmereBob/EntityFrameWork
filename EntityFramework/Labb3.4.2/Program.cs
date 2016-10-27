using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Application();
            app.Menu();




        }

    }
    class Employee
    {
        public int id { get; set; }
        public string fName { get; set; }
        public string eName { get; set; }
        public DateTime hireDate { get; set; }
        public string department { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return $"id: {this.id} Name: {this.fName} {this.eName} Hire date: {this.hireDate} Department: {this.department} Age: {this.age}";
        }


    }

    class Application
    {
        public List<Employee> _employees;


        public Application()
        {
            _employees = new List<Employee>() {
                new Employee {id = 1, fName = "Roy", eName = "Nilsson", hireDate = DateTime.UtcNow, age = 20, department = "Lager"  },
                new Employee {id = 2, fName = "Magnus", eName = "Svensson", hireDate = DateTime.UtcNow, age = 22, department = "Lager"  },
                new Employee {id = 3, fName = "Lena", eName = "Persson", hireDate = DateTime.UtcNow, age = 24, department = "Lager"  },
                new Employee {id = 4, fName = "Urban", eName = "Andersson", hireDate = DateTime.UtcNow, age = 25, department = "Ekonomi"  },
                new Employee {id = 5, fName = "Maria", eName = "Pettersson", hireDate = DateTime.UtcNow, age = 21, department = "Ekonomi"  },
                new Employee {id = 6, fName = "Li", eName = "Weidmar", hireDate = DateTime.UtcNow, age = 40, department = "Logistik"  },
                new Employee {id = 7, fName = "Anders", eName = "Falk", hireDate = DateTime.UtcNow, age = 63, department = "Logistik"  },
                new Employee {id = 8, fName = "Pia", eName = "Dahlqvist", hireDate = DateTime.UtcNow, age = 34, department = "Logistik"  }

            };

        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine(@"Alternativ:
1) sortera efter Efternamn
2) sortera efter förnamn
3) Lista alla anställda från avdelning
4) Sök med fritext
q) För att avsluta");

                switch (Console.ReadLine())
                {
                    case "1":
                        _employees.EmployeeByName();
                        break;
                    case "2":
                        _employees.EmployeeByLastname();
                        break;
                    case "3":
                        Console.Write(@"Avdelning: ");
                         _employees.EmployeesBySection(Console.ReadLine().ToLower());
                        break;
                    case "4":
                        Console.Write(@"frisök: ");
                        _employees.EmployeeSearch(Console.ReadLine().ToLower());
                        break;
                    case "q":
                        return;
                    default:
                        Console.WriteLine("Try again");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }


    }

    static class ListHelper
    {
        public static void EmployeeSearch(this List<Employee> list, string inputNamn)
        {
            list.Where(x => x.fName.ToLower().Contains(inputNamn) || x.eName.ToLower().Contains(inputNamn)).PrintList();
        }

        public static void EmployeesBySection(this List<Employee> list, string inputAvd)
        {
            list.Where(x => x.department.ToLower() == inputAvd).PrintList();
        }

        public static void EmployeeByLastname(this List<Employee> list)
        {
            list.OrderBy(x => x.fName).PrintList();
        }

        public static void EmployeeByName(this List<Employee> list)
        {
            list.OrderBy(x => x.eName).PrintList();
        }

        public static void PrintList(this IEnumerable<Employee> list)
        {
            list.ToList().ForEach(e => Console.WriteLine(e.ToString()));
        }

    }
}



