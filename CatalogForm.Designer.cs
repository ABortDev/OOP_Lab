using System;

namespace LibrarySystem
{
    partial class CatalogForm
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
            this.RequestOrderBook = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.SearchBook = new System.Windows.Forms.Button();
            this.EnterBookName = new System.Windows.Forms.Label();
            this.BookList = new System.Windows.Forms.DataGridView();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BookList)).BeginInit();
            this.SuspendLayout();
            // 
            // RequestOrderBook
            // 
            this.RequestOrderBook.Location = new System.Drawing.Point(679, 439);
            this.RequestOrderBook.Name = "RequestOrderBook";
            this.RequestOrderBook.Size = new System.Drawing.Size(218, 53);
            this.RequestOrderBook.TabIndex = 1;
            this.RequestOrderBook.Text = "Order book";
            this.RequestOrderBook.UseVisualStyleBackColor = true;
            this.RequestOrderBook.Click += new System.EventHandler(this.RequestOrderBook_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(222, 450);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(274, 31);
            this.Search.TabIndex = 2;
            // 
            // SearchBook
            // 
            this.SearchBook.Location = new System.Drawing.Point(248, 517);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Size = new System.Drawing.Size(218, 51);
            this.SearchBook.TabIndex = 1;
            this.SearchBook.Text = "Search book";
            this.SearchBook.UseVisualStyleBackColor = true;
            this.SearchBook.Click += new System.EventHandler(this.SearchBook_Click);
            // 
            // EnterBookName
            // 
            this.EnterBookName.AutoSize = true;
            this.EnterBookName.Location = new System.Drawing.Point(81, 454);
            this.EnterBookName.Name = "EnterBookName";
            this.EnterBookName.Size = new System.Drawing.Size(128, 25);
            this.EnterBookName.TabIndex = 3;
            this.EnterBookName.Text = "Enter name:";
            // 
            // BookList
            // 
            this.BookList.BackgroundColor = System.Drawing.Color.LightGray;
            this.BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book,
            this.Author,
            this.Genre});
            this.BookList.GridColor = System.Drawing.Color.Black;
            this.BookList.Location = new System.Drawing.Point(44, 65);
            this.BookList.Name = "BookList";
            this.BookList.RowHeadersWidth = 82;
            this.BookList.Size = new System.Drawing.Size(913, 339);
            this.BookList.TabIndex = 0;
            // 
            // Book
            // 
            this.Book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Book.HeaderText = "Book";
            this.Book.MinimumWidth = 10;
            this.Book.Name = "Book";
            this.Book.Width = 106;
            // 
            // Author
            // 
            this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 10;
            this.Author.Name = "Author";
            this.Author.Width = 120;
            // 
            // Genre
            // 
            this.Genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 10;
            this.Genre.Name = "Genre";
            this.Genre.Width = 116;
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 624);
            this.Controls.Add(this.EnterBookName);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchBook);
            this.Controls.Add(this.RequestOrderBook);
            this.Controls.Add(this.BookList);
            this.Name = "CatalogForm";
            this.Text = "Catalog";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.BookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RequestOrderBook;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button SearchBook;
        private System.Windows.Forms.Label EnterBookName;
        private System.Windows.Forms.DataGridView BookList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
    }
}

