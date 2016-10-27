using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3._3
{
    class Program
    {
        static void Main(string[] args)
        {

            var strings = new List<string>();

            strings.Add("Magnus");
            strings.Add("Li");
            strings.Add("Urban");
            strings.Add("Lena");
            strings.Add("Maria");
            strings.Add("Anders");
            strings.Add("Pia");
            strings.Add("Kerstin");
            strings.Add("Andre");

            Console.WriteLine("Tryck enter för att visa alla eller a för att visa alla namn som börjar på A");

            var input = Console.ReadLine();

            IEnumerable<string> result;

            if (input.ToLower() == "a")
            {
                result = strings.Where(p => p.ToLower().StartsWith("a"));
            }
            else
            {
                result = strings.Where(p => p.ToLower().StartsWith("a") && !p.ToLower().Contains("s"));
            }

            foreach (string match in result)
            {
                Console.WriteLine(match);
            }





            Console.ReadKey();

        }
    }
}
