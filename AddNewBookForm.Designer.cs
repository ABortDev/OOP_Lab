namespace LibrarySystem
{
    partial class AddNewBookForm
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
            this.Book = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.TextBox();
            this.BookNameLable = new System.Windows.Forms.Label();
            this.AuthorNameLable = new System.Windows.Forms.Label();
            this.GenreLable = new System.Windows.Forms.Label();
            this.SaveNewBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Book
            // 
            this.Book.Location = new System.Drawing.Point(111, 51);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(156, 31);
            this.Book.TabIndex = 0;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(381, 51);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(156, 31);
            this.Author.TabIndex = 0;
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(654, 51);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(156, 31);
            this.Genre.TabIndex = 0;
            // 
            // BookNameLable
            // 
            this.BookNameLable.AutoSize = true;
            this.BookNameLable.Location = new System.Drawing.Point(41, 54);
            this.BookNameLable.Name = "BookNameLable";
            this.BookNameLable.Size = new System.Drawing.Size(67, 25);
            this.BookNameLable.TabIndex = 1;
            this.BookNameLable.Text = "Book:";
            // 
            // AuthorNameLable
            // 
            this.AuthorNameLable.AutoSize = true;
            this.AuthorNameLable.Location = new System.Drawing.Point(294, 54);
            this.AuthorNameLable.Name = "AuthorNameLable";
            this.AuthorNameLable.Size = new System.Drawing.Size(81, 25);
            this.AuthorNameLable.TabIndex = 1;
            this.AuthorNameLable.Text = "Author:";
            // 
            // GenreLable
            // 
            this.GenreLable.AutoSize = true;
            this.GenreLable.Location = new System.Drawing.Point(569, 54);
            this.GenreLable.Name = "GenreLable";
            this.GenreLable.Size = new System.Drawing.Size(77, 25);
            this.GenreLable.TabIndex = 1;
            this.GenreLable.Text = "Genre:";
            // 
            // SaveNewBook
            // 
            this.SaveNewBook.Location = new System.Drawing.Point(359, 151);
            this.SaveNewBook.Name = "SaveNewBook";
            this.SaveNewBook.Size = new System.Drawing.Size(137, 42);
            this.SaveNewBook.TabIndex = 2;
            this.SaveNewBook.Text = "Save";
            this.SaveNewBook.UseVisualStyleBackColor = true;
            this.SaveNewBook.Click += new System.EventHandler(this.SaveNewBook_Click);
            // 
            // AddNewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 253);
            this.Controls.Add(this.SaveNewBook);
            this.Controls.Add(this.GenreLable);
            this.Controls.Add(this.AuthorNameLable);
            this.Controls.Add(this.BookNameLable);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Book);
            this.Name = "AddNewBookForm";
            this.Text = "Add new book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Book;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.Label BookNameLable;
        private System.Windows.Forms.Label AuthorNameLable;
        private System.Windows.Forms.Label GenreLable;
        private System.Windows.Forms.Button SaveNewBook;
    }
}