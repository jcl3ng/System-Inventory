using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Software
{
    // This class is a relationship of Platform
    public class Movie : Platform
    {
        // Constant variable to store string value of Blu-Ray.
        public const string BLU_RAY = "Blu-Ray";

        // Movie Properties.
        public string director;
        public Int32 duration;
        public MediaType media;

        // This MediaType enum has 2 nicknames: DVD and Blu_Ray.
        public enum MediaType
        {
            DVD, Blu_Ray
        }

        // This constructor initializes the Movie properties.
        public Movie(string director, Int32 duration, MediaType media)
            : base()
        {
            this.director = director;
            this.duration = duration;
            this.media = media;
        }

        /// <summary>
        /// This function will convert the a string to its respective enum nickname.
        /// </summary>
        /// <param name="mediaType">mediaTypes is a string</param>
        /// <returns></returns>
        public static MediaType ConvertTo(string mediaType)
        {
            switch (mediaType)
            {
                case BLU_RAY:
                    return MediaType.Blu_Ray;
                default:
                    return (Movie.MediaType)Enum.Parse(typeof(Movie.MediaType), mediaType);
            }
        }

        /// <summary>
        /// This function will convert a MediaType to its respective string name.
        /// </summary>
        /// <param name="mediaType"></param>
        /// <returns></returns>
        public static string ConvertTo(MediaType mediaType)
        {
            switch (mediaType)
            {
                case MediaType.Blu_Ray:
                    return BLU_RAY;
                default:
                    return mediaType.ToString();
            }
        }
    }
}
