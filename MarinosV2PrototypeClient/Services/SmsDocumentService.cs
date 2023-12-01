using MarinosV2PrototypeClient.Models;
using MarinosV2PrototypeClient.Services.BaseServices;
using MarinosV2PrototypeShared.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace MarinosV2PrototypeClient.Services;

public class SmsDocumentService : TService<UI_SmsDocument, SmsDocument>
{
    public async Task<List<UI_SmsDocument>?> GetDocumentsByPartition(Guid id)
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(new RestRequest($"{ApiPath}/ByPartition/{id}"));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return JsonConvert.DeserializeObject<List<UI_SmsDocument>?>(response.Content);
        }
        catch (Exception e)
        {

        }

        return null;
    }
}