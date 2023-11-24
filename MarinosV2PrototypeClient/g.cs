using Newtonsoft.Json;
using RestSharp;
using System.IO;
using RestSharp.Serializers.NewtonsoftJson;

namespace MarinosV2PrototypeClient;

public static class g
{
    public static Settings   Settings  { get; set; } = new();
    public static RestClient ApiClient { get; set; }

    static g()
    {
        LoadSettings();
        InitClients();
    }

    public static void LoadSettings()
    {
        if (!File.Exists("Config.json"))
        {
            Settings.RestoreDefaults();
            File.WriteAllText("Config.json", JsonConvert.SerializeObject(Settings));
        }
        else
            JsonConvert.PopulateObject(File.ReadAllText("Config.json"), Settings);
    }

    public static void SaveSettings()
    {
        File.WriteAllText("Config.json", JsonConvert.SerializeObject(Settings));
        InitClients();
    }

    public static void InitClients()
    {
        ApiClient = new RestClient(new RestClientOptions($"{Settings.ApiAddress}:{Settings.ApiPort}")).UseNewtonsoftJson();
    }
}