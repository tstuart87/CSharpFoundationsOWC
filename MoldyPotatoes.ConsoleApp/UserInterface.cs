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
        CustomConsole _console = new CustomConsole();
        bool isRunning = true;

        public void Run()
        {
            _repo.SeedMovieData();

            while (isRunning)
            {
                _console.PrintMainMenu();
            }
        }
    }
}