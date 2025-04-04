using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Interface
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(loginText.Text))
                {
                    MessageBox.Show("Заполните Логин");
                    return;
                }
                else if (string.IsNullOrEmpty(passText.Password))
                {
                    MessageBox.Show("Заполните Пароль");
                    return;
                }

                if (DB.InformationEntities2.GetContext().Users.
                    Any(d => d.Login == loginText.Text && d.Password == passText.Password))
                {
                    MessageBox.Show("Авторизация выполнена!");

                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла Ошибка");

            }
        }
    }
}
