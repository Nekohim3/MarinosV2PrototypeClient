using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarinosV2PrototypeClient.Models;
using MarinosV2PrototypeClient.Services.BaseServices;
using MarinosV2PrototypeClient.Utils;
using Newtonsoft.Json;
using RestSharp;

namespace MarinosV2PrototypeClient.Services;

public interface ITest<T> where T : ICollection
{
    public T List { get; set; }
}

public class Test : ITest<List<SmsPartition>>
{
    public List<SmsPartition> List { get; set; }
}

public class SmsPartitionService : TreeTService<SmsPartition>
{
    public SmsPartitionService() : base("SmsPartition")
    {
    }

    public async Task<SmsPartition> GetByIdWithDocuments(Guid id)
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(new RestRequest($"{ApiPath}/{id}/WithDocuments"));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return JsonConvert.DeserializeObject<SmsPartition>(response.Content);
        }
        catch (Exception e)
        {

        }

        return null;
    }
}