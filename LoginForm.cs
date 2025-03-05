using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string username = Username.Text.Trim();
            string password = Password.Text.Trim();
            string selectedUserType = UserType.Text.Trim(); // Отримуємо вибраний тип користувача

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(selectedUserType))
            {
                MessageBox.Show("Please enter username, password and select user type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists("users.txt"))
            {
                MessageBox.Show("User database not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] users = File.ReadAllLines("users.txt");

            var user = users
                .Select(u => u.Split(','))
                .FirstOrDefault(u => u.Length >= 4 && u[0] == username && u[1] == password);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userTypeFromFile = user[2].Trim(); // Тип акаунта з файлу
            string status = user[3].Trim();

            if (status == "Blocked")
            {
                MessageBox.Show("Your account is blocked.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Перевіряємо, чи вибрана роль збігається з тим, що в файлі
            if (userTypeFromFile != selectedUserType)
            {
                MessageBox.Show($"You selected the wrong user type! Your actual role is {userTypeFromFile}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Відкриваємо потрібну форму
            Form nextForm = null;

            if (userTypeFromFile == "I'm reader")
            {
                nextForm = new CatalogForm(username);
            }
            else if (userTypeFromFile == "I'm librarian")
            {
                nextForm = new ManageOrderForm();
            }
            else
            {
                MessageBox.Show($"Unknown user type: {userTypeFromFile}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Закриваємо поточну форму і відкриваємо нову
            nextForm.FormClosed += (s, args) => this.Show();
            nextForm.Show();
            this.Hide();
        }

        private void RegisterNewReader_Click(object sender, EventArgs e)
        {
            RegisterForm registrationForm = new RegisterForm();
            registrationForm.ShowDialog();
        }
    }
}
