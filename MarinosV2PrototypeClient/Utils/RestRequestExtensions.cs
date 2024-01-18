using MarinosV2PrototypeShared.Utils;
using Newtonsoft.Json;
using RestSharp;

namespace MarinosV2PrototypeClient.Utils;

public static class RestRequestExtensions
{
    public static RestRequest GetTRequest(this object obj, string uri, Method m = Method.Get)
    {
        var req  = new RestRequest(uri, m);
        var body = JsonConvert.SerializeObject(obj, new JsonSerializerSettings() { ContractResolver = new EntityContractResolver() });
        req.AddStringBody(body, DataFormat.Json);
        return req;
    }

    public static string GetJson(this object obj) => JsonConvert.SerializeObject(obj);
}