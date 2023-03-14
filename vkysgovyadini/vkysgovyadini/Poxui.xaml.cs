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
    /// Логика взаимодействия для Poxui.xaml
    /// </summary>
    public partial class Poxui : Window
    {
        BaZeEntities3 db = new BaZeEntities3();
        public Poxui()
        {
            InitializeComponent();
            datagrid1.ItemsSource = BaZeEntities3.GetContext().Мероприятия.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Aut mainWindow = new Aut();
            mainWindow.Show();
        }
    }
}
