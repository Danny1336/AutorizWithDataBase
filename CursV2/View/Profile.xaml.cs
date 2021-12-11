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
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
      
        public Profile()
        {
            InitializeComponent();
            try
            {
                FIO.Content = "ФИО: " + Elements11.PPers.FIO;
                Role.Content = "Должность: " + Elements11.PPers.Rols.Name;
                avatar.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(Elements11.PPers.Avatar);
            }
            catch
            {

            }
        }
       
    }
}
