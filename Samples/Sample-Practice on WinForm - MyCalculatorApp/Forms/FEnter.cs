using MyApp.Controllers;
using MyApp.Services;

namespace MyApp.Forms
{
    public partial class FEnter : Form
    {
        private UsersController _usersController;

        public FEnter()
        {
            InitializeComponent();

            UserStorageService userStorageService = new("users.txt");
            _usersController = new(userStorageService);
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            // 1) Проверка ввода 
            if(textBox_login.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Не все поля введены!", "Ошибка!");
                return;
            }

            // 2) Проверка логина и пароля
            bool isEntered = _usersController.Enter(
                textBox_login.Text,
                textBox_password.Text);

            // 3) Если есть совпадение -> вход
            if (isEntered)
            {
                if(_usersController.EnteredUser.Role.ToLower() == "user")
                {
                    MessageBox.Show("Вошел пользователь");
                }
                else
                {
                    MessageBox.Show("Вошел админ");
                }
            }

            // 4) Иначе, сообщить об не входа
            else
            {
                MessageBox.Show("Логин или пароль не совпали!");
            }
        }

        private void linkLabel_reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRegistration form = new();
            form.Show();
            this.Hide();
        }
    }
}
