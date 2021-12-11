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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public List<Product> products = new List<Product>();
        public Page3()
        {
            InitializeComponent();
            products = Elements11.Elements;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OrderEnd(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(1000, 9999);
            Order order = new Order();
            order.id = number;
            order.Customer_name = FIOtxt.Text;
            order.Customer_phone = Phonetxt.Text;
            order.Date_order = DateTime.Now;
            BaseContext.GetContext().Order.Add(order);

            foreach (Product item in products)
            {
                Order_data order_Data = new Order_data();
                order_Data.Id = number;
                order_Data.Id_product = item.Id;
                order_Data.Price = item.Price;
                order_Data.Quantity = item.productCount;
                order_Data.Sum = item.Price * Convert.ToInt32(item.productCount);
                BaseContext.GetContext().Order_data.Add(order_Data);

            }
            MessageBox.Show("Заказ оформлен!");
            BaseContext.GetContext().SaveChanges();
        }
    }
}
