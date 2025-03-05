using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LibrarySystem
{
    public partial class ManageBookListForm : Form
    {
        public ManageBookListForm()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            BookList.Rows.Clear();
            if (!File.Exists("books.txt")) return;

            foreach (var line in File.ReadLines("books.txt"))
            {
                var parts = line.Split(',');
                if (parts.Length == 3) // Перевіряємо, щоб у рядку було три елементи (назва, автор, жанр)
                {
                    BookList.Rows.Add(parts);
                }
            }
        }

        private void AddNewBook_Click(object sender, EventArgs e)
        {
            AddNewBookForm addNewBookForm = new AddNewBookForm();
            if (addNewBookForm.ShowDialog() == DialogResult.OK)
            {
                LoadBooks(); // Оновлюємо список книг після додавання
            }
        }

        private void DeleteBook_Click(object sender, EventArgs e)
        {
            if (BookList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bookToDelete = BookList.SelectedRows[0].Cells["Book"].Value?.ToString();
            string authorToDelete = BookList.SelectedRows[0].Cells["Author"].Value?.ToString();
            string genreToDelete = BookList.SelectedRows[0].Cells["Genre"].Value?.ToString();

            if (string.IsNullOrEmpty(bookToDelete) || string.IsNullOrEmpty(authorToDelete) || string.IsNullOrEmpty(genreToDelete))
            {
                MessageBox.Show("Invalid book selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Видаляємо книгу з таблиці
            BookList.Rows.RemoveAt(BookList.SelectedRows[0].Index);

            // Читаємо всі рядки з файлу
            List<string> books = File.ReadAllLines("books.txt").ToList();

            // Видаляємо тільки точний збіг (повний рядок)
            books.RemoveAll(line => line == $"{bookToDelete},{authorToDelete},{genreToDelete}");

            // Записуємо оновлений список книг
            File.WriteAllLines("books.txt", books);

            MessageBox.Show($"{bookToDelete} has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
