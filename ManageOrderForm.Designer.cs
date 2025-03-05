namespace LibrarySystem
{
    partial class ManageOrderForm
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
            this.IssueBook = new System.Windows.Forms.Button();
            this.BlockReader = new System.Windows.Forms.Button();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.ManageBookList = new System.Windows.Forms.Button();
            this.OrderList = new System.Windows.Forms.DataGridView();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // IssueBook
            // 
            this.IssueBook.Location = new System.Drawing.Point(156, 378);
            this.IssueBook.Name = "IssueBook";
            this.IssueBook.Size = new System.Drawing.Size(156, 54);
            this.IssueBook.TabIndex = 1;
            this.IssueBook.Text = "Issue book";
            this.IssueBook.UseVisualStyleBackColor = true;
            this.IssueBook.Click += new System.EventHandler(this.IssueBook_Click);
            // 
            // BlockReader
            // 
            this.BlockReader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BlockReader.Location = new System.Drawing.Point(1133, 378);
            this.BlockReader.Name = "BlockReader";
            this.BlockReader.Size = new System.Drawing.Size(156, 54);
            this.BlockReader.TabIndex = 1;
            this.BlockReader.Text = "Block reader";
            this.BlockReader.UseVisualStyleBackColor = true;
            this.BlockReader.Click += new System.EventHandler(this.BlockReader_Click);
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Location = new System.Drawing.Point(343, 378);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(156, 54);
            this.DeleteOrder.TabIndex = 1;
            this.DeleteOrder.Text = "Delete order";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
            // 
            // ManageBookList
            // 
            this.ManageBookList.Location = new System.Drawing.Point(698, 378);
            this.ManageBookList.Name = "ManageBookList";
            this.ManageBookList.Size = new System.Drawing.Size(194, 54);
            this.ManageBookList.TabIndex = 1;
            this.ManageBookList.Text = "Manage book list";
            this.ManageBookList.UseVisualStyleBackColor = true;
            this.ManageBookList.Click += new System.EventHandler(this.ManageBookList_Click);
            // 
            // OrderList
            // 
            this.OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book,
            this.Reader,
            this.Type,
            this.Validation});
            this.OrderList.Location = new System.Drawing.Point(16, 55);
            this.OrderList.Name = "OrderList";
            this.OrderList.RowHeadersWidth = 82;
            this.OrderList.RowTemplate.Height = 33;
            this.OrderList.Size = new System.Drawing.Size(1439, 260);
            this.OrderList.TabIndex = 0;
            // 
            // Book
            // 
            this.Book.HeaderText = "Book";
            this.Book.MinimumWidth = 10;
            this.Book.Name = "Book";
            this.Book.Width = 200;
            // 
            // Reader
            // 
            this.Reader.HeaderText = "Reader";
            this.Reader.MinimumWidth = 10;
            this.Reader.Name = "Reader";
            this.Reader.Width = 200;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 10;
            this.Type.Name = "Type";
            this.Type.Width = 200;
            // 
            // Validation
            // 
            this.Validation.HeaderText = "Validation";
            this.Validation.Items.AddRange(new object[] {
            "Waiting",
            "Valid",
            "Expired",
            "Finished"});
            this.Validation.MinimumWidth = 10;
            this.Validation.Name = "Validation";
            this.Validation.Width = 200;
            // 
            // ManageOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 501);
            this.Controls.Add(this.BlockReader);
            this.Controls.Add(this.ManageBookList);
            this.Controls.Add(this.DeleteOrder);
            this.Controls.Add(this.IssueBook);
            this.Controls.Add(this.OrderList);
            this.Name = "ManageOrderForm";
            this.Text = "Manage orders";
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button IssueBook;
        private System.Windows.Forms.Button BlockReader;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.Button ManageBookList;
        private System.Windows.Forms.DataGridView OrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewComboBoxColumn Validation;
    }
}