using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoldyPotatoes.ConsoleApp
{
    public class CustomConsole
    {
        // SINGLE RESPONSIBILITY
        // Methods that print things to the console.
        public void PrintMainMenu()
        {
            Console.WriteLine("1. View All Movies.\n" +
                            "2. Get Movie By Title.");
        }
    }
}