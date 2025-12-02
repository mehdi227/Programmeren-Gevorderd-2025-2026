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

namespace PW1_UI_WPF
{
    /// <summary>
    /// Interaction logic for BeheerderLoginWindow.xaml
    /// </summary>
    public partial class BeheerderLoginWindow : Window
    {
        public BeheerderLoginWindow()
        {
            InitializeComponent();
        }

        private void goBackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            this.Close();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
