using Microsoft.Toolkit.Win32.UI.XamlHost;

using Windows.UI.Xaml.Markup;

namespace XamlIslands9.Wpf
{
  internal class Program
  {
    [STAThread]
    public static void Main()
    {
      using (var xamlApp = new XamlApplication(new List<IXamlMetadataProvider>()))
      {
        xamlApp.Resources.MergedDictionaries.Add(new Windows.UI.Xaml.ResourceDictionary() 
        { Source = new Uri("ms-appx:///XamlIslands9.Uwp/Styles/Common.xaml") });
        xamlApp.Resources.MergedDictionaries.Add(new Windows.UI.Xaml.ResourceDictionary() 
        { Source = new Uri("ms-appx:///XamlIslands9.Uwp/Styles/Button.xaml") });
        xamlApp.Resources.MergedDictionaries.Add(new Windows.UI.Xaml.ResourceDictionary()
        { Source = new Uri("ms-appx:///XamlIslands9.Uwp/Styles/TextBox.xaml") });

        var app = new App();
        app.InitializeComponent();
        app.Run();
      }
    }
  }
}