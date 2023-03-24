using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Business_Software
{
    // This class is a relationship of Platform
    public class Book : Platform
    {
        // Constant variables to store the name for the platform
        public const string EBook = "E-Book";
        public const string AudioBook = "Audio Book";

        // Properties for the Book class.
        public string author;
        public string publisher;
        public BookType bookType;

        // This BookType enum has 4 nicknames: Hardcover, Paperback, E_Book and Audio_Book
        public enum BookType
        {
            Hardcover, Paperback, E_Book, Audio_Book
        }

        // This constuctor initializes a book given its properties.
        public Book(string author, string publisher, BookType bookType)
            : base()
        {
            this.author = author;
            this.publisher = publisher;
            this.bookType = bookType;
        }

        /// <summary>
        /// This function will return the enum value of the string value.
        /// </summary>
        /// <param name="bookType">Is a string</param>
        /// <returns>BookType</returns>
        public static BookType ConvertTo(string bookType)
        {
            switch (bookType)
            {
                case EBook:
                    return BookType.E_Book;
                case AudioBook:
                    return BookType.Audio_Book;
                default:
                    return (Book.BookType)Enum.Parse(typeof(Book.BookType), bookType);
            }
        }

        /// <summary>
        /// This function will return the string value of each book type.
        /// </summary>
        /// <param name="bookType">bookType is of enum BookType</param>
        /// <returns>string</returns>
        public static string ConvertTo(BookType bookType)
        {
            switch (bookType)
            {
                case BookType.E_Book:
                    return EBook;
                case BookType.Audio_Book:
                    return AudioBook;
                default:
                    return bookType.ToString();
            }
        }
    }
}
