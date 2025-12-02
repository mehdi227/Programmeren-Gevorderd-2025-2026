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

namespace PW1_UI_WPF2
{
    /// <summary>
    /// Interaction logic for TweedeVoorbeeld.xaml
    /// </summary>
    public partial class TweedeVoorbeeld : Window
    {
        public TweedeVoorbeeld()
        {
            InitializeComponent();
        }

        private void Calendar1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (DateTime item in e.AddedItems)
            {
                GeselecteerdeDataListBox.Items.Add(item);
            }
        }
    }
}
