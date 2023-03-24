using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Business_Software
{
    // This class implements IFileRepository.
    class ItemFileRepository : IFileRepository<Item>
    {
        // Create a const delimiter.
        public const char DEFAULT_DELIMITER = ',';

        // Properties for ItemFileRepository.
        private string fileName;
        private char delimiter;
       
        // This overloaded constructor takes fileName and supplied delimiter.
        public ItemFileRepository(string fileName, char delimiter)
        {
            this.fileName = fileName;
            this.delimiter = delimiter;
        }

        // This overloaded constructor takes fileName and intializes delimter as DEFAULT_DELIMITER.
        public ItemFileRepository(string fileName)
        {
            this.delimiter = DEFAULT_DELIMITER;
            this.fileName = fileName;
        }

        /// <summary>
        /// This procedure will add each line from the text file to a list of items.
        /// </summary>
        /// <returns>List<Items></returns>
        public List<Item> load()
        {
            // Create an empty list to store items.
            List<Item> itemList = new List<Item>();

            // Create an empty string.
            String textLine = "";

            // Try to add each string to an item from file and add to the list.
            try
            {
                // Open and close the file.
                using (StreamReader inFile = File.OpenText(fileName))
                {
                    while (inFile.EndOfStream == false)         //Read the file until there is no more file to read
                    {
                        textLine = inFile.ReadLine();           //Read the current line from the file
                        itemList.Add(Convert(textLine));        // Convert the line to an item and add it to the list.
                    }
                }
            }
            // Catch and prompt any unexpected error.
            catch (Exception e)
            {
                throw new FileRepositoryException("Fail to load inventory", e);
            }
            return itemList;
        }

        /// <summary>
        /// This Helper method will convert a string to an Item.
        /// </summary>
        /// <param name="record">record is of type string</param>
        /// <returns>Item</returns>
        private Item Convert(string record)
        {
            return ItemHelper.ConvertToItem(record.Split(delimiter));
        }

        /// <summary>
        /// This procedure will write out all elements from a list to the file.
        /// </summary>
        /// <param name="objs">objs is a list of type Item</param>
        public void save(List<Item> objs)
        {
            // Try joining all elements of the array together.
            try
            {
                using (StreamWriter save = new StreamWriter(fileName, false))
                {
                    // Loop through each item in the list.
                    foreach (Item item in objs)
                    {
                        // Convert each element in the list to an arrray of strings and join by common seperator.
                        save.WriteLine(String.Join(",", ItemHelper.ConvertToFields(item).ToArray()));
                    }
                }
            }
            // Catch and prompt any unexpected error.
            catch (Exception e)
            {
                throw new FileRepositoryException("Failed to save inventory", e);
            }
        }
    }
}
