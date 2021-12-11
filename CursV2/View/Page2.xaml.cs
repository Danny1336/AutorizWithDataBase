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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        Product product = new Product();
        List<Product> products = new List<Product>();
        object sum = 0;
        public Page2()
        {
            InitializeComponent();
            DGridProducts.ItemsSource = Elements11.Elements;
            products = Elements11.Elements;
     
        }

        private void order1(object sender, RoutedEventArgs e)
        {
         
        }

        private void BtnEdit_Delete(object sender, RoutedEventArgs e)
        {
            int productForRemoving = DGridProducts.SelectedIndex;
            if (MessageBox.Show($"Вы точно хотите удалить?", "Внимание", MessageBoxButton.YesNo,
            MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    products.RemoveAt(productForRemoving);
                    Elements11.Elements = products;
                    MessageBox.Show("Данные удалены!");
                    DGridProducts.Items.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void RemoveCart(object sender, RoutedEventArgs e)
        {
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Order(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page3());
        }
    }
}
