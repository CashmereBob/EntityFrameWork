using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4._4Lib
{
    public static class HelperClasses
    {
        public static void Edit(this Book book, string name)
        {
            try
            {
                using (var context = new MediaEntities())
                {
                    book.Name = name;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Could not save media", e);
            }
        }
        public static void Edit(this Paper paper, string name)
        {
            try
            {
                using (var context = new MediaEntities())
                {
                    paper.Name = name;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Could not save media", e);
            }
        }
        public static void Edit(this Movy movie, string name)
        {
            try
            {
                using (var context = new MediaEntities())
                {
                    movie.Name = name;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Could not save media", e);
            }
        }
    }
}
