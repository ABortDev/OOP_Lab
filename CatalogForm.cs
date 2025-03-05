using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class CatalogForm : Form
    {
        private string currentUser;

        public CatalogForm(string username)
        {
            InitializeComponent();
            currentUser = username;
            LoadBooks();
        }

        private void LoadBooks()
        {
            BookList.Rows.Clear();
            if (!File.Exists("books.txt")) return;

            var orders = File.Exists("orders.txt")
                ? File.ReadAllLines("orders.txt").Select(line => line.Split(','))
                : Enumerable.Empty<string[]>();

            var unavailableBooks = orders
                .Where(o => o[3] == "Waiting" || o[3] == "Valid") // Забороняємо книги в обох статусах
                .Select(o => o[0])
                .ToHashSet();

            foreach (var line in File.ReadLines("books.txt"))
            {
                var parts = line.Split(',');
                if (!unavailableBooks.Contains(parts[0])) // Якщо книга замовлена, вона не додається
                    BookList.Rows.Add(parts);
            }
        }



        private void SearchBook_Click(object sender, EventArgs e)
        {
            string searchQuery = Search.Text.Trim();

            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Enter a book title for search.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (BookList.Rows.Count == 0)
                {
                    MessageBox.Show("No books available in the catalog.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataGridViewRow row in BookList.Rows)
                {
                    if (row.Cells["Book"].Value != null) // Переконуємося, що клітинка не null
                    {
                        string bookTitle = row.Cells["Book"].Value.ToString();

                        if (bookTitle.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            row.Visible = true; // Показуємо рядок, якщо є збіг
                        }
                        else
                        {
                            row.Visible = false; // Приховуємо рядок, якщо нема збігу
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void RequestOrderBook_Click(object sender, EventArgs e)
        {
            if (BookList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedBook = BookList.SelectedRows[0].Cells["Book"].Value.ToString();
            OrderForm orderForm = new OrderForm(currentUser, selectedBook);

            if (orderForm.ShowDialog(this) == DialogResult.OK)
            {
                LoadBooks(); // Оновлюємо список, щоб приховати замовлену книгу
            }
        }



    }
}
