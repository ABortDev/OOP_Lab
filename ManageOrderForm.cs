using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class ManageOrderForm : Form
    {
        public ManageOrderForm()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            OrderList.Rows.Clear();
            if (!File.Exists("orders.txt")) return;

            foreach (var line in File.ReadLines("orders.txt"))
            {
                OrderList.Rows.Add(line.Split(','));
            }
        }

        private void IssueBook_Click(object sender, EventArgs e)
        {
            if (OrderList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to validate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = OrderList.SelectedRows[0];
            if (row.Cells["Validation"].Value.ToString() != "Waiting")
            {
                MessageBox.Show("Only 'Waiting' orders can be validated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            row.Cells["Validation"].Value = "Valid";
            SaveOrders();
            MessageBox.Show("Order validated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            if (OrderList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = OrderList.SelectedRows[0];
            string bookTitle = row.Cells["Book"].Value.ToString();

            // Видаляємо замовлення з orders.txt
            var orders = File.ReadAllLines("orders.txt").Where(line => !line.StartsWith(bookTitle + ",")).ToList();
            File.WriteAllLines("orders.txt", orders);

            // Видаляємо рядок із таблиці замовлень
            OrderList.Rows.RemoveAt(row.Index);

            // Оновлюємо каталог, щоб книга знову стала видимою
            MessageBox.Show($"Order deleted. {bookTitle} is now available in the catalog.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void ReturnBookToCatalog(string bookTitle)
        {
            using (StreamWriter sw = new StreamWriter("books.txt", true))
            {
                sw.WriteLine(bookTitle); // Додаємо книгу назад у каталог
            }
        }


        private void BlockReader_Click(object sender, EventArgs e)
        {
            if (OrderList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to block the reader.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reader = OrderList.SelectedRows[0].Cells["Reader"].Value.ToString();
            string[] users = File.ReadAllLines("users.txt");
            for (int i = 0; i < users.Length; i++)
            {
                string[] parts = users[i].Split(',');
                if (parts[0] == reader)
                {
                    parts[3] = "Blocked";
                    users[i] = string.Join(",", parts);
                    break;
                }
            }

            File.WriteAllLines("users.txt", users);
            MessageBox.Show($"Reader {reader} has been blocked.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveOrders()
        {
            using (StreamWriter sw = new StreamWriter("orders.txt"))
            {
                foreach (DataGridViewRow row in OrderList.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        sw.WriteLine($"{row.Cells["Book"].Value},{row.Cells["Reader"].Value},{row.Cells["Type"].Value},{row.Cells["Validation"].Value}");
                    }
                }
            }
        }

        private void ManageBookList_Click(object sender, EventArgs e)
        {
            ManageBookListForm manageBookListForm = new ManageBookListForm();
            manageBookListForm.ShowDialog();
            LoadOrders(); // Оновлення після закриття
        }


    }
}
