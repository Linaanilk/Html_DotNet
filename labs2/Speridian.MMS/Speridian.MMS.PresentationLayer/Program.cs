using Speridian.MMS.BusinessLayer;
using Speridian.MMS.Entities;
using Speridian.MMS.Exceptions;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Xml;

namespace Speridian.MMS.PresentationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while(true) 
            {
                try
                {
                    Console.WriteLine("===========================");
                    Console.WriteLine("MOVIE MANAGEMENT SYSTEM");
                    Console.WriteLine("===========================");
                    Console.WriteLine("===========================");

                    Console.WriteLine("1. LIST MOVIES");
                    Console.WriteLine("2. LIST ACTORS");
                    Console.WriteLine("3. ADD MOVIES");
                    Console.WriteLine("4. UPDATE MOVIES");
                    Console.WriteLine("5. ADD ACTORS");
                    Console.WriteLine("6. UPDATE ACTORS");
                    Console.WriteLine("7. DELETE MOVIE");
                    Console.WriteLine("8. SEARCH MOVIE");
                    Console.WriteLine("9. SEARCH ACTOR");
                    Console.WriteLine("10. EXIT");
                    Console.WriteLine("ENTER YOUR CHOICE");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out int choice))
                    {
                        Console.WriteLine("Invalid Input");
                        return;
                    }
                    switch (choice)
                    {
                        case 1:
                            ListMovies();
                            break;
                        case 2:
                            ListActors();
                            break;
                        case 3:
                            AddMovie();
                            break;
                        case 4:
                            UpdateMovie();
                            break;
                        case 5:
                             AddActor();
                            break;
                        case 6:
                            UpdateActor();
                            break;
                        case 7:
                            DeleteMovie();
                            break;
                        case 8:
                            SearchMovie();
                            break;
                        case 9:
                            SearchActor();
                            break;
                        case 10:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break;
                    }


                }
                catch (EMSException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static void ListActors()
        {
            var list = ActorBL.GetActors();
            foreach (var actor in list)
            {
                Console.WriteLine(actor);
            }
        }
        static void AddActor()
        {
            Console.WriteLine("Enter Actor Name");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            Console.WriteLine("Enter Date Of Birth");
            string input = Console.ReadLine();
           if (!DateOnly.TryParse(input, out DateOnly dob))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine("Enter Gender");
            string genderInput = Console.ReadLine();
            if (!Enum.TryParse<Gender>(genderInput, true, out Gender gender))
            {
                Console.WriteLine("Invalid gender input");
                return;
            }
           
           


            Actor actor = new Actor();
            actor.Name = name;
           
            actor.DateOfBirth = dob;
            actor.Gender = gender;
            
            bool isAdded = ActorBL.Add(actor);
            if (isAdded)
            {
                Console.WriteLine("Actor Added successfully");
            }
            else
            {
                Console.WriteLine("Add Actor failed");
            }
        }

        static void UpdateActor()
        {
            Console.WriteLine("Actor list");
            ListActors();

            Console.WriteLine("Enter Actor id to be updated");
            string input1 = Console.ReadLine();
            if (!int.TryParse(input1, out int id) || id < 1)
            {
                Console.WriteLine("Invalid");
                return;
            }

            var act = ActorBL.GetByid(id);
            Actor oldemp = new Actor();
            if (act == null)
            {
                Console.WriteLine("Invalid id");
                return;
            }

            else
            {

                Console.WriteLine("Enter updated Name");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid");
                    return;
                }
                oldemp.Name = input;


                Console.WriteLine("Enter updated DateOfBirth");
                input = Console.ReadLine();
                if (!DateOnly.TryParse(input, out DateOnly date))
                {
                    Console.WriteLine("Invalid");
                    return;
                }
                oldemp.DateOfBirth = date;




                Console.WriteLine("Select Gender");
                foreach (var g in Enum.GetNames(typeof(Gender)))
                {
                    Console.WriteLine(g);
                }
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) || !Enum.TryParse(typeof(Gender), input, out object gender))
                {
                    Console.WriteLine("Invalid");
                    return;
                }
                oldemp.Gender = (Gender)gender;



             
            bool isUpdated = ActorBL.Update(id, oldemp);
            if (isUpdated)
            {
                Console.WriteLine("Updation successfully");
            }
            else
            {
                Console.WriteLine("Actor not found");
            }
        }
    }

        static void DeleteActor()
        {
            Console.WriteLine("enter an id");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int id))
            {
                Console.WriteLine("Invalid");
                return;
            }
            ActorBL.Delete(id);
        }

        static void ListMovies()
        {
             var list=MovieBL.GetMovies();
            foreach (var mov in list) 
            {
                Console.WriteLine(mov);
            }
        }

        static void AddMovie()
        {
            int i = 1;
            Movie movie = new Movie();
            movie.Actors = new List<string?>();
            Console.WriteLine("Enter Movie Name");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine("Enter Director Name");
            string director = Console.ReadLine();
            if (string.IsNullOrEmpty(director))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine("Enter Rating from 1 to 10");
            string input4 = Console.ReadLine();
            if (!int.TryParse(input4, out int rating) && rating<=10)
            {
                Console.WriteLine("Invalid");
                return;
            }
          

            Console.WriteLine("Enter Duration of movie");
            string input = Console.ReadLine();
            if (!TimeSpan.TryParse(input, out TimeSpan duration))
            {
                Console.WriteLine("Invalid input");
                return;
            }
           
            Console.WriteLine("Enter Language");


            string languageInput = Console.ReadLine();
            if (!Enum.TryParse<Language>(languageInput, true, out Language language))
            {
                Console.WriteLine("Invalid gender input");
                return;
            }

           
            Console.WriteLine("Enter Genre");
            Console.WriteLine("Available Genres:");

            foreach (Genre gen in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"- {gen}");
            }
            string GenreInput = Console.ReadLine();
            if (!Enum.TryParse<Genre>(GenreInput, true, out Genre genre))
            {
                Console.WriteLine("Invalid gender input");
                return;
            }
            Console.WriteLine("Enter the release date");
            string input5 = Console.ReadLine();
            if (!int.TryParse(input5, out int releaseyear) && rating <= 10)
            {
                Console.WriteLine("Invalid");
                return;
            }
            // Assuming you have a List<Actor> availableActors that lists all available actors
            ListActors(); // Assume this method lists available actors
            do
            {
                Console.WriteLine("Choose actor id(s) separated by commas:");
                string input6 = Console.ReadLine();

                List<Actor> selectedActors = new List<Actor>();

                foreach (string idString in input6.Split(','))
                {
                    if (int.TryParse(idString, out int actorId))
                    {
                        string selectedActor = ActorBL.GetByid(actorId).Name;

                        if (selectedActor != null)
                        {
                            movie.Actors.Add(selectedActor);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid actor id: {actorId}");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid actor id: {idString}");
                        return;
                    }
                    Console.WriteLine("press 0 If you want to add more actors or press any other key to exit");
                    string inp= Console.ReadLine();
                    if(!int.TryParse(inp,out i))
                    {
                        Console.WriteLine("error");
                        return;
                    }
                }
            }
            while (i < 1);

            // Assign the list of selected actors to the movie's Actors property
            //movie.Actors = selectedActors;






            movie.Name = name;
            movie.Director= director;
            movie.ReleaseYear = releaseyear;
            movie.Genre = genre;
            movie.Language = language;
            movie.Rating = rating;
            movie.Duration = duration;

            bool isAdded = MovieBL.Add(movie);
            if (isAdded)
            {
                Console.WriteLine("Movie Added successfully");
            }
            else
            {
                Console.WriteLine("Add Movie failed");
            }
        }
        
        static void UpdateMovie()
        {
            int i = 1;
            Movie movie = new Movie();
            movie.Actors = new List<string?>();
            ListMovies();
            Console.WriteLine("choose the id of the movie to be updated");
            string input1 = Console.ReadLine();
            if (!int.TryParse(input1, out int id) || id < 1)
            {
                Console.WriteLine("Invalid");
                return;
            }
            var movies = MovieBL.GetByid(id);
           // Movie oldemp = new Movie();
            if (movies == null)
            {
                Console.WriteLine("Invalid id");
                return;
            }
            else
            {
                Console.WriteLine("Enter Movie Name");
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
                Console.WriteLine("Enter Director Name");
                string director = Console.ReadLine();
                if (string.IsNullOrEmpty(director))
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
                Console.WriteLine("Enter Rating from 1 to 10");
                string input4 = Console.ReadLine();
                if (!int.TryParse(input4, out int rating) && rating <= 10)
                {
                    Console.WriteLine("Invalid");
                    return;
                }


                Console.WriteLine("Enter Duration of movie");
                string input = Console.ReadLine();
                if (!TimeSpan.TryParse(input, out TimeSpan duration))
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
                Console.WriteLine("Enter Language");
                string languageInput = Console.ReadLine();
                if (!Enum.TryParse<Language>(languageInput, true, out Language language))
                {
                    Console.WriteLine("Invalid gender input");
                    return;
                }
                Console.WriteLine("Enter Genre");
                string GenreInput = Console.ReadLine();
                if (!Enum.TryParse<Genre>(GenreInput, true, out Genre genre))
                {
                    Console.WriteLine("Invalid gender input");
                    return;
                }
                Console.WriteLine("Enter the release date");
                string input5 = Console.ReadLine();
                if (!int.TryParse(input5, out int releaseyear) && rating <= 10)
                {
                    Console.WriteLine("Invalid");
                    return;
                }
                do
                {
                    ListActors(); // Assume this method lists available actors

                    Console.WriteLine("Choose actor id(s) to update:");
                    string input6 = Console.ReadLine();

                    List<Actor> selectedActors = new List<Actor>();

                    foreach (string idString in input6.Split(','))
                    {
                        if (int.TryParse(idString, out int actorId))
                        {
                            string selectedActor = ActorBL.GetByid(actorId).Name;

                            if (selectedActor != null)
                            {
                                movie.Actors.Add(selectedActor);
                            }
                            else
                            {
                                Console.WriteLine($"Invalid actor id: {actorId}");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Invalid actor id: {idString}");
                            return;
                        }
                        Console.WriteLine("press 0 If you want to add more actors or press any other key to exit");
                        string inp = Console.ReadLine();
                        if (!int.TryParse(inp, out i))
                        {
                            Console.WriteLine("error");
                            return;
                        }
                    }
                }
                while (i < 1);


                // Assign the list of selected actors to the movie's Actors property
                //movie.Actors = selectedActors;
                movie.Name = name;
                movie.Director = director;
                movie.ReleaseYear = releaseyear;
                movie.Genre = genre;
                movie.Language = language;
                movie.Rating = rating;
                movie.Duration = duration;
            }
            bool isUpdated = MovieBL.Update(id,movie);
            if (isUpdated)
            {
                Console.WriteLine("Updation successfully");
            }
            else
            {
                Console.WriteLine("Movie not found");
            }
        }
        static void DeleteMovie()
        {
            ListMovies();

            Console.WriteLine("Enter id of movie to be deleted");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int n) || n < 1)
            {
                Console.WriteLine("Invalid");
                return;
            }

            var mov = MovieBL.GetByid(n);

            if (mov == null)
            {
                Console.WriteLine("Invalid id");
            }
            else
            {
                MovieBL.Delete(n);
            }
        }

        static void SearchMovie()
        {
            Console.WriteLine("Enter the title of the movie to search:");
            string titleToSearch = Console.ReadLine();

            Movie foundMovie = MovieBL.GetByTitle(titleToSearch);

            if (foundMovie != null)
            {
                Console.WriteLine("Movie found:");
                Console.WriteLine(foundMovie.ToString());
            }
            else
            {
                Console.WriteLine("Movie not found.");
            }
        }
        static void SearchActor()
        {
            Console.WriteLine("Enter the name of the actor to search:");
            string name = Console.ReadLine();

            Actor foundActor = ActorBL.GetByTitle(name);

            if (foundActor != null)
            {
                Console.WriteLine("Movie found:");
                Console.WriteLine(foundActor.ToString());
            }
            else
            {
                Console.WriteLine("Movie not found.");
            }
        }
    }
}
