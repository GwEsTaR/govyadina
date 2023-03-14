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
    /// Логика взаимодействия для detail.xaml
    /// </summary>
    public partial class detail : Window
    {
        private Мероприятия _currentEvent = new Мероприятия();
        public detail(Мероприятия selectedEvent)
        {
            InitializeComponent();
            if (_currentEvent != null)
            {
                _currentEvent = selectedEvent;
                DataContext = _currentEvent;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow win = new MainWindow();
            win.Show();
        }
    }
}
