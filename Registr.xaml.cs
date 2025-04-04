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
    /// Логика взаимодействия для Registr.xaml
    /// </summary>
    public partial class Registr : Window
    {
        public Registr()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
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

                DB.Users users = new DB.Users()
                {
                    Id_role = 1,
                    Id_country = 1,
                    Id_gender = 1,
                    FirstName = Name.Text,
                    Login = loginText.Text,
                    Password = passText.Password
                };

                DB.InformationEntities2.GetContext().Users.Add(users);
                DB.InformationEntities2.GetContext().SaveChanges();
                MessageBox.Show("Регистрация успешна");
                Login log = new Login();
                this.Hide();
                log.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла Ошибка" + ex);
            }
        }
    }
}
