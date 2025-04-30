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
    /// Interaction logic for ProductManagement.xaml
    /// </summary>
    public partial class ProductManagement : Window
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void backToMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            menuPage.Show();
            this.Close();
        }
    }
}
