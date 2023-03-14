using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public static Пользователи currUser;
        public static string authCode;
        public static Роли RoleCurr;
        public Auth()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow win = new MainWindow();
            win.Show();
        }

        private void BtnLogClick(object sender, RoutedEventArgs e)
        {

        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            try
            {

                var login = int.Parse(logBox.Text);
                var password = passBox.Text;
                currUser = MeropEntities.getContext().Пользователи.ToList().
                    Where((u) => u.idПользователя == login && u.Пароль == password).Single();
                RoleCurr = MeropEntities.getContext().Роли.ToList().Where((u) => u.idРоль == currUser.IdРоль).Single();

                if (currUser != null)
                {
                    authCode = rnd.Next(1111, 9999).ToString();
                    MessageBox.Show(authCode);
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }
            }
            catch
            {
                MessageBox.Show("Логин и пароль введён неверно");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var code = codeBox.Text;
            if (authCode == code)
            {
                if (RoleCurr.idРоль == 1 && RoleCurr != null)
                {
                    MessageBox.Show("Успех!", $"Привет! Организатор {currUser.ФИО}");
                    this.Hide();
                    Organizator win = new Organizator(currUser);
                    win.Show();
                }
                else if (RoleCurr.idРоль == 2 && RoleCurr != null)
                {
                    MessageBox.Show("Успех!", $"Привет! Модератор {currUser.ФИО}");
                }
                else if (RoleCurr.idРоль == 3 && RoleCurr != null)
                {
                    MessageBox.Show("Успех!", $"Привет! Жюри {currUser.ФИО}");

                }
                else if (RoleCurr.idРоль == 4 && RoleCurr != null)
                {
                    MessageBox.Show("Успех!", $"Привет! Участник {currUser.ФИО}");
                }
                else
                    MessageBox.Show("Отказ");
            }
            else
            {
                MessageBox.Show("Неверный код");
            }
        }
    }
}
