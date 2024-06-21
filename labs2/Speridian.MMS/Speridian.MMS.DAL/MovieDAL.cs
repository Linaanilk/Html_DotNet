using Speridian.MMS.Entities;
using Speridian.MMS.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speridian.MMS.DAL
{
    public class MovieDAL
    {
        
             static List<Movie> list = new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Name = "RDX",
                    Director = "Basil Joseph",
                    ReleaseYear = 2023,
                    Rating = 8,
                    Genre = Genre.Horror,
                    Duration = TimeSpan.FromMinutes(300),
                    Language =Language.Malayalam,
                    Actors = new List<string?>
                    {
                        "krithi","varun"
                    }
                },
                new Movie
                {
                    Id = 2,
                    Name = "The Meg",
                    Director = "Jason Sthatham",
                    ReleaseYear = 2023,
                    Rating = 6,
                    Genre = Genre.thriller,
                    Duration = TimeSpan.FromMinutes(370),
                    Language =Language.English,
                    Actors = new List<string?>
                    {
                        "Li Bingbing","Ruby Rose"
                    }
                }
            };

            static int counter = 2;
            public static List<Movie> GetMovies()
            {
                return list;
            }
        public static bool Add(Movie movie)
        {
            bool isExists = list.Exists(m => m.Name == movie.Name);
            if (isExists)
            {
                throw new EMSException("Movie already exists");
                return false;
            }
            else
            {
                movie.Id = ++counter;
                list.Add(movie);
                return true;
            }

        }
        public static Movie GetByid(int id)
        {
            var emp = list.Find(d => d.Id == id);
            return emp;

        }
        public static bool Update(int id, Movie movie)
        {
            var id1 = list.First(e => e.Id == id);
            id1.Name = movie.Name;
            id1.ReleaseYear =movie.ReleaseYear;
            id1.Genre =movie.Genre;
            id1.Language =movie.Language;
            id1.Director = movie.Director;
            id1.Duration = movie.Duration;
            id1.Rating = movie.Rating;
            id1.Actors = movie.Actors;
            return true;
        }
        public static void Delete(int id)
        {

            list.RemoveAll(m => m.Id == id);
            Console.WriteLine("Deleted successfully");
        }
        public static Movie GetByTitle(string Title)
        {
            Movie mov = list.Find(d => d.Name == Title);
            return mov;

        }


    }
}


