using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace JTools
{
    /// <summary>
    /// Base64.xaml 的交互逻辑
    /// </summary>
    public partial class Base64Window : Window
    {
        public Base64Window()
        {
            InitializeComponent();
        }

        private void button_chooseFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                string base64 = ConvertPdfToBase64(filePath);
                WriteToFile(base64);
                MessageBox.Show("Base64字符串已经写入桌面Base64Output.txt");
            }
        }

        /// <summary>
        /// 读取PDF文件转为Base64字符串
        /// </summary>
        /// <param name="filePath">
        /// PDF文件路径
        /// </param>
        /// <returns>
        /// Base64字符串
        /// </returns>
        private static string ConvertPdfToBase64(string filePath)
        {
            byte[] bytes = File.ReadAllBytes(filePath);
            return Convert.ToBase64String(bytes);
        }
        private static void WriteToFile(string base64String)
        {
            string outPutPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Base64Output.txt";
            File.WriteAllText(outPutPath, base64String);
        }
    }
}
