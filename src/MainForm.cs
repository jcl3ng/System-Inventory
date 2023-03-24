using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Business_Software
{

    public partial class MainForm : Form
    {
        // Constant variables to store the item types.
        const string ITEM_TYPE_BOOK = "Book";
        const string ITEM_TYPE_MOVIE = "Movie";
        const string ITEM_TYPE_GAME = "Game";

        // This costant variable stores the file name.
        public const string INVENTORY_FILE = "inventory.txt";

        // Create a variable of type ItemFileRepository.
        ItemFileRepository fileRepository;

        // Create a new list to store Item.
        List<Item> itemList = new List<Item>();

        public MainForm()
        {
            InitializeComponent();

            // Load the inventory.
            fileRepository = new ItemFileRepository(INVENTORY_FILE);
            LoadInventory();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbBoxSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create a new object called frm.
            ItemPropertyForm frm = new ItemPropertyForm(dataGridView, ItemPropertyForm.Action.add, null);

            // Show the form.
            frm.ShowDialog();
            frm.Dispose();

            // Update labels.
            NumOfItemLabels();
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadInventory();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Try to modify the selected row.
            try
            {
                // Create a new list of strings.
                List<string> list = new List<string>();

                // Add the selected cell to the list.
                foreach (DataGridViewCell cell in dataGridView.CurrentRow.Cells)
                {
                    list.Add(cell.Value.ToString());
                }

                // Create a new ItemPropertyForm.
                ItemPropertyForm frm = new ItemPropertyForm(dataGridView, ItemPropertyForm.Action.update, ItemHelper.ConvertToItem(list.ToArray()));

                // Show form and dispose.
                frm.ShowDialog();
                frm.Dispose();

                // Update label.
                NumOfItemLabels();
            }
            // Catch and prompt any unexcpeted error.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblPlatform_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalRows_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Display num of items.
            NumOfItemLabels();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Initialize an empty string variable to store the message.
            string message = "";

            // Try to delete the sected rows.
            try
            {
                // If there are 0 rows selected, prompt user to select a row.
                if (this.dataGridView.SelectedRows.Count == 0)
                {
                    message = "Please select a row to delete.";
                }
                // Prompt confirmation to delete row.
                else
                {
                    message = string.Format("Do you want to delete {0} row(s).", dataGridView.SelectedRows.Count);
                }
                // Proceed if ShowMyDialogBox is true.
                if (ShowMyDialogBox(message))
                {
                    // Delete all selected row in the data grid view.
                    foreach (DataGridViewRow item in this.dataGridView.SelectedRows)
                    {
                        dataGridView.Rows.RemoveAt(item.Index);
                    }

                    // Update label.
                    NumOfItemLabels();
                }
            }
            // Catch and prompt unexpected error.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Try to search and sort given title, platform and item type.
            try
            {
                // Using LINQ Query to search for itemType, Platform and title in DataGridView table.
                DataGridViewRow[] rows = dataGridView.Rows
                    .Cast<DataGridViewRow>()

                    // Where clause condition: foreach row, match itemType if itemType selection is provided.
                    .Where(r => cmbBoxItemType.Text == ""
                        || (r.Cells[ItemHelper.IDX_ITEM_TYPE].Value != null && r.Cells[ItemHelper.IDX_ITEM_TYPE].Value.ToString().Equals(cmbBoxItemType.Text)))

                    // Where clause and condition: foreach row, match platform if platform selection is provided.
                    .Where(r => cmbBoxPlatform.Text == ""
                        || (r.Cells[ItemHelper.IDX_PLATFORM].Value != null && r.Cells[ItemHelper.IDX_PLATFORM].Value.ToString().Equals(cmbBoxPlatform.Text)))

                    // Where clause and condition: foreach row, match title if title text is provided.
                    .Where(r => txtFindTitle.Text == ""
                        || (r.Cells[ItemHelper.IDX_TITLE].Value != null && r.Cells[ItemHelper.IDX_TITLE].Value.ToString().Equals(txtFindTitle.Text)))

                    // Sort by title and take first 10 of the resulted query.
                    .OrderBy(r => r.Cells[ItemHelper.IDX_TITLE].Value)
                    .Take(10)
                    .ToArray();

                // Check to see if there are any elements in the array.
                if (rows.Count() == 0)
                {
                    // Prompt message.
                    MessageBox.Show("No item found");
                }
                else
                {
                    // Hide all non matching items.
                    foreach (DataGridViewRow r in dataGridView.Rows)
                    {
                        r.Visible = false;
                    }

                    // Show all matched rows.
                    foreach (DataGridViewRow r in rows)
                    {
                        r.Visible = true;
                    }
                    // Sort all items by title in ascending order.
                    dataGridView.Sort(dataGridView.Columns[ItemHelper.IDX_TITLE], ListSortDirection.Ascending);

                    // Update label.
                    NumOfItemLabels();
                }
            }
            // Catch and prompt any unexpected error.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create an empty list that stores Item.
            List<Item> listItems = new List<Item>();

            try
            {
                // Loop through each row in dataGridView.
                foreach (DataGridViewRow r in dataGridView.Rows)
                {
                    // Create an emtpy string array.
                    string[] fields = new string[8];

                    // Loop through each column and stores its data to the array.
                    for (int c = 0; c < 8; c++)
                    {
                        fields[c] = r.Cells[c].Value.ToString();
                    }
                    // Add the item to listItems.
                    listItems.Add(ItemHelper.ConvertToItem(fields));
                }
                // Save the list of items.
                fileRepository.save(listItems);
            }
            catch (Exception ex)
            {
                // Prompt error.
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// This procedure will update the label which displays the number of items in the data grid view.
        /// </summary>
        private void NumOfItemLabels()
        {
            // Initialize a variable to count visible rows.
            int count = 0;

            // Loop through each row in DataGridView
            foreach (DataGridViewRow r in dataGridView.Rows)
            {
                // Add 1 to count if row is visible.
                if (r.Visible)
                {
                    count++;
                }
            }

            // Update both labels.
            lblDisplayNum.Text = count.ToString();
            lblTotalNum.Text = dataGridView.Rows.Count.ToString();
        }

        /// <summary>
        /// This function will open a new dialog box and check if ok was pressed.
        /// </summary>
        /// <param name="message">message is a string</param>
        /// <returns>dialogBox.IsOk</returns>
        public bool ShowMyDialogBox(string message)
        {
            // Create an object caled dialogBox.
            ConfirmationForm dialogBox = new ConfirmationForm(message);

            // Open the dialog box.
            dialogBox.ShowDialog(this);
            dialogBox.Dispose();

            // Return true if ok was pressed.
            return dialogBox.IsOk;
        }

        /// <summary>
        /// This procedure loads the data grid view.
        /// </summary>
        private void LoadInventory()
        {
            // Clear the data grid view.
            dataGridView.Rows.Clear();

            // Try to load the datagridview.
            try
            {
                // Catch the itemList from the fileRepository.
                itemList = fileRepository.load();

                // loop through each element in itemList.
                foreach (var item in itemList)
                {
                    // Add a row with all the elements in the list.
                    dataGridView.Rows.Add(ItemHelper.ConvertToFields(item));
                }
            }
            // Catch and prompt any unexpected error.
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Failed to load {0}\nDetail Message:\n{1}", ex.Message, ex.InnerException.Message));
            }

            // Refresh the datagridview.
            dataGridView.Refresh();

            // Update label.
            NumOfItemLabels();
        }

        /// <summary>
        /// This procedure will load the cmbBox.
        /// </summary>
        private void CmbBoxSelection()
        {
            // Proceed if user selcets Book and add its platforms to the second cmbBox.
            if (cmbBoxItemType.SelectedIndex == 0)
            {
                cmbBoxPlatform.Items.Clear();
                cmbBoxPlatform.Items.Add("Hardcover");
                cmbBoxPlatform.Items.Add("Paperback");
                cmbBoxPlatform.Items.Add("E-Book");
                cmbBoxPlatform.Items.Add("Audio Book");
            }

            // Proceed if user selects Game and add its platforms to the second cmbBox.
            if (cmbBoxItemType.SelectedIndex == 1)
            {
                cmbBoxPlatform.Items.Clear();
                cmbBoxPlatform.Items.Add("Microsoft");
                cmbBoxPlatform.Items.Add("Sony");
                cmbBoxPlatform.Items.Add("Nintendo");
            }

            // Procced if user slects Movie and add its platforms to the second cmbBox.
            if (cmbBoxItemType.SelectedIndex == 2)
            {
                cmbBoxPlatform.Items.Clear();
                cmbBoxPlatform.Items.Add("DVD");
                cmbBoxPlatform.Items.Add("Blu-Ray");
            }
        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear the cmbBox.
            cmbBoxItemType.SelectedIndex = -1;
            cmbBoxPlatform.Items.Clear();

            // Clear the text box.
            txtFindTitle.Clear();

            // Show all rows.
            foreach (DataGridViewRow r in dataGridView.Rows)
            {
                r.Visible = true;
            }

            // Update label.
            NumOfItemLabels();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
