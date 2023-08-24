using Newtonsoft.Json;
using System;
using System.Windows;

namespace JTools
{
    /// <summary>
    /// JsonFormatWindow.xaml 的交互逻辑
    /// </summary>
    public partial class JsonFormatWindow : Window
    {
        public JsonFormatWindow()
        {
            InitializeComponent();
        }

        private void jsonFormat_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string jsonInput = sourceText.Text;
                object parsedJson = JsonConvert.DeserializeObject(jsonInput);
                string formattedJson = JsonConvert.SerializeObject(parsedJson, Newtonsoft.Json.Formatting.Indented);
                targetText.Text = formattedJson;
            }
            catch (Exception ex)
            {
                // 处理JSON解析错误
                targetText.Text = "Invalid JSON: " + ex.Message;
            }
        }
    }
}
