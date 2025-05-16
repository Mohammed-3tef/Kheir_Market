using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Super_Market.packages.display
{
    public class MessageDisplay
    {
        public static void ShowError(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "Error", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
        }

        public static void ShowSuccess(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "Success", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
        }

        public static void ShowWarning(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "Warning", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
        }

        public static void ShowInfo(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "Information", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
        }
    }
}
