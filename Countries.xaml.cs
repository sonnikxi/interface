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
    /// Логика взаимодействия для Countries.xaml
    /// </summary>
    public partial class Countries : Window
    {
        public Countries()
        {
            InitializeComponent();
            Fill();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var deletedcountry = data.SelectedItem as DB.Country;

                DB.InformationEntities1.GetContext().Country.Remove(deletedcountry);
                DB.InformationEntities1.GetContext().SaveChanges();
                Fill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла Ошибка" + ex);
            }
        }

        public void Fill()
        {
            data.ItemsSource = DB.InformationEntities1.GetContext().Country.ToList();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
