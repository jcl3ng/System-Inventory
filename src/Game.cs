using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Software
{
    // This class is a relationship of Platform
    public class Game : Platform
    {
        // Game properties.
        public string developer;
        public Int32 rating;
        public GameType gameType;

        // This GameType enum has 3 nicknames: Sony, Microsoft and Nintendo.
        public enum GameType
        {
            Sony, Microsoft, Nintendo
        }

        // This constructor will initialize the Game properties.
        public Game(string developer, Int32 rating, GameType gameType)
            : base()
        {
            this.developer = developer;
            this.rating = rating;
            this.gameType = gameType;
        }

        /// <summary>
        /// This function returns the GameType value for a given string.
        /// </summary>
        /// <param name="gameType">Is a string</param>
        /// <returns>GameType</returns>
        public static GameType ConvertTo(string gameType)
        {
            return (Game.GameType)Enum.Parse(typeof(Game.GameType), gameType);
        }

        /// <summary>
        /// This function returns the string value for a given GameType.
        /// </summary>
        /// <param name="gameType">Is of type GameType</param>
        /// <returns>string</returns>
        public static string ConvertTo(GameType gameType)
        {
            return gameType.ToString();
        }

    }
}
