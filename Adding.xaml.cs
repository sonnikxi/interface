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
    /// Логика взаимодействия для Adding.xaml
    /// </summary>
    public partial class Adding : Window
    {
        public Adding()
        {
            InitializeComponent();
        }

        private void adding_Click(object sender, RoutedEventArgs e)
        {
            string txt = text.Text;
            DB.Country country = new DB.Country()
            {
                NameOfCountry = txt
            };
            DB.InformationEntities1.GetContext().Country.Add(country);
            DB.InformationEntities1.GetContext().SaveChanges();

            this.Close();
        }
    }
}
