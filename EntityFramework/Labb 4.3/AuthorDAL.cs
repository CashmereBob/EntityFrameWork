using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4._3
{
    class AuthorDAL
    {
        internal void ListAllAuthors()
        {
            try
            {
                using (var context = new BooksBooksEntities())
                {
                    context.Authors.PrintAuthors();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Inga författare hittade, försök igen..", e);
            }
        }

        internal void SearchAuthorByString(string input)
        {
            try
            {
                using (var context = new BooksBooksEntities())
                {
                    context.Authors.Where(a => a.FirstName.ToLower().StartsWith(input.ToLower()) || a.LastName.ToLower().StartsWith(input.ToLower())).PrintAuthors();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Inga författare hittade, försök igen..", e);
            }

        }

        internal void SearchAuthorById(string id)
        {
            try
            {
                using (var context = new BooksBooksEntities())
                {
                    context.Authors.Find(int.Parse(id)).PrintAuthor();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Inga författare hittade, försök igen..", e);
            }
        }

        internal void AddAuthorToDb(string firstname, string lastname, string age)
        {
            try
            {
                var auther = new Author { FirstName = firstname, LastName = lastname, Age = int.Parse(age) };

                using (var context = new BooksBooksEntities())
                {
                    context.Authors.Add(auther);
                    context.SaveChanges();
                    auther.PrintAuthor();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Något gick fel, försök igen..", e);
            }
        }

        internal void UpdateUserWithName(string searchFirstname, string searchLastname, string newFirstname, string newLastname, string newAge)
        {
            try
            {
                using (var context = new BooksBooksEntities())
                {
                    var author = context.Authors.Where(x => x.FirstName == searchFirstname && x.LastName == searchLastname);

                    if (author.Count() > 1)
                    {
                        throw new Exception("Flera författare med samma namn hittade, försök igen..");
                    }
                    else if (author.Count() < 1)
                    {
                        throw new Exception("Ingen författare hittad, försök igen..");
                    }
                    else
                    {
                        try
                        {
                            Author autherToEdit = author.First();
                            autherToEdit.FirstName = newFirstname;
                            autherToEdit.LastName = newLastname;
                            autherToEdit.Age = int.Parse(newAge);
                            context.SaveChanges();
                            autherToEdit.PrintAuthor();
                        }
                        catch
                        {
                            throw new Exception("Något gick fel, försök igen..");

                        }
                    }


                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        internal void UpdateAutherAgeById(string id, string newAgeChangeAge)
        {
            try
            {
                using (var context = new BooksBooksEntities())
                {
                    context.Authors.Find(int.Parse(id)).Age = int.Parse(newAgeChangeAge);
                    context.SaveChanges();
                    context.Authors.Find(int.Parse(id)).PrintAuthor();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Något gick fel, försök igen..", e);
            }
        }

        internal void RemovAuthorById(string id)
        {
            try
            {
                using (var context = new BooksBooksEntities())
                {
                    context.Authors.Remove(context.Authors.Find(int.Parse(id)));
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Något gick fel, försök igen..", e);
            }
        }
    }
}
