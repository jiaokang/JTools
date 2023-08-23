using Microsoft.Win32;
using System.Windows;

namespace JTools
{
    /// <summary>
    /// FileHashWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FileHashWindow : Window
    {
        public FileHashWindow()
        {
            InitializeComponent();
        }

        private void open_file_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
            }
        }
    }
}
