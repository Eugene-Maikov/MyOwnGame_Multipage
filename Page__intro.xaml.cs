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
    /// Логика взаимодействия для Page__intro.xaml
    /// </summary>
    public partial class Page__intro : Page
    {
        public Page__intro()
        {
            InitializeComponent();
        }

        private void btnIntroName_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page__Categories());
        }
    }
}
