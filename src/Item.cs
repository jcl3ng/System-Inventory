using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Software
{
    // This is the parent/base class.
    public class Item
    {
        // Properties for item type.
        public string title;
        public double cost;
        public string genre;
        public int releaseYear;
        public Platform platform;

        // This Constructor composes an item.
        public Item(string title, double cost, string genre, int releaseYear, Platform platform)
        {
            this.title = title;
            this.cost = cost;
            this.genre = genre;
            this.releaseYear = releaseYear;
            this.platform = platform;
        }

        /// <summary>
        /// This function returns the platform of the item as a string.
        /// </summary>
        /// <returns>string</returns>
        public string GetItemType()
        {
            // If platform is book, return book as a string.
            if (this.platform is Book)
            {
                return ItemHelper.ITEM_TYPE_BOOK;
            }
            // If platform is movie, return movie as a string.
            else if (this.platform is Movie)
            {
                return ItemHelper.ITEM_TYPE_MOVIE;
            }
            // If platform is game, return game as a string.
            else if (this.platform is Game)
            {
                return ItemHelper.ITEM_TYPE_GAME;
            }
            // Prompt error.
            throw new ItemDataException("Internal Error");
        }
    }
}
