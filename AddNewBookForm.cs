using System;
using System.IO;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class AddNewBookForm : Form
    {
        public AddNewBookForm()
        {
            InitializeComponent();
        }

        private void SaveNewBook_Click(object sender, EventArgs e)
        {
            string bookTitle = Book.Text.Trim();
            string author = Author.Text.Trim();
            string genre = Genre.Text.Trim();

            if (string.IsNullOrEmpty(bookTitle) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(genre))
            {
                MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Додаємо нову книгу у файл
            using (StreamWriter sw = new StreamWriter("books.txt", true))
            {
                if (new FileInfo("books.txt").Length > 0) // Перевіряємо, чи файл не пустий
                {
                    sw.WriteLine(); // Додаємо новий рядок перед записом
                }
                sw.Write($"{bookTitle},{author},{genre}");
            }


            MessageBox.Show("New book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
