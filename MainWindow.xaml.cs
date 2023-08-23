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

        private void button_base64_Click(object sender, RoutedEventArgs e)
        {
            Base64Windows base64Windows = new Base64Windows();
            base64Windows.Show();
        }
    }
}
