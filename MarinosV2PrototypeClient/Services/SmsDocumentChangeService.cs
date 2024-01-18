using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MarinosV2PrototypeClient.Models;
using MarinosV2PrototypeClient.Services.BaseServices;
using MarinosV2PrototypeShared.Models;
using Newtonsoft.Json;
using RestSharp;

namespace MarinosV2PrototypeClient.Services;

public class SmsDocumentChangeService : TService<UI_SmsDocumentChange, SmsDocumentChange>
{
    public async Task<List<UI_SmsDocumentChange>?> GetDocumentChangesByDocument(Guid id)
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(new RestRequest($"{ApiPath}/ByDocument/{id}"));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return JsonConvert.DeserializeObject<List<UI_SmsDocumentChange>?>(response.Content);
        }
        catch (Exception e)
        {
            
        }

        return null;
    }
}