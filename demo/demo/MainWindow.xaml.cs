using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace demo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DGridМероприятия.ItemsSource = MeropEntities.getContext().Мероприятия.ToList();
        }

        private void BtnView_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            detail f = new detail((sender as Button).DataContext as Мероприятия);
            f.Show();
        }

        private void BtnLogClick(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Auth win = new Auth();
            win.Show();
        }
    }
}
