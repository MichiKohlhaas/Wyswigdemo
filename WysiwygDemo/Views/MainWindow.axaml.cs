using Avalonia.Controls;
using WebViewControl;
using WysiwygDemo.ViewModels;

namespace WysiwygDemo.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WebView.Settings.OsrEnabled = false;
            WebView.Settings.LogFile = "ceflog.txt";

            InitializeComponent();
            DataContext = new MainWindowViewModel(this.FindControl<WebView>("webview"));
        }
    }
}