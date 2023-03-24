namespace Business_Software
{
    partial class ItemPropertyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblItemType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.lblItemInfo1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtItemInfo1 = new System.Windows.Forms.TextBox();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.txtItemInfo2 = new System.Windows.Forms.TextBox();
            this.lblItemInfo2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbBoxItemType = new System.Windows.Forms.ComboBox();
            this.cmbBoxPlatform = new System.Windows.Forms.ComboBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemType.Location = new System.Drawing.Point(32, 72);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(93, 24);
            this.lblItemType.TabIndex = 0;
            this.lblItemType.Text = "Item Type";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(32, 112);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 24);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(32, 145);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(47, 24);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(32, 179);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(63, 24);
            this.lblGenre.TabIndex = 5;
            this.lblGenre.Text = "Genre";
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.AutoSize = true;
            this.lblReleaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseYear.Location = new System.Drawing.Point(32, 216);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(123, 24);
            this.lblReleaseYear.TabIndex = 7;
            this.lblReleaseYear.Text = "Release Year";
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatform.Location = new System.Drawing.Point(32, 256);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(77, 24);
            this.lblPlatform.TabIndex = 8;
            this.lblPlatform.Text = "Platform";
            // 
            // lblItemInfo1
            // 
            this.lblItemInfo1.AutoSize = true;
            this.lblItemInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemInfo1.Location = new System.Drawing.Point(32, 296);
            this.lblItemInfo1.Name = "lblItemInfo1";
            this.lblItemInfo1.Size = new System.Drawing.Size(95, 24);
            this.lblItemInfo1.TabIndex = 9;
            this.lblItemInfo1.Text = "Item Info 1";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(184, 112);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(240, 27);
            this.txtTitle.TabIndex = 10;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(184, 144);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(240, 27);
            this.txtCost.TabIndex = 11;
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(184, 176);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(240, 27);
            this.txtGenre.TabIndex = 12;
            // 
            // txtItemInfo1
            // 
            this.txtItemInfo1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemInfo1.Location = new System.Drawing.Point(184, 296);
            this.txtItemInfo1.Name = "txtItemInfo1";
            this.txtItemInfo1.Size = new System.Drawing.Size(240, 27);
            this.txtItemInfo1.TabIndex = 13;
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReleaseYear.Location = new System.Drawing.Point(184, 216);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(240, 27);
            this.txtReleaseYear.TabIndex = 14;
            // 
            // txtItemInfo2
            // 
            this.txtItemInfo2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemInfo2.Location = new System.Drawing.Point(184, 336);
            this.txtItemInfo2.Name = "txtItemInfo2";
            this.txtItemInfo2.Size = new System.Drawing.Size(240, 27);
            this.txtItemInfo2.TabIndex = 16;
            // 
            // lblItemInfo2
            // 
            this.lblItemInfo2.AutoSize = true;
            this.lblItemInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemInfo2.Location = new System.Drawing.Point(32, 336);
            this.lblItemInfo2.Name = "lblItemInfo2";
            this.lblItemInfo2.Size = new System.Drawing.Size(95, 24);
            this.lblItemInfo2.TabIndex = 17;
            this.lblItemInfo2.Text = "Item Info 2";
            this.lblItemInfo2.Click += new System.EventHandler(this.lblItemInfo2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(312, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 32);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbBoxItemType
            // 
            this.cmbBoxItemType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxItemType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxItemType.FormattingEnabled = true;
            this.cmbBoxItemType.Items.AddRange(new object[] {
            "Book",
            "Game",
            "Movie"});
            this.cmbBoxItemType.Location = new System.Drawing.Point(184, 72);
            this.cmbBoxItemType.Name = "cmbBoxItemType";
            this.cmbBoxItemType.Size = new System.Drawing.Size(240, 29);
            this.cmbBoxItemType.TabIndex = 19;
            this.cmbBoxItemType.SelectedIndexChanged += new System.EventHandler(this.cmbBoxItemType_SelectedIndexChanged);
            // 
            // cmbBoxPlatform
            // 
            this.cmbBoxPlatform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxPlatform.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxPlatform.FormattingEnabled = true;
            this.cmbBoxPlatform.Items.AddRange(new object[] {
            "Book",
            "Game",
            "Movie"});
            this.cmbBoxPlatform.Location = new System.Drawing.Point(184, 256);
            this.cmbBoxPlatform.Name = "cmbBoxPlatform";
            this.cmbBoxPlatform.Size = new System.Drawing.Size(240, 29);
            this.cmbBoxPlatform.TabIndex = 20;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(168, 16);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(123, 25);
            this.lblFormTitle.TabIndex = 21;
            this.lblFormTitle.Text = "Title Label";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(160, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 32);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(8, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 32);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(8, 400);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 32);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ItemPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(448, 483);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.cmbBoxPlatform);
            this.Controls.Add(this.cmbBoxItemType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblItemInfo2);
            this.Controls.Add(this.txtItemInfo2);
            this.Controls.Add(this.txtReleaseYear);
            this.Controls.Add(this.txtItemInfo1);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblItemInfo1);
            this.Controls.Add(this.lblPlatform);
            this.Controls.Add(this.lblReleaseYear);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblItemType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ItemPropertyForm";
            this.Text = "Item Property Form";
            this.Load += new System.EventHandler(this.ItemPropertyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Label lblItemInfo1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtItemInfo1;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.TextBox txtItemInfo2;
        private System.Windows.Forms.Label lblItemInfo2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbBoxItemType;
        private System.Windows.Forms.ComboBox cmbBoxPlatform;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
    }
}