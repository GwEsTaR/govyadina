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
    /// Логика взаимодействия для kaban.xaml
    /// </summary>
    public partial class kaban : Window
    {
        private object _captured;
        private Point _capturePosition;
        public kaban()
        {
            InitializeComponent();
            Grida.PreviewMouseMove += OnMouseMove;
            Grida.PreviewMouseLeftButtonUp += OnMouseUp;
            Grida.PreviewMouseLeftButtonDown += OnMouseDown;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _captured = e.Source as Button;
            _capturePosition = e.GetPosition(btn);
        }

        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _captured = null;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (_captured != null)
            {
                var pos = e.GetPosition(Grida);
                pos.Offset(-_capturePosition.X, -_capturePosition.Y);
                btn.Margin = new Thickness(pos.X, pos.Y, 0, 0);
            }
        }

    }
}
