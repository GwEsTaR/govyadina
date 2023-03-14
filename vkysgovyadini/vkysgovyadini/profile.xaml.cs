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
    /// Логика взаимодействия для profile.xaml
    /// </summary>
    public partial class profile : Window
    {
        BaZeEntities3 db = new BaZeEntities3();

        public profile()
        {
            InitializeComponent();

           



        }
        private Пользователи _currentUser = new Пользователи();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegMan mainWindow = new RegMan();
            mainWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegJuriAndModeri mainWindow = new RegJuriAndModeri();
            mainWindow.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            oknoorg mainWindow = new oknoorg();
            mainWindow.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Hide();
            KabanDoska mainWindow = new KabanDoska();
            mainWindow.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MyActivity mainWindow = new MyActivity();
            mainWindow.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Kaban mainWindow = new Kaban();
            mainWindow.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            this.Hide();
            juriANDmoderi mainWindow = new juriANDmoderi();
            mainWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
