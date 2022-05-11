using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Car
    {
        //Make Properties for CAR
        //Full Constructor
        //Empty Constructor
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string BodyStyle { get; set; }
        public int EngineCylinders { get; set; }
        public bool IsNew { get; set; }
        public char SafetyRating { get; set; }
        public float ZeroToSixtyTime { get; set; }
        public Interior InteriorOptions { get; set; }

        public Car(string make, string model, string color, string bodyStyle, int engineCylinders, bool isNew, char safetyRating, float zeroToSixtyTime, Interior interiorOptions)
        {
            //Full Constructor
        }

        public Car() { }
    }

    public enum Interior { Leather, Sunroof, WoodFinish, WirelessCharging, LaneAssist }


    public class Movie
    {
        //Class OBJECT

        public string Title { get; set; } //PROPERTY
        public string DirectorName { get; set; }
        public int Stars { get; set; }
        public Rating MovieRating { get; set; }
        public Genre MovieGenre { get; set; }

        //FULL CONSTRUCTOR
        public Movie(string title, string directorName, int stars, Rating movieRating, Genre movieGenre)
        {
            Title = title;
            DirectorName = directorName;
            Stars = stars;
            MovieRating = movieRating;
            MovieGenre = movieGenre;
        }

        //EMPTY CONSTRUCTOR
        public Movie() { }
    }

    public enum Rating { G, PG, PG_13, R, MA }
    public enum Genre { Action, Comedy, Drama, Horror, Romance, RomCom, Thriller, SciFi_Fantasy }
}