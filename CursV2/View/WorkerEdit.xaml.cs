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
    /// Логика взаимодействия для WorkerEdit.xaml
    /// </summary>
    public partial class WorkerEdit : Page
    {
        private Personal currentPers = new Personal();
        public WorkerEdit(Personal selectetPers)
        {

            InitializeComponent();
            if (selectetPers != null)
                currentPers = selectetPers;
            DataContext = currentPers;
            ComboRols.ItemsSource = BaseContext.GetContext().Rols.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (currentPers.id == 0)
                BaseContext.GetContext().Personal.Add(currentPers);
            try
            {
                currentPers.id_rols = ComboRols.SelectedIndex+1;
                BaseContext.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
