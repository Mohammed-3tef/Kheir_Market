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

namespace Super_Market.pages
{
    /// <summary>
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Window
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void customerManagementBtn_Click(object sender, RoutedEventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement();
            customerManagement.Show();
            this.Close();
        }

        private void productManagementBtn_Click(object sender, RoutedEventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.Show();
            this.Close();
        }

        private void logOutBtnBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
