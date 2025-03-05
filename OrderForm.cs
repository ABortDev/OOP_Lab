using System;
using System.IO;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class OrderForm : Form
    {
        private string currentUser;
        private string selectedBook;

        public OrderForm(string username, string book)
        {
            InitializeComponent();
            currentUser = username;
            selectedBook = book;
            BookTitleLabel.Text = book;
        }

        private void OrderBookConfirmation_Click(object sender, EventArgs e)
        {
            string orderType = OrderType.SelectedItem?.ToString();
            string term = Term.Text.Trim();

            if (string.IsNullOrEmpty(orderType))
            {
                MessageBox.Show("Please select an order type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (orderType == "For home use")
            {
                if (!int.TryParse(term, out int days) || days < 1 || days > 60)
                {
                    MessageBox.Show("Please enter a valid term (1-60 days).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                term = "-"; // Для читання в залі термін не потрібен
            }

            using (StreamWriter sw = new StreamWriter("orders.txt", true))
            {
                sw.WriteLine($"{selectedBook},{currentUser},{orderType},Waiting,{term}");
            }

            MessageBox.Show("Order placed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Закриваємо форму і повідомляємо CatalogForm про успішне замовлення
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
