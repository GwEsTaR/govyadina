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
    /// Логика взаимодействия для KabanDoska.xaml
    /// </summary>
    public partial class KabanDoska : Window
    {
        public KabanDoska()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            profile profile = new profile();
            profile.Show();
        }

        private void BtnExportToPDF_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Kaban profile = new Kaban();
            profile.Show();
        }
    }
}
