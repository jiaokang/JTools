using Microsoft.Win32;
using System;
using System.IO;
using System.Security.Cryptography;
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
                string hashString = Md5Digest(filePath);
                output_box.Text = hashString;
            }
        }

        private static string Md5Digest(string filePath)
        {
            byte[] digestByte;
            using (MD5 md5 = MD5.Create())
            {
                using (FileStream fileStream = File.OpenRead(filePath))
                {
                    digestByte = md5.ComputeHash(fileStream);
                }
            }
            string hashString = BitConverter.ToString(digestByte).Replace("-", string.Empty);
            return hashString;
        }

        private void copy_clipboard_Click(object sender, RoutedEventArgs e)
        {
            string md5DigestString = output_box.Text;
            Clipboard.SetText(md5DigestString);
            MessageBox.Show("内容已复制到剪切板");
        }

    }
}
