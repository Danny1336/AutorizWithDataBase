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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Personal Persona { get; set; }
        Product product = new Product();
        public List<Product> products = new List<Product>();
        MainWindow MW = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
        
        public Menu()
        {
            InitializeComponent();
            if (Elements11.PPers.id_rols == 1)
            {
                ForOrders.Visibility = Visibility.Hidden;
                Workers.Visibility = Visibility.Hidden;
            }
        }

        private void ProductsClick(object sender, RoutedEventArgs e)
        {
            MW.MainFrame.NavigationService.Navigate(new Page1());
        }

        private void CartClick(object sender, RoutedEventArgs e)
        {
          
            MW.MainFrame.NavigationService.Navigate(new Page2());
        }

        private void MyProfile(object sender, RoutedEventArgs e)
        {
            MW.MainFrame.NavigationService.Navigate(new Profile());
        }

        private void Order(object sender, RoutedEventArgs e)
        {
            MW.MainFrame.NavigationService.Navigate(new Orders());
        }

        private void Worker(object sender, RoutedEventArgs e)
        {

            MW.MainFrame.NavigationService.Navigate(new Workers());
        }
    }
}
