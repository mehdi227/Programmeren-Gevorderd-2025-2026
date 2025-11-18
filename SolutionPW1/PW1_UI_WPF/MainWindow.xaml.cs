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

namespace PW1_UI_WPF
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void GroetButton_Click(object sender, RoutedEventArgs e)
        {
            string begroeting = "Hallo ";
            if (EngelsRadioButton.IsChecked == true) begroeting = "Hello ";
            string boodschap = begroeting + NaamTextBox.Text;
            if (HoofdLettersCheckbox.IsChecked == true) boodschap = boodschap.ToUpper();
            BoodschapLabel.Content = boodschap;
        }
    }
}