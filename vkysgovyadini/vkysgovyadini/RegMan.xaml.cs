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

namespace vkysgovyadini
{
    /// <summary>
    /// Логика взаимодействия для RegMan.xaml
    /// </summary>
    public partial class RegMan : Window
    {
        public RegMan()
        {
            InitializeComponent();
        }

        private Пользователи _currentUser = new Пользователи();
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BaZeEntities3.GetContext().Пользователи.Remove(_currentUser);
            BaZeEntities3.GetContext().SaveChanges();

            this.Hide();
            profile profile = new profile();
            profile.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            BaZeEntities3.GetContext().Пользователи.Add(_currentUser);
            BaZeEntities3.GetContext().SaveChanges();
            var idnumber = _currentUser.idПользователя;
            IdnumberField.Text = idnumber.ToString();

        }
    }
}
