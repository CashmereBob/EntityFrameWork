using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4._3
{
    class Application
    {
        AuthorDAL db;
        bool verbose = false;

        public Application()
        {
            db = new AuthorDAL();
        }
        public void StartApplication()
        {
            while (true)
            {

                Console.WriteLine(
@"1). Lista författare.
2). Sök efter författare med sträng.
3). Sök förafattare efter id.
4). Lägg till författare.
5). Uppdatera författare.
6). Ta bort författare.
7). Uppdatera författares ålder med id.
V). Verbose true / False.
Q). Quit");
                Console.Write("Val: ");

                try
                {
                    switch (Console.ReadLine().ToLower())
                    {
                        case "1":
                            db.ListAllAuthors();
                            break;
                        case "2":
                            Console.Write("Sträng: ");
                            db.SearchAuthorByString(Console.ReadLine());
                            break;
                        case "3":
                            Console.Write("Id: ");
                            db.SearchAuthorById(Console.ReadLine());
                            break;
                        case "4":
                            Console.Write("Förnamn: ");
                            string firstname = Console.ReadLine();
                            Console.Write("Efternamn: ");
                            string lastname = Console.ReadLine();
                            Console.Write("Ålder: ");
                            string age = Console.ReadLine();
                            db.AddAuthorToDb(firstname, lastname, age);
                            break;
                        case "5":
                            Console.Write("Förnamn: ");
                            string searchFirstname = Console.ReadLine();
                            Console.Write("Efternamn: ");
                            string searchLastname = Console.ReadLine();
                            Console.Write("Nytt Förnamn: ");
                            string newFirstname = Console.ReadLine();
                            Console.Write("Nytt Efternamn: ");
                            string newLastname = Console.ReadLine();
                            Console.Write("Ny Ålder: ");
                            string newAge = Console.ReadLine();
                            db.UpdateUserWithName(searchFirstname, searchLastname, newFirstname, newLastname, newAge);
                            break;
                        case "6":
                            Console.Write("Id: ");
                            db.RemovAuthorById(Console.ReadLine());
                            break;
                        case "7":
                            Console.Write("Id: ");
                            var id = Console.ReadLine();
                            Console.Write("Ålder: ");
                            var newAgeChangeAge = Console.ReadLine();
                            db.UpdateAutherAgeById(id, newAgeChangeAge);
                            break;
                        case "v":
                            if (verbose)
                                verbose = false;
                            else
                                verbose = true;
                            Console.WriteLine($"Verbose: {verbose}");
                            break;
                        case "q":
                            return;
                        default:
                            Console.WriteLine("Inget giltigt val, försök igen.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    if (verbose)
                        Console.WriteLine(ex);
                    else
                        Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine();
                    Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }


        }

    }
}
