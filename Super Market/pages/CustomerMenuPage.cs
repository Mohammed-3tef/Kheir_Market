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
    public partial class CustomerMenuPage : Form
    {
        private MainWindow mainWindow;

        public CustomerMenuPage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            if (this.mainWindow == null) this.mainWindow = new MainWindow();
            this.mainWindow.Show();
            this.Close();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
