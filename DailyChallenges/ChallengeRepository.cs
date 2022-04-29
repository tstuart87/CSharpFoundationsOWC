using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyChallenges
{
    public class ChallengeRepository
    {
        //01
        //Write a method that each complete the following tasks:

        //Take in FOUR parameters: 2 strings and 2 ints. The strings being the names of two different soccer teams, and the ints being the teams' scores.

        //Method should return a string of either "{teamOne} won." or "{teamTwo} won." or "{teamOne} and {teamTwo} tied".

        //Invoke each method in Program.cs and print the returned results to the console.











        public string SoccerMatchOutcome(int scoreOne, int scoreTwo, string teamOne, string teamTwo)
        {
            string outcome;

            if (scoreOne == scoreTwo)
            {
                outcome = $"{teamOne} and {teamTwo} tied.";
            }
            else if (scoreOne > scoreTwo)
            {
                outcome = $"{teamOne} won.";
            }
            else
            {
                outcome = $"{teamTwo} won.";
            }

            return outcome;
        }



        //02
        //

    }
}