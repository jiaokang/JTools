using System.Windows;

namespace JTools
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
        /// <summary>
        /// 打开PDF文件转Base64子窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_base64_Click(object sender, RoutedEventArgs e)
        {
            Base64Window base64Window = new Base64Window();
            base64Window.Show();
        }

        /// <summary>
        /// 打开文件计算文件hash值子窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_file_hash_Click(object sender, RoutedEventArgs e)
        {
            FileHashWindow fileHashWindow = new FileHashWindow();
            fileHashWindow.Show();
        }

        /// <summary>
        /// 打开JsonFormat子窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_json_format_Click(object sender, RoutedEventArgs e)
        {
            JsonFormatWindow jsonFormatWindow = new JsonFormatWindow();
            jsonFormatWindow.Show();
        }
    }
}
