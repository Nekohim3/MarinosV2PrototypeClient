using MarinosV2PrototypeClient.ViewModels;
using Newtonsoft.Json;
using ReactiveUI;

namespace MarinosV2PrototypeClient;

[JsonObject]
public class Settings : ViewModelBase
{
    private string _apiAddress;
    public string ApiAddress
    {
        get => _apiAddress;
        set => this.RaiseAndSetIfChanged(ref _apiAddress, value);
    }

    private string _apiPort;
    public string ApiPort
    {
        get => _apiPort;
        set => this.RaiseAndSetIfChanged(ref _apiPort, value);
    }

    public void RestoreDefaults()
    {
        ApiAddress = "https://localhost";
        ApiPort    = "2112";
    }
}