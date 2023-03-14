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
    /// Логика взаимодействия для profile.xaml
    /// </summary>
    public partial class profile : Window
    {
        private Пользователи _currUser = new Пользователи();
        public profile(Пользователи selectedUser)
        {
            InitializeComponent();
            if (_currUser != null)
                _currUser = selectedUser;
            DataContext = _currUser;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currUser.Пароль))
                errors.AppendLine("Укажите пароль");
            if (password2.Text != _currUser.Пароль)
                errors.AppendLine("Повторите пароль");
            if (chek1.IsChecked == false)
                errors.AppendLine("Установите флаг");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            else
            {
                MeropEntities.getContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
