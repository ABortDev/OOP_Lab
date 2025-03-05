namespace LibrarySystem
{
    partial class ManageBookListForm
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
            this.BookList = new System.Windows.Forms.DataGridView();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddNewBook = new System.Windows.Forms.Button();
            this.DeleteBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookList)).BeginInit();
            this.SuspendLayout();
            // 
            // BookList
            // 
            this.BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book,
            this.Author,
            this.Genre});
            this.BookList.Location = new System.Drawing.Point(61, 34);
            this.BookList.Name = "BookList";
            this.BookList.RowHeadersWidth = 82;
            this.BookList.RowTemplate.Height = 33;
            this.BookList.Size = new System.Drawing.Size(1136, 341);
            this.BookList.TabIndex = 0;
            // 
            // Book
            // 
            this.Book.HeaderText = "Book";
            this.Book.MinimumWidth = 10;
            this.Book.Name = "Book";
            this.Book.Width = 200;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 10;
            this.Author.Name = "Author";
            this.Author.Width = 200;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 10;
            this.Genre.Name = "Genre";
            this.Genre.Width = 200;
            // 
            // AddNewBook
            // 
            this.AddNewBook.Location = new System.Drawing.Point(367, 440);
            this.AddNewBook.Name = "AddNewBook";
            this.AddNewBook.Size = new System.Drawing.Size(216, 50);
            this.AddNewBook.TabIndex = 1;
            this.AddNewBook.Text = "Add new book";
            this.AddNewBook.UseVisualStyleBackColor = true;
            this.AddNewBook.Click += new System.EventHandler(this.AddNewBook_Click);
            // 
            // DeleteBook
            // 
            this.DeleteBook.Location = new System.Drawing.Point(670, 440);
            this.DeleteBook.Name = "DeleteBook";
            this.DeleteBook.Size = new System.Drawing.Size(216, 50);
            this.DeleteBook.TabIndex = 1;
            this.DeleteBook.Text = "Delete book";
            this.DeleteBook.UseVisualStyleBackColor = true;
            this.DeleteBook.Click += new System.EventHandler(this.DeleteBook_Click);
            // 
            // ManageBookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 553);
            this.Controls.Add(this.DeleteBook);
            this.Controls.Add(this.AddNewBook);
            this.Controls.Add(this.BookList);
            this.Name = "ManageBookListForm";
            this.Text = "Manage book list";
            ((System.ComponentModel.ISupportInitialize)(this.BookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BookList;
        private System.Windows.Forms.Button AddNewBook;
        private System.Windows.Forms.Button DeleteBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
    }
}