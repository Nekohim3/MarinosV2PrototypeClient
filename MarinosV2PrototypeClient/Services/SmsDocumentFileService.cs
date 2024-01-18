using MarinosV2PrototypeClient.Models;
using MarinosV2PrototypeClient.Services.BaseServices;
using MarinosV2PrototypeShared.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace MarinosV2PrototypeClient.Services;

public class SmsDocumentFileService : TService<UI_SmsDocumentFile, SmsDocumentFile>
{

    public async Task<List<UI_SmsDocumentFile>?> GetDocumentFilesByDocument(Guid id)
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(new RestRequest($"{ApiPath}/ByDocument/{id}"));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return JsonConvert.DeserializeObject<List<UI_SmsDocumentFile>?>(response.Content);
        }
        catch (Exception e)
        {

        }

        return null;
    }
}