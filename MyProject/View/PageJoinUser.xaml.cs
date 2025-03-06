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
using YourNamespace;

namespace MyProject.View
{
    /// <summary>
    /// Логика взаимодействия для PageRegistr.xaml
    /// </summary>
    public partial class PageJoinUser : Page
    {
        public PageJoinUser()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // if (есть ли такой пользователь в базе)

            NavigationService.Navigate(new PageClient());






        }
    }
}
