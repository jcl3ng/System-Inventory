using System;
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
    // This class extends from the Form.
    public partial class ConfirmationForm : Form
    {
        // Initialize a private bool variable as false.
        private bool isOk = false;

        // This constructor reads the message from the mainform.
        public ConfirmationForm(string formTitle)
        {
            InitializeComponent();
            this.isOk = false;
            lblTitle.Text = formTitle;
        }

        /// <summary>
        /// Gets a value indicating whether the button was clicked.
        /// </summary>
        public bool IsOk 
        {
            get
            {
                return this.isOk;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Get true if ok was clicked.
            btnOk.DialogResult = DialogResult.OK;
            this.isOk = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            /// Get false if cancel was clicked
            btnCancel.DialogResult = DialogResult.Cancel;
            this.isOk = false;
            this.Close();
        }
    }
}
