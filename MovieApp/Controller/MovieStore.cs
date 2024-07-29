using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppLibrary.Repository;

namespace MovieApp.Controller
{
    public class MovieStore
    {
        public static void DisplayMovieStore()
        {
            bool continueProgram = true;
            MovieManager movieManager = new MovieManager();

            while (continueProgram)
            {
                Console.WriteLine("\n------Welcome to Movie Store------");
                Console.WriteLine("\nSelect Operations: \n1. Add Movie\n2. Display Movie\n3. Delete Movie\n4. Display All Movies\n5. Exit");
                int userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        MovieManager.AddMovie();
                        break;
                    case 2:
                        MovieManager.DisplayMovie();
                        break;
                    case 3:
                        MovieManager.DeleteMovie();
                        break;
                    case 4:
                        MovieManager.DisplayAllMovies();
                        break;
                    case 5:
                        continueProgram = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
