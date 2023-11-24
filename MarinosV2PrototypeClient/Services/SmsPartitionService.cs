using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarinosV2PrototypeClient.Models;
using MarinosV2PrototypeClient.Services.BaseServices;
using MarinosV2PrototypeClient.Utils;
using Newtonsoft.Json;
using RestSharp;

namespace MarinosV2PrototypeClient.Services;

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
    //public async Task<IList<SmsPartition>?> GetTree()
    //{
    //    return (await GetAll())?.GetTreeFromList();
    //}

    //public async Task<IList<SmsPartition>?> GetBranch(Guid? parentId)
    //{
    //    try
    //    {
    //        var response = await g.ApiClient.ExecuteAsync(new RestRequest($"{ApiPath}/Branch/{parentId}"));
    //        if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
    //            return JsonConvert.DeserializeObject<List<SmsPartition>>(response.Content);
    //    }
    //    catch (Exception e)
    //    {
    //    }

    //    return null;
    //}
}