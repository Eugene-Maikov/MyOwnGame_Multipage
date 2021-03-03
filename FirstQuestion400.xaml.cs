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
    /// Логика взаимодействия для FirstQuestion400.xaml
    /// </summary>
    public partial class FirstQuestion400 : Page
    {
        public FirstQuestion400()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page__Categories());
        }

        private void someButton_Click(object sender, RoutedEventArgs e)
        {
            someContent.Visibility = Visibility.Visible;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page__Categories());
        }
    }
}
