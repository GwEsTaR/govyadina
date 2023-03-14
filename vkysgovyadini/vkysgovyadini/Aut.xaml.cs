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
    /// Логика взаимодействия для Aut.xaml
    /// </summary>
    public partial class Aut : Window
    {
        bool isLogin =  false;
        public Aut()
        {
            InitializeComponent();
        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            BaZeEntities3 db = new BaZeEntities3();
            string Pochta = MAILR.Text;
            string PAROL = PasswordR.Password;
            
            try 
            { 
                var curUser = db.Пользователи.Where((u) =>u.Пароль == PAROL && u.mail == Pochta).Single();
                var curRolde = db.Роли.Where((u) => u.idРоль == curUser.idРоль).Single();

                if (curRolde.idРоль == 1)
                {
                    MessageBox.Show("Успешно!", $"Привет, {curUser.ФИО}!");


                    this.Hide();
                    oknoorg mainWindow = new oknoorg();
                    mainWindow.Show();
                    
                }
                if (curRolde.idРоль == 2)
                {
                    MessageBox.Show("Успешно!", $"Привет, {curUser.ФИО}!");


                    this.Hide();
                    oknoorg mainWindow = new oknoorg();
                    mainWindow.Show();
                }
                if (curRolde.idРоль == 3)
                {
                    MessageBox.Show("Успешно!", $"Привет, {curUser.ФИО}!");


                    this.Hide();
                    oknoorg mainWindow = new oknoorg();
                    mainWindow.Show();
                }
                if (curRolde.idРоль == 4)
                {
                    MessageBox.Show("Успешно!", $"Привет, {curUser.ФИО}!");


                    this.Hide();
                    oknoorg mainWindow = new oknoorg();
                    mainWindow.Show();
                }


            }
            catch
            {
              MessageBox.Show("Ошибка!", $"Неверный логин или пароль!");
            }
            
        }
    }
}
