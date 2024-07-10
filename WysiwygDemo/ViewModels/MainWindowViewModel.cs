using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WebViewControl;

namespace WysiwygDemo.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private WebView _webview;

    [ObservableProperty]
    private string _CurrentAddress;

    [RelayCommand]
    private void ShowDevTools()
    {
        _webview.ShowDeveloperTools();
    }

    public MainWindowViewModel(WebView webView)
    {
        _webview = webView;
        CurrentAddress = "Path\\To\\HTML\\File\\MyPage.html";
    }
}
