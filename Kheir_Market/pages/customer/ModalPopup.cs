using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kheir_Market.pages.customer
{
    public partial class ModalPopup : Form
    {
        private MainWindow mainWindow;
        private CustomerMenuPage customerMenuPage;

        public ModalPopup(MainWindow mainWindow, CustomerMenuPage customerMenuPage)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            this.customerMenuPage = customerMenuPage;
        }

        private void gmailBtn_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService(this.mainWindow);
            customerService.Show();
            this.customerMenuPage.FormClosing -= this.mainWindow.formClosing;
            this.customerMenuPage.Close();
            this.Close();
        }
    }
}
