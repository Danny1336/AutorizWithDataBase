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
    /// Логика взаимодействия для Workers.xaml
    /// </summary>
    public partial class Workers : Page
    {
        public Workers()
        {
            InitializeComponent();
            DGridWorker.ItemsSource = BaseContext.GetContext().Personal.ToList();
        }

        private void BtnEdit(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new WorkerEdit((sender as Button).DataContext as Personal));
        }

        private void Order(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new WorkerEdit((sender as Button).DataContext as Personal));
        }
    }
}
