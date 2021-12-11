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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        Product currentProduct = new Product();
        List<Product> product = new List<Product>();
    
    
        public Page1()
        {
            InitializeComponent();
            var currentProducts = BaseContext.GetContext().Product.ToList();
            var alltypes = BaseContext.GetContext().Type_of_product.ToList();
            alltypes.Insert(0, new Type_of_product { Name = "Все типы" });
            ComboType.ItemsSource = alltypes;
            ComboType.SelectedIndex = 0;
            ListProduct.ItemsSource = currentProducts;
            UpdateProduct();
        }
        private void UpdateProduct()
        {
            var alltypes = BaseContext.GetContext().Type_of_product.ToList();
            var currentProducts = BaseContext.GetContext().Product.ToList();
            currentProducts = currentProducts.Where(p => p.Name.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
            ListProduct.ItemsSource = currentProducts;
        }
        private void TBoxSearch2(object sender, TextChangedEventArgs e)
        {
            UpdateProduct();
        }

        private void ComboType_Selected(object sender, SelectionChangedEventArgs e)
        {
            var currentProducts = BaseContext.GetContext().Product.ToList();
            if(ComboType.SelectedItem != null)
            {
                if(ComboType.SelectedIndex == 0)
                {
                    ListProduct.ItemsSource = BaseContext.GetContext().Product.ToList();
                }
                else
                {
                    currentProducts = currentProducts.Where(p => p.Type_of_product == ComboType.SelectedItem).ToList();
                    ListProduct.ItemsSource = currentProducts;
                }
            }
            
        }

        private void Buy_BtnClick(object sender, RoutedEventArgs e)
        {
            currentProduct = (sender as Button).DataContext as Product;
            if (currentProduct.productCount != null)
            {
                if (currentProduct.Quantity > Convert.ToInt32(currentProduct.productCount))
                {
                    product.Add(currentProduct);
                    Page2 page2 = new Page2();
                    Elements11.Elements= product;
                    MessageBox.Show("Товар " + currentProduct.Name + " добавлен в корзину");
                }
                else
                {
                    MessageBox.Show("Количество превышает");
                }
            }

        }
    }
}
