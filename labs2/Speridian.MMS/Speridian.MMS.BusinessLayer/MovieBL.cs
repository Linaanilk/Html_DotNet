using Speridian.MMS.DAL;
using Speridian.MMS.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speridian.MMS.BusinessLayer
{
    public class MovieBL
    {
        public static List<Movie> GetMovies()
        {
            var list = MovieDAL.GetMovies();
            return list;
        }
        public static bool Add(Movie movie)
        {
            var isAdded = MovieDAL.Add(movie);
            return isAdded;
        }
        public static Movie GetByid(int id)
        {
            var movie = MovieDAL.GetByid(id);
            return movie;
        }
        public static bool Update(int id, Movie movie)
        {
            var isUpdated = MovieDAL.Update(id, movie);
            return isUpdated;
        }
        public static void Delete(int id)
        {
            MovieDAL.Delete(id);
        }

        public static Movie GetByTitle(string title)
        {
            return MovieDAL.GetByTitle(title);
          

            // return list.FirstOrDefault(movie => movie.Name.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }
}
