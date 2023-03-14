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

namespace demo
{
    /// <summary>
    /// Логика взаимодействия для Organizator.xaml
    /// </summary>
    public partial class Organizator : Window
    {
        private Пользователи _currUser = new Пользователи();
        public Organizator(Пользователи selectedUser)
        {
            InitializeComponent();
            if (_currUser != null)
                _currUser = selectedUser;
            DataContext = _currUser;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            profile win = new profile((sender as Button).DataContext as Пользователи);
            win.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Dobav win = new Dobav();
            win.Show();
        }
    }
}
