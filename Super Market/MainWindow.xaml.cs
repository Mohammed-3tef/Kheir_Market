using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Super_Market.pages;

namespace Super_Market
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void usernameInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void passwordInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void logInBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            menuPage.Show();
            this.Close();
        }

        private void signUpBtn_Click(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Close();
        }
    }
}