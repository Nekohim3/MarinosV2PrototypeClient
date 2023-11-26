using MarinosV2PrototypeClient.Models.BaseModels;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MarinosV2PrototypeClient.Utils;
using MarinosV2PrototypeShared.BaseModels;
using Newtonsoft.Json;

namespace MarinosV2PrototypeClient.Services.BaseServices;

public abstract class TService<T> where T : Entity
{
    protected readonly string ApiPath;
    public bool NoTrack { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="apiPath">Path to entity api</param>
    protected TService(string apiPath = nameof(T))
    {
        ApiPath = apiPath;
    }

    public virtual async Task<T?> GetById(Guid id)
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(new RestRequest($"{ApiPath}/{id}"));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return JsonConvert.DeserializeObject<T>(response.Content);
        }
        catch (Exception e)
        {
            
        }

        return null;
    }

    public virtual async Task<List<T>?> GetAll()
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(new RestRequest(ApiPath));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return JsonConvert.DeserializeObject<List<T>>(response.Content);
        }
        catch (Exception e)
        {
        }

        return null;
    }

    public virtual async Task<T?> Create(T t)
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(t.GetTRequest(ApiPath, Method.Post));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return JsonConvert.DeserializeObject<T>(response.Content);
        }
        catch (Exception e)
        {
            
        }
        return null;
    }

    public virtual async Task<List<T>?> Create(List<T> tList)
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(tList.GetTRequest($"{ApiPath}/Bulk", Method.Post));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return JsonConvert.DeserializeObject<List<T>>(response.Content);
        }
        catch (Exception e)
        {

        }
        return null;
    }

    public virtual async Task<T?> Update(T t)
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(t.GetTRequest($"{ApiPath}/Bulk", Method.Put));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return JsonConvert.DeserializeObject<T>(response.Content);
        }
        catch (Exception e)
        {

        }
        return null;
    }

    public virtual async Task<List<T>?> Update(List<T> tList)
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(tList.GetTRequest($"{ApiPath}/Bulk", Method.Put));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return JsonConvert.DeserializeObject<List<T>>(response.Content);
        }
        catch (Exception e)
        {

        }
        return null;
    }

    public virtual async Task<T?> Save(T t)
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(t.GetTRequest(ApiPath, Method.Patch));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return JsonConvert.DeserializeObject<T>(response.Content);
        }
        catch (Exception e)
        {

        }
        return null;
    }

    public virtual async Task<List<T>?> Save(List<T> tList)
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(tList.GetTRequest($"{ApiPath}/Bulk", Method.Patch));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return JsonConvert.DeserializeObject<List<T>>(response.Content);
        }
        catch (Exception e)
        {

        }
        return null;
    }

    public virtual async Task<bool> Delete(Guid       id)
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(new RestRequest($"{ApiPath}/{id}", Method.Delete));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return true;
        }
        catch (Exception e)
        {

        }

        return false;
    }

    public virtual async Task<bool> Delete(List<Guid> tList)
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(tList.GetTRequest($"{ApiPath}/BulkGuid", Method.Delete));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return true;
        }
        catch (Exception e)
        {

        }

        return false;
    }

    public virtual async Task<bool> Delete(T t)
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(t.GetTRequest(ApiPath, Method.Delete));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return true;
        }
        catch (Exception e)
        {

        }
        return false;
    }

    public virtual async Task<bool> Delete(List<T> tList)
    {
        try
        {
            var response = await g.ApiClient.ExecuteAsync(tList.GetTRequest($"{ApiPath}/Bulk", Method.Delete));
            if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                return true;
        }
        catch (Exception e)
        {

        }
        return false;
    }
}

