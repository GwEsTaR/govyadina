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
    /// Логика взаимодействия для Dobav.xaml
    /// </summary>
    public partial class Dobav : Window
    {
        public static Роли RoleCurr;
        public Dobav()
        {
            InitializeComponent();
            comboEven.ItemsSource = MeropEntities.getContext().Мероприятия.ToList();
            comboNapr.ItemsSource = MeropEntities.getContext().Направление.ToList();
            comboCity.ItemsSource = MeropEntities.getContext().Город.ToList();
            combojuris.ItemsSource = MeropEntities.getContext().Пользователи.ToList();
        }
    }
}
