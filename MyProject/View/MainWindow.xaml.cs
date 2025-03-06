using MyProject.View;
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



namespace YourNamespace // Замените на ваше пространство имен
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MainFrame.Navigate(new MainWindow()); // Замените Page1 на вашу начальную страницу
        }


        private void OpenPersonalAccount_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageJoinUser()); // Создайте страницу PersonalAccountPage
        }


        private void Ideas_Click(object sender, RoutedEventArgs e)
        {
            // Логика для кнопки "Идеи для поездок" (например, переход на другую страницу)
            MainFrame.Navigate(new TravelIDeasPage());
        }

        private void Tips_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TutuTipsPage());
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HelpPage());
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Foreground == Brushes.Gray)
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.Black;
                textBox.Opacity = 1.0;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox.Name == "FromTextBox")
                {
                    textBox.Text = "Откуда";
                }
                else if (textBox.Name == "ToTextBox")
                {
                    textBox.Text = "Куда";
                }
                textBox.Foreground = Brushes.Gray;
                textBox.Opacity = 0.5;
            }
        }
    }
}


