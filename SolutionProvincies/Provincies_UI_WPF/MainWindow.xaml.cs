using Microsoft.Win32;
using Provincies_BL.Managers;
using System.IO.Compression;
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

namespace Provincies_UI_WPF
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
        public FileManager fileManager { get; set; }
        List<string> fileNames = fileManager.GetFilesFromZip(fileDialog.FileName);
        ZipListBox.ItemSource = filenames;
        fileManager.CheckZipFile(fileDialog.FileName,fileNames);
    }
}