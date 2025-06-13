using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kheir_Market.pages
{
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.progressBar.Increment(2);
            this.loadingLabel.Text = "Loading... " + this.progressBar.Value.ToString() + "%";
            if (this.progressBar.Value == 100)
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}
