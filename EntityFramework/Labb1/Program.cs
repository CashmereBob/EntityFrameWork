using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new WebShopGr7Entities())
            {
                var kund = from x in context.tbl_User where x.Lastname.Equals("Weidmar") select x;



                Console.WriteLine(kund.First().Adress);
            }

            Console.ReadKey();
        }
    }
}
