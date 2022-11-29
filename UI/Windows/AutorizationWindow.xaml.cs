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
using System.Windows.Shapes;

namespace RestaurantApp.UI.Windows
{
    /// <summary>
    /// Логика взаимодействия для AutorizationWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : Window
    {
        public AutorizationWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(loginTextBox.Text == "admin" && passwordPasswordBox.Password == "admin")
            {
                this.Hide();
                MainWindow mainWindow = new MainWindow("admin");
                mainWindow.Show();
            }
            else if (loginTextBox.Text == "client" && passwordPasswordBox.Password == "client")
            {
                this.Hide();
                MainWindow mainWindow = new MainWindow("client");
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Пароль и логин введены неправильно!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
