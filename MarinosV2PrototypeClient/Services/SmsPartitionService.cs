using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarinosV2PrototypeClient.Models;
using MarinosV2PrototypeClient.Services.BaseServices;
using MarinosV2PrototypeClient.Utils;
using MarinosV2PrototypeShared.Models;
using Newtonsoft.Json;
using RestSharp;

namespace MarinosV2PrototypeClient.Services;


public class SmsPartitionService : TreeTService<SmsPartition>
{
    public async Task<UI_SmsPartition> GetByIdWithDocuments(Guid id)
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(new RestRequest($"{ApiPath}/{id}/WithDocuments"));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return JsonConvert.DeserializeObject<UI_SmsPartition>(response.Content);
        }
        catch (Exception e)
        {

        }

        return null;
    }
}