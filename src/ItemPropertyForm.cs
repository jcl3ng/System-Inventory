using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Software
{
    public partial class ItemPropertyForm : Form
    {
        // Constant variables to store index number.
        const int IDX_ITEM_TYPE = 0;      // 1st Element: itemType.  
        const int IDX_TITLE = 1;          // 2nd Element: Title.
        const int IDX_COST = 2;           // 3rd Element: cost.
        const int IDX_GENRE = 3;          // 4th Element: genre.
        const int IDX_PLATFORM = 4;       // 5th Element: platform.
        const int IDX_RELEASE_YEAR = 5;   // 6th Element: ReleaseYear.
        const int IDX_INFO1 = 6;          // 7th Element: typeSpecificInfo1.
        const int IDX_INFO2 = 7;          // 8th Element: typeSpecificInfo2.

        // Create a DataGridView object.
        DataGridView dataGridView;

        // This Action enum has 2 nicknames: add or update.
        public enum Action
        {
            add, update
        }

        public ItemPropertyForm(DataGridView dataGridView, Action action, Item item)
            : base()
        {
            this.dataGridView = dataGridView;
            InitializeComponent();

            switch (action)
            {
                case Action.add:
                    // Update the title of form.
                    this.lblFormTitle.Text = "Add Item";

                    // Change location of add button and cancel button.
                    this.btnAdd.Location = new Point(88, 400);
                    this.btnCancel.Location = new Point(248, 400);

                    // Hide the update and delete button.
                    this.btnUpdate.Hide();
                    this.btnDelete.Hide();
                    break;
                case Action.update:
                    // Update title of the form.
                    this.lblFormTitle.Text = "Update Item";

                    // Hide Add button.
                    this.btnAdd.Hide();

                    // Set the properties of the item its respective text box.
                    this.txtTitle.Text = item.title;
                    this.txtCost.Text = item.cost.ToString();
                    this.txtGenre.Text = item.genre;

                    // If the platform is of type Book set its values to its respective text box.
                    if (item.platform is Book)
                    {
                        // Cast Book to the platform
                        Book book = (Book)item.platform;

                        // Change the text of the combo box to its respective item type and platform.
                        this.cmbBoxItemType.Text = ItemHelper.ITEM_TYPE_BOOK;
                        this.cmbBoxPlatform.Text = Book.ConvertTo(book.bookType);

                        // Change the text of the specific info labels to its respective item type.
                        this.lblItemInfo1.Text = "Author";
                        this.lblItemInfo2.Text = "Publisher";
                        this.txtItemInfo1.Text = book.author;
                        this.txtItemInfo2.Text = book.publisher;
                    }
                    // If the platform is of type Movie set its values to its respective text box.
                    else if (item.platform is Movie)
                    {
                        // Cast Movie to the platform
                        Movie movie = (Movie)item.platform;

                        // Update the text of the combo box to its respective item type and platform.
                        this.cmbBoxItemType.Text = ItemHelper.ITEM_TYPE_MOVIE;
                        this.cmbBoxPlatform.Text = Movie.ConvertTo(movie.media);

                        // Change the text of the specific info labels to its respective item type.
                        this.lblItemInfo1.Text = "Director";
                        this.lblItemInfo2.Text = "Duration (min)";

                        // Update the textbox to its respective info.
                        this.txtItemInfo1.Text = movie.director;
                        this.txtItemInfo2.Text = movie.duration.ToString();
                    }
                    // If the platform is of type Game set its values to its respective text box.
                    else if (item.platform is Game)
                    {
                        // Cast Game to the platform
                        Game game = (Game)item.platform;

                        // Change the text of the combo box to its respective item type and platform.
                        this.cmbBoxItemType.Text = ItemHelper.ITEM_TYPE_GAME;
                        this.cmbBoxPlatform.Text = Game.ConvertTo(game.gameType);

                        // Change the text of the specific info labels to its respective item type.
                        this.lblItemInfo1.Text = "Developer";
                        this.lblItemInfo2.Text = "Rating";

                        // Update the textbox to its respective info.
                        this.txtItemInfo1.Text = game.developer;
                        this.txtItemInfo2.Text = game.rating.ToString();
                    }
                    this.txtReleaseYear.Text = item.releaseYear.ToString();
                    break;
                default:
                    break;
            }
        }

        // This costructor allows this form to have acces to the datagridview.
        public ItemPropertyForm(DataGridView dataGridView)
            : base()
        {
            this.dataGridView = dataGridView;
            InitializeComponent();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Proceed if user selcets Book and add its platforms the the second cmbBox.
            if (cmbBoxItemType.SelectedIndex == 0)
            {
                cmbBoxPlatform.Items.Clear();
                cmbBoxPlatform.Items.Add("Hardcover");
                cmbBoxPlatform.Items.Add("Paperback");
                cmbBoxPlatform.Items.Add("E-Book");
                cmbBoxPlatform.Items.Add("Audio Book");
                lblItemInfo1.Text = "Author";
                lblItemInfo2.Text = "Publisher";
            }
            // Proceed if user selects Game and add its platforms the the second cmbBox.
            if (cmbBoxItemType.SelectedIndex == 1)
            {
                cmbBoxPlatform.Items.Clear();
                cmbBoxPlatform.Items.Add("Microsoft");
                cmbBoxPlatform.Items.Add("Sony");
                cmbBoxPlatform.Items.Add("Nintendo");
                lblItemInfo1.Text = "Developer";
                lblItemInfo2.Text = "Rating";
            }
            // Procced if user slects Movie and add its platforms the the second cmbBox.
            if (cmbBoxItemType.SelectedIndex == 2)
            {
                cmbBoxPlatform.Items.Clear();
                cmbBoxPlatform.Items.Add("DVD");
                cmbBoxPlatform.Items.Add("Blu-Ray");
                lblItemInfo1.Text = "Director";
                lblItemInfo2.Text = "Duration (min)";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Remove the selcted row and refresh the data grid.
            dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
            dataGridView.Refresh();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Try to create a new item with the users input.
            try
            {
                Platform platform = null;

                // Switch through the combo box item type.
                switch (cmbBoxItemType.Text)
                {
                    // In the case the user seclects a movie, create a new movie object.
                    case "Movie":
                        platform = new Movie(txtItemInfo1.Text, Convert.ToInt32(txtItemInfo2.Text), Movie.ConvertTo(cmbBoxPlatform.Text));
                        break;
                    // In the case the user seclects a book, create a new book object.
                    case "Book":
                        platform = new Book(txtItemInfo1.Text, txtItemInfo2.Text, Book.ConvertTo(cmbBoxPlatform.Text));
                        break;
                    // In the case the user seclects a game, create a new game object.
                    case "Game":
                        platform = new Game(txtItemInfo1.Text, Convert.ToInt32(txtItemInfo2.Text), Game.ConvertTo(cmbBoxPlatform.Text));
                        break;
                    default:
                        MessageBox.Show("Oops, looks like one of the values is invalid.");
                        break;
                }
                // Create a new item with the users input.
                Item item = new Item(txtTitle.Text, Convert.ToDouble(txtCost.Text), txtGenre.Text, Convert.ToInt32(txtReleaseYear.Text), platform);

                // Add the item to the datagridview.
                dataGridView.Rows.Add(convert(item));

                // Refresh the datagridview.
                dataGridView.Refresh();

                // Close the form.
                this.Close();
            }
            // Catch exception and prompt the error.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ItemPropertyForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Set each text box to its designated cell in the data grid view.
            dataGridView.CurrentRow.Cells[IDX_ITEM_TYPE].Value = this.cmbBoxItemType.Text;
            dataGridView.CurrentRow.Cells[IDX_TITLE].Value = this.txtTitle.Text;
            dataGridView.CurrentRow.Cells[IDX_COST].Value = this.txtCost.Text;
            dataGridView.CurrentRow.Cells[IDX_GENRE].Value = this.txtGenre.Text;
            dataGridView.CurrentRow.Cells[IDX_PLATFORM].Value = this.cmbBoxPlatform.Text;
            dataGridView.CurrentRow.Cells[IDX_RELEASE_YEAR].Value = this.txtReleaseYear.Text;
            dataGridView.CurrentRow.Cells[IDX_INFO1].Value = this.txtItemInfo1.Text;
            dataGridView.CurrentRow.Cells[IDX_INFO2].Value = this.txtItemInfo2.Text;
            dataGridView.Refresh();
            this.Close();
        }

        /// <summary>
        /// This function converts an item to an array of strings.
        /// </summary>
        /// <param name="item">item is of type Item</param>
        /// <returns>columns</returns>
        private string[] convert(Item item)
        {
            // Create an array of strings which would store the data of each row.
            string[] columns = new string[8];

            // Check to see if the platform is a game.
            if (item.platform is Game)
            {
                columns[IDX_ITEM_TYPE] = "Game";
                Game game = (Game)item.platform;
                columns[IDX_PLATFORM] = Game.ConvertTo(game.gameType);
                columns[IDX_INFO1] = game.developer;
                columns[IDX_INFO2] = game.rating.ToString();
            }
            // Check to see if the platform is a movie.
            else if (item.platform is Movie)
            {
                columns[IDX_ITEM_TYPE] = "Movie";
                Movie movie = (Movie)item.platform;
                columns[IDX_PLATFORM] = Movie.ConvertTo(movie.media);
                columns[IDX_INFO1] = movie.director;
                columns[IDX_INFO2] = movie.duration.ToString();

            }
            // Check to see if the platform is a book.
            else if (item.platform is Book)
            {
                columns[IDX_ITEM_TYPE] = "Book";
                Book book = (Book)item.platform;
                columns[IDX_PLATFORM] = Book.ConvertTo(book.bookType);
                columns[IDX_INFO1] = book.author;
                columns[IDX_INFO2] = book.publisher;
            }
            // Store the items properties to its respective index.
            columns[IDX_TITLE] = item.title;
            columns[IDX_COST] = item.cost.ToString();
            columns[IDX_GENRE] = item.genre;
            columns[IDX_RELEASE_YEAR] = item.releaseYear.ToString();
            return columns;
        }

        private void lblItemInfo2_Click(object sender, EventArgs e)
        {

        }
    }
}
