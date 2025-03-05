using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class RegisterForm : Form
    {
        private const string UsersFile = "users.txt"; 

        public RegisterForm()
        {
            InitializeComponent();
            Register.Click += new EventHandler(Register_Click); // Обробник події кнопки Register
        }

        private void Register_Click(object sender, EventArgs e)
        {
            // Отримуємо текст з полів для введення імені користувача та пароля
            string username = Username.Text.Trim();
            string password = Password.Text.Trim();

            // Перевіряємо, чи всі поля заповнені
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                // Якщо ні, показуємо повідомлення про помилку
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Перевіряємо, чи вже існує користувач з таким іменем
            if (UserExists(username))
            {
                // Якщо так, показуємо повідомлення про помилку
                MessageBox.Show("Ім'я користувача вже існує. Будь ласка, виберіть інше ім'я.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Реєструємо нового користувача
            RegisterNewUser(username, password);
            // Показуємо повідомлення про успішну реєстрацію
            MessageBox.Show("Реєстрація успішна!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Ховаємо поточну форму та відкриваємо форму входу
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            // Закриваємо поточну форму після закриття форми входу
            this.Close();
        }

        private bool UserExists(string username)
        {
            if (!File.Exists(UsersFile)) return false;

            string[] users = File.ReadAllLines(UsersFile);
            foreach (string user in users)
            {
                string[] parts = user.Split(',');
                string storedUsername = parts[0].Trim();

                if (storedUsername.Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void RegisterNewUser(string username, string password)
        {
            using (StreamWriter writer = new StreamWriter(UsersFile, true))
            {
                writer.WriteLine($"{username},{password},I'm reader,Active");
            }
        }
    }
}
