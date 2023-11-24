using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using MarinosV2PrototypeClient.ViewModels;
using MarinosV2PrototypeClient.Views;
using Newtonsoft.Json;

namespace MarinosV2PrototypeClient;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this); 
        JsonConvert.DefaultSettings = () => new JsonSerializerSettings() { MaxDepth = 1024, TypeNameHandling = TypeNameHandling.None, ReferenceLoopHandling = ReferenceLoopHandling.Ignore, PreserveReferencesHandling = PreserveReferencesHandling.Objects };
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainViewModel()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
