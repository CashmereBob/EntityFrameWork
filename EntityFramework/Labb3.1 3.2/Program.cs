using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3._1_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number");
            var input = Console.ReadLine();

            float result = Helper.ConvertToFloat(input) * 12;

            Console.WriteLine(result);

            result = input.ConvertToFloat() * 12;

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }

    static class Helper
    {
        public static float ConvertToFloat(string str)
        {
            float result = 0;
            float.TryParse(str, out result);
            return result;
        }
    }

    static class StringExtentions
    {
        public static float ConvertToFloat(this string str) {
            float result = 0;
            float.TryParse(str, out result);
            return result;
        }
    }
}
