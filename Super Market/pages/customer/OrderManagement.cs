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
        public OrderManagement()
        {
            InitializeComponent();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            CustomerMenuPage customerMenuPage = new CustomerMenuPage();
            customerMenuPage.Show();
            this.Close();
        }
    }
}
