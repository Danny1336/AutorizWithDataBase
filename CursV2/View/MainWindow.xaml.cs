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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CursV2.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        List<Product> Product = new List<Product>();
        Page2 page2 = new Page2();
       
        public MainWindow()
        {
            InitializeComponent();
            Manager.ButtonFrame = ButtonFrame;
            Manager.MainFrame = MainFrame;
            Border1.MouseLeftButtonDown += new MouseButtonEventHandler(layoutRoot_MouseLeftButtonDown);
        }
        void layoutRoot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ProductsClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page1());
        }

        private void CartClick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(page2);

        }

        private void Exit(object sender, RoutedEventArgs e)
        {       
            autoriz autoriz = new autoriz();
            autoriz.Show();
            this.Close();
        }
    }
}
