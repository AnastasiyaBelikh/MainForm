using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairIS_1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (chkWindowsAuth.Checked)
            {
                string windowsUserName = Environment.UserName;
                MessageBox.Show($"Авторизация через учетную запись Windows: {windowsUserName}");
                this.Hide();  // Скрыть форму авторизации
                OpenMainForm();  // Открыть главную форму
            }
            else
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Введите имя пользователя и пароль.");
                    return;
                }

                if (username == "admin" && password == "password")
                {
                    MessageBox.Show("Авторизация успешна!");
                    this.Hide();  // Скрыть форму авторизации
                    OpenMainForm();  // Открыть главную форму
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль.");
                }
            }
        }

        private void OpenMainForm()
        {
            frmMain mainForm = new frmMain();
            mainForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PbShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';  // Показываем пароль
        }

        private void PbShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';  // Скрываем пароль
        }
        public string UserName
        {
            get { return txtUsername.Text; }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            // Проверка логина и пароля
            if (txtUsername.Text == "admin" && txtPassword.Text == "1234") // Пример логина и пароля
            {
                this.DialogResult = DialogResult.OK; // Успешный вход
                this.Close(); // Закрываем форму авторизации
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}