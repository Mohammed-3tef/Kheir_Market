using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market.pages.customer
{
    public partial class OrderManagement : Form
    {
        private MainWindow mainWindow;

        public OrderManagement(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            CustomerMenuPage customerMenuPage = new CustomerMenuPage(this.mainWindow);
            customerMenuPage.Show();
            this.Close();
        }
    }
}
