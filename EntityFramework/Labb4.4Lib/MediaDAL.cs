using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4._4Lib
{
    public class MediaDAL
    {
        public Book GetBook(int id)
        {
            try { 
            using (var context = new MediaEntities())
            {
                return context.Books.Find(id);
            }
            }
            catch (Exception e)
            {
                throw new Exception("Couldnt find media", e);
            }
        }

        public Paper GetPaper(int id)
        {
            try
            {
                using (var context = new MediaEntities())
                {
                    return context.Papers.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Couldnt find media", e);
            }
        }

        public Movy GetMovie(int id)
        {
            try
            {
                using (var context = new MediaEntities())
                {
                    return context.Movies.Find(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Couldnt find media", e);
            }
        }

        public List<Book> GetAllBooks()
        {
            try
            {
                using (var context = new MediaEntities())
                {
                    return context.Books.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Couldnt get to database", e);
            }
        }

        public List<Paper> GetAllPapers()
        {
            try
            {
                using (var context = new MediaEntities())
                {
                    return context.Papers.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Couldnt get to database", e);
            }
        }

        public List<Movy> GetAllMovies()
        {

            try
            {
                using (var context = new MediaEntities())
                {
                return context.Movies.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Couldnt get to database", e);
            }

        }

        public void DeleteBook(int id)
        {
            try
            {
                using (var context = new MediaEntities())
                {
                    context.Books.Remove(context.Books.Find(id));
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Couldnt find media", e);
            }
        }
        public void DeletePaper(int id)
        {
            try
            {
                using (var context = new MediaEntities())
                {
                    context.Papers.Remove(context.Papers.Find(id));
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Couldnt find media", e);
            }
        }
        public void DeleteMovie(int id)
        {
            try
            {
                using (var context = new MediaEntities())
                {
                    context.Movies.Remove(context.Movies.Find(id));
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Couldnt find media", e);
            }
        }

        public void AddBook(Book book)
        {
            try
            {
                using (var context = new MediaEntities())
                {
                    context.Books.Add(book);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Couldnt add to db", e);
            }
        }
        public void AddPaper(Paper paper)
        {
            try
            {
                using (var context = new MediaEntities())
                {
                    context.Papers.Add(paper);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Couldnt add to db", e);
            }
        }
        public void AddMovie(Movy movie)
        {
            try
            {
                using (var context = new MediaEntities())
                {
                    context.Movies.Add(movie);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Couldnt add to db", e);
            }
        }

        public void EditMovie(int id, string name)
        {
            try
            {
                using (var context = new MediaEntities())
                {
                    context.Movies.Find(id).Name = name;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Couldnt add to db", e);
            }
        }

        public void EditBook(int id, string name)
        {
            try
            {
                using (var context = new MediaEntities())
                {
                    context.Books.Find(id).Name = name;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Couldnt add to db", e);
            }
        }

        public void EditPaper(int id, string name)
        {
            try
            {
                using (var context = new MediaEntities())
                {
                    context.Papers.Find(id).Name = name;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Couldnt add to db", e);
            }
        }

    }
}
