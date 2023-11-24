using Newtonsoft.Json;
using RestSharp;

namespace MarinosV2PrototypeClient.Utils;

public static class RestRequestExtensions
{
    public static RestRequest GetTRequest(this object obj, string uri, Method m = Method.Get)
    {
        var req = new RestRequest(uri, m);
        req.AddStringBody(JsonConvert.SerializeObject(obj), DataFormat.Json);
        return req;
    }

    public static string GetJson(this object obj) => JsonConvert.SerializeObject(obj);
}