using System.Windows;

using Microsoft.Toolkit.Win32.UI.XamlHost;

using WinRT;

namespace XamlIslands9.Wpf
{
  public partial class MainWindow : Window
  {
    private XamlUserControl _xamlUserControl;

    public MainWindow()
    {
      InitializeComponent();

      _xamlUserControl = new XamlUserControl();
      _xamlUserControl.CloseAppRequested += App.Current.Shutdown;
    }

    private void OnSourceInitialized(object sender, EventArgs e)
    {
      Windows.UI.Xaml.Window.Current.As<IWindowPrivate>().TransparentBackground = true;
      XamlHost.Child = _xamlUserControl;
    }
  }
}