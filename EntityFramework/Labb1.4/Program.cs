using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1._4
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new Media())
            {

                var movie = new Movie() { Name = "Movie1" };
                var book = new Book() { Name = "Book1" };
                var paper = new Paper() { Name = "Paper1" };

                context.Movies.Add(movie);
                context.Books.Add(book);
                context.Papers.Add(paper);

                context.SaveChanges();

                Console.WriteLine(context.Movies.First().Name);
                Console.WriteLine(context.Books.First().Name);
                Console.WriteLine(context.Papers.First().Name);
                Console.WriteLine();

                var selectedPaper = from x in context.Papers where x.Name.Equals("Paper1") select x;

                Paper updated = selectedPaper.First();

                updated.Name = "Paper2";

                context.Books.Remove(book);

                context.SaveChanges();

                Console.WriteLine(context.Movies.First().Name);
                Console.WriteLine(context.Books.Count());
                Console.WriteLine(context.Papers.First().Name);
                Console.WriteLine();

            }
            Console.ReadKey();

        }
    }

    class Media : DbContext
    {
        public DbSet<Movie> Movies{ get; set; }
    public DbSet<Paper> Papers { get; set; }
        public DbSet<Book> Books { get; set; }
    }

    class Paper
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

}
