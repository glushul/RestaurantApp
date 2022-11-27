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

namespace RestaurantApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Content = new UI.Pages.MenuPage();
        }

        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new UI.Pages.MenuPage();
        }

        private void ButtonAboutRestaurant_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new UI.Pages.MainPage();
        }
    }
}
