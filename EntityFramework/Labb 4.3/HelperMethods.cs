using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4._3
{
    static class HelperMethods
    {
        public static void PrintAuthors(this IEnumerable<Author> auts) {

            auts.ToList().ForEach(aut => aut.PrintAuthor());
        }
        public static void PrintAuthor(this Author aut)
        {
            Console.WriteLine($"ID: {aut.AuthorID} Name: {aut.FirstName} {aut.LastName} Age: {aut.Age}");
        }
    }
}
