using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Software
{
    class ItemHelper
    {
        // Constant variables to store different item types.
        public const string ITEM_TYPE_BOOK = "Book";
        public const string ITEM_TYPE_MOVIE = "Movie";
        public const string ITEM_TYPE_GAME = "Game";

        // Constant variables to store index number.
        public const int IDX_ITEM_TYPE = 0;      // 1st Element: itemType.  
        public const int IDX_TITLE = 1;          // 2nd Element: Title.
        public const int IDX_COST = 2;           // 3rd Element: cost.
        public const int IDX_GENRE = 3;          // 4th Element: genre.
        public const int IDX_PLATFORM = 4;       // 5th Element: platform.
        public const int IDX_RELEASE_YEAR = 5;   // 6th Element: ReleaseYear.
        public const int IDX_INFO1 = 6;          // 7th Element: typeSpecificInfo1.
        public const int IDX_INFO2 = 7;          // 8th Element: typeSpecificInfo2.

        // Const variable for the number of item properties.
        const int NUM_OF_ITEM_PROPERTIES = 8;

        /// <summary>
        /// This helper method converts an array of fields to an item.
        /// </summary>
        /// <param name="fields">Is an array of strings</param>
        /// <returns>Item</returns>
        public static Item ConvertToItem(string[] fields)
        {
            // Store a variable of type platform.
            Platform platform = null;

            // Check if there are 8 elements in the array.
            if (fields.Length != NUM_OF_ITEM_PROPERTIES)
            {
                // Prompt error.
                throw new ItemDataException("Invalid Record");
            }

            // Create different item type objects depending on the item type.
            switch (fields[IDX_ITEM_TYPE])
            {
                // If itemType is book, create a book object.
                case ITEM_TYPE_BOOK:
                    // Get the platform of the book.
                    Book.BookType bookType = Book.ConvertTo(fields[IDX_PLATFORM]);

                    // Create new book object with its respective properties.
                    platform = new Book(fields[IDX_INFO1], fields[IDX_INFO2], bookType);
                    break;

                // If itemType is movie, create a movie object.
                case ITEM_TYPE_MOVIE:
                    // Get the platform of the movie.
                    Movie.MediaType mediaType = Movie.ConvertTo(fields[IDX_PLATFORM]);

                    // Try to convert duration to an int.
                    try
                    {
                        int duration = 0;
                        duration = Int32.Parse(fields[IDX_INFO2]);

                        // Create new movie object with its respective properties.
                        platform = new Movie(fields[IDX_INFO1], duration, mediaType);
                    }
                    // Catch and prompt error.
                    catch (Exception e)
                    {
                        throw new ItemDataException("Invalid duration", e);
                    }
                    break;

                // If itemType is game, create a game object.
                case ITEM_TYPE_GAME:
                    // Get the platform of the game.
                    Game.GameType gameType = (Game.GameType)Enum.Parse(typeof(Game.GameType), fields[IDX_PLATFORM]);

                    // Try to convert rating to type int.
                    try
                    {
                        int rating = 0;
                        rating = Int32.Parse(fields[IDX_INFO2]);

                        // Create new game object with its respective properties.
                        platform = new Game(fields[IDX_INFO1], rating, gameType);
                    }
                    // Catch and prompt any unexpected error.
                    catch (Exception e)
                    {
                        throw new ItemDataException(String.Format("Invalid rating {0}\n{1}", fields[IDX_INFO2], e.Message), e);
                    }
                    break;
                // Prompt error.
                default:
                    throw new ItemDataException(String.Format("Unkown item type {0}", fields[IDX_ITEM_TYPE]));
            }
            double cost = 0;

            // Try to convert cost to double.
            try
            {
                cost = double.Parse(fields[IDX_COST]);
            }
            // Catch and prompt any unexpected error.
            catch (Exception e)
            {
                throw new ItemDataException(String.Format("Invalid cost {0}\n{1}", fields[IDX_COST], e.Message), e);
            }
            int releaseYear = 0;

            // Try to convert releaseYear to double.
            try
            {
                releaseYear = int.Parse(fields[IDX_RELEASE_YEAR]);
            }
            // Catch and prompt any unexpected error.
            catch (Exception e)
            {
                throw new ItemDataException(String.Format("Invalid release year {0}\n{1}", fields[IDX_RELEASE_YEAR], e.Message), e);
            }
            // return new Item object.
            return new Item(fields[IDX_TITLE], cost, fields[IDX_GENRE], releaseYear, platform);
        }

        /// <summary>
        /// This helper method converts an item to an array of strings.
        /// </summary>
        /// <param name="item">Is of type Item and has all the properties an Item should have.</param>
        /// <returns></returns>
        public static string[] ConvertToFields(Item item)
        {
            // Create empty array of strings.
            string[] columns = new string[8];

            // Check if platform is game.
            if (item.platform is Game)
            {
                // Set the item type index to Game.
                columns[IDX_ITEM_TYPE] = ITEM_TYPE_GAME;

                // Cast Game to the item platform.
                Game game = (Game)item.platform;

                // Set the games properties to its respective index.
                columns[IDX_PLATFORM] = Game.ConvertTo(game.gameType);
                columns[IDX_INFO1] = game.developer;
                columns[IDX_INFO2] = game.rating.ToString();
            }
            // Check if platform is movie.
            else if (item.platform is Movie)
            {
                // Set the item type index to Movie.
                columns[IDX_ITEM_TYPE] = ITEM_TYPE_MOVIE;

                // Cast Movie to the item platform.
                Movie movie = (Movie)item.platform;

                // Set the movie properties to its respective index.
                columns[IDX_PLATFORM] = Movie.ConvertTo(movie.media);
                columns[IDX_INFO1] = movie.director;
                columns[IDX_INFO2] = movie.duration.ToString();
            }
            // Check if platform is book.
            else if (item.platform is Book)
            {
                // Set the item type index to Book.
                columns[IDX_ITEM_TYPE] = ITEM_TYPE_BOOK;

                // Cast Book to the item platform.
                Book book = (Book)item.platform;

                // Set the book properties to its respective index.
                columns[IDX_PLATFORM] = Book.ConvertTo(book.bookType);
                columns[IDX_INFO1] = book.author;
                columns[IDX_INFO2] = book.publisher;
            }

            // Set the index of the array to its respective values.
            columns[IDX_TITLE] = item.title;
            columns[IDX_COST] = item.cost.ToString();
            columns[IDX_GENRE] = item.genre;
            columns[IDX_RELEASE_YEAR] = item.releaseYear.ToString();

            // Return the array with all valid elements.
            return columns;
        }
    }
}
