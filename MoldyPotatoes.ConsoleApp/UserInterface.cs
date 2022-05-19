using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoldyPotatoes.Repository;

namespace MoldyPotatoes.ConsoleApp
{
    public class UserInterface
    {
        MovieRepository _repo = new MovieRepository();


        ICustomConsole _console;


        public UserInterface(ICustomConsole console)
        {
            _console = console;
        }

        bool isRunning = true;


        public void Run()
        {
            _repo.SeedMovieData();

            while (isRunning)
            {
                _console.PrintMainMenu();
                string userInput = _console.GetUserInput();

                UserInputPortal(userInput);
            }
        }

        private void UserInputPortal(string inputFromUser)
        {
            switch (inputFromUser)
            {
                case "1":
                    CreateNewMovie();
                    break;
                case "2":
                    ViewAllMovies();
                    break;
                case "3":
                    //GetMovieByTitle();
                    break;
                case "4":
                    SearchByTitle();
                    break;
                case "5":
                    //EditAMovie();
                    break;
                case "6":
                    //DeleteAMovie();
                    break;
                case "7":
                    //Exit();
                    break;
                default:
                    //InvalidInputReturnToMainMenu();
                    break;
            }
        }

        private void CreateNewMovie()
        {
            _console.EnterATitle();
            string title = _console.GetUserInput();

            _console.EnterDirectorName();
            string director = _console.GetUserInput();

            _console.GenreSelectionMenu();
            string genreSelection = _console.GetUserInput();

            Genre? movieGenre = GenreSelection(genreSelection);

            _console.RatingSelectionMenu();
            string ratingSelection = _console.GetUserInput();

            Rating? movieRating = RatingSelection(ratingSelection);

            bool isKidFriendly = IsKidFriendlySelection(movieRating);

            _console.EnterStars();
            int stars = _console.GetUserInputInt();

            //Constructor
            Movie newMovie = new Movie(title, director, isKidFriendly, movieGenre, movieRating, stars);

            _repo.AddMovieToDatabase(newMovie);

            _console.PressAnyKeyToContinue();
        }

        public void ViewAllMovies()
        {
            List<Movie> allMovies = _repo.GetAllMovies();

            _console.PrintMovies(allMovies);

            _console.PressAnyKeyToContinue();
        }

        public void SearchByTitle()
        {
            _console.Search();
            string searchInput = _console.GetUserInput();

            List<Movie> films = _repo.GetMoviesByTitleSearch(searchInput);

            _console.PrintMovies(films);

            _console.PressAnyKeyToContinue();
        }

        //CRUD ^^^^^
        //HELPER vvvv

        private bool IsKidFriendlySelection(Rating? movieRating)
        {
            if (movieRating == Rating.G || movieRating == Rating.PG)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Rating? RatingSelection(string userGenreInput)
        {
            switch (userGenreInput)
            {
                case "1":
                    return Rating.G;
                case "2":
                    return Rating.PG;
                case "3":
                    return Rating.PG_13;
                case "4":
                    return Rating.R;
                case "5":
                    return Rating.MA;
                default:
                    return null;
            }
        }

        private Genre? GenreSelection(string userGenreInput)
        {
            switch (userGenreInput)
            {
                case "1":
                    return Genre.Action;
                case "2":
                    return Genre.Comedy;
                case "3":
                    return Genre.Drama;
                case "4":
                    return Genre.Romance;
                case "5":
                    return Genre.RomCom;
                case "6":
                    return Genre.Thriller;
                case "7":
                    return Genre.SciFi_Fantasy;
                default:
                    return null;
            }
        }

        //
    }
}