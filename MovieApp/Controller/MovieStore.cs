using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppLibrary;
using MovieAppLibrary.Models;
using MovieAppLibrary.Repository;
using MovieAppLibrary.Services;

namespace MovieApp.Controller
{
    internal class MovieStore
    {
        public static void DisplayMovieStore()
        {
            bool continueProgram = true;
            MovieManager movieManager = new MovieManager();

            while (continueProgram)
            {
                Console.WriteLine("------Welcome to Movie Store------");
                Console.WriteLine("\nSelect Operations: \n1. Add Movie\n2. Display Movie\n3. Delete Movie\n4. Exit");
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


