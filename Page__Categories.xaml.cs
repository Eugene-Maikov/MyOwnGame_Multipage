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

namespace MyOwnGame_Multipage
{
    /// <summary>
    /// Логика взаимодействия для Page__Categories.xaml
    /// </summary>
    public partial class Page__Categories : Page
    {
        public Page__Categories()
        {
              InitializeComponent();
        }

        private void Cat1Price200_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FirstQuestion200());
        }

        private void Cat1Price400_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FirstQuestion400());
        }
    }
}
