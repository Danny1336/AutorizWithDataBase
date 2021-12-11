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

namespace CursV2.View
{
    /// <summary>
    /// Логика взаимодействия для autoriz.xaml
    /// </summary>
    public partial class autoriz : Window
    {
    
        public autoriz()
        {
            InitializeComponent();
            
        }
        private void CloseBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void Drag_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void tb2_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (tb2.Password.Length > 0)
            {
                Watermark.Visibility = Visibility.Collapsed;
            }
            else
            {
                Watermark.Visibility = Visibility.Visible;
            }
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void autoriz1(object sender, RoutedEventArgs e)
        {
            var personal = BaseContext.GetContext().Personal.ToList();
            personal = personal.Where(p => p.login == tb1.Text & p.pass == tb2.Password ).ToList();
            var pers = personal.FirstOrDefault();
            Elements11.PPers = pers; 
            if(pers != null)
            {
              
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                
               
            }
            else
            {
                MessageBox.Show("Неверные данные!");
            }
           
        }
    }
}
