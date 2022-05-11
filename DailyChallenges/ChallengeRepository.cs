using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyChallenges
{
    public class ChallengeRepository
    {
        //01
        //Write a method that completes the following tasks:

        //Take in FOUR parameters: 2 strings and 2 ints. The strings being the names of two different soccer teams, and the ints being the teams' scores.

        //Method should return a string of either "{teamOne} won." or "{teamTwo} won." or "{teamOne} and {teamTwo} tied".

        //Invoke the method in Program.cs and print the returned results to the console.

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
        //Write a method that takes in a string and converts the string to SpOnGe bOb cAsInG. Invoke the method in Program.cs and print the returned string to the console.
        //Bonus: Get the input from the user.

        public string SpongeBobCase(string input)
        {
            string output = "";

            foreach (char x in input)
            {
                if (input.IndexOf(x) % 2 == 0)
                {
                    output += Char.ToUpper(x);
                }
                else
                {
                    output += Char.ToLower(x);
                }
            }

            return output;
        }



        //03
        //Write a method that takes in an array of ints and returns the sum of all of those ints.

        public int Sum(int[] intArr)
        {
            int sum = 0;

            foreach (int x in intArr)
            {
                sum += x;
            }

            return sum;
        }



        //04
        //Write a method that returns the average of an array of ints. The array of ints must be passed in as a parameter.

        public decimal Average(int[] intArr)
        {
            decimal sum = Sum(intArr);

            decimal arrayLength = intArr.Length;

            decimal average = (decimal)(sum / arrayLength);

            return average;
        }





        //05 Write another Average() method that takes parameters of (int[] intArr, int max, int min) - where max and min are thresholds for outliers - We don't want the outliers included in our average.

        public decimal Average(int[] intArr, int max, int min)
        {
            decimal sum = 0;
            decimal arrayLength = 0;

            foreach (int x in intArr)
            {
                if (x <= max && x >= min)
                {
                    sum += x;
                    arrayLength++;
                }
            }

            return sum / arrayLength;


            // int[] intArr = { 3, 6, 90, 5, 2, 8, 6, 120, 8, 12, 7, -56 }

            // int min = 0;
            // int max = 10;

            // decimal averageWithOutOutliers = _key.Average(intArr, max, min);
        }





























        // 20 minutes to write out step by step plans to complete the task. Post your plan in #class-lecture-code.

        // 06
        // INITIAL: Write a method that takes in a list of floats that represent measurements in miles and returns a list of those values in kilometers, but excludes measurements under 0.5m/0.8km. Print each measurement to the console.

        // HINT: The first line of code I'd write is :   public List<float> ConvertFromMilesToKm(List<float> milesList)

        // HINT: Console.WriteLine(List<float> listOfFloats) won't print each element of a list.

        // HINT: This is how I would invoke the method in Program.cs:
        // List<float> listOfMiles = new List<float>() { 3.56f, 6.890f, 12.7548f, 0.234f };
        // _repo.ConvertFromMilesToKm(listOfMiles);

        public List<float> ConvertFromMilesToKm(List<float> milesList)
        {
            List<float> kmList = new List<float>();

            for (int i = 0; i < milesList.Count; i++)
            {
                if (milesList[i] >= 0.5f)
                {
                    kmList.Add(ConvertFromMilesToKm(milesList[i]));
                }
            }

            PrintValues(kmList);

            return kmList;
        }

        private float ConvertFromMilesToKm(float miles)
        {
            return miles * 1.60934f;
        }

        private void PrintValues(List<float> kmList)
        {
            foreach (float x in kmList)
            {
                Console.WriteLine(x);
            }
        }


        // 07
        // INITIAL: Write a method that asks the user to choose between either A,B, or C. Based off of their choice print "alligator", "biscuit", or "chihuahua" to the console. If they don't choose A, B, or C print "spaghetti" to the console.

        // HINT: Console.ReadLine() will help you get an input from a user.

        // HINT: I'd use a switch case after I got the input from the user.


        public void GetUserChoiceAndPrintReaction()
        {
            Console.Write("A, B, or C: ");
            string userChoice = Console.ReadLine();

            switch (userChoice.ToUpper())
            {
                case "A":
                    Console.WriteLine("alligator");
                    break;
                case "B":
                    Console.WriteLine("biscuit");
                    break;
                case "C":
                    Console.WriteLine("chihuahua");
                    break;
                default:
                    Console.WriteLine("spaghetti");
                    break;

            }
        }


    }

    //  08
    // Create a Class Object called 'Shelter' - and think about zillow or realtor.com

    // The object must have properties that convey the following information:
    // Whether or not the shelter has a basement or garage.
    // What type of shelter it is: house or apartment or condo or townhouse or whatever.
    // Square footage.
    // Year built.
    // The address.

    // HINT: There can be more than 5 properties.

    // Needs empty and full constructors.
}