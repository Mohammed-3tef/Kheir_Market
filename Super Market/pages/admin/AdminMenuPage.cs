using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market.pages
{
    public partial class AdminMenuPage : Form
    {
        private MainWindow mainWindow;
        public AdminMenuPage(MainWindow mainWindow = null)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.Show();
            this.Close();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement();
            customerManagement.Show();
            this.Close();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            if (this.mainWindow == null) this.mainWindow = new MainWindow();
            this.mainWindow.Show();
            this.Close();
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            CategoryManagement categoryManagement = new CategoryManagement();
            categoryManagement.Show();
            this.Close();
        }
    }
}
