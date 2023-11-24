using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarinosV2PrototypeClient.Models.BaseModels;
using MarinosV2PrototypeClient.Utils;
using Newtonsoft.Json;
using RestSharp;

namespace MarinosV2PrototypeClient.Services.BaseServices
{
    public abstract class TreeTService<T> : TService<T> where T : TreeEntity<T>
    {
        protected TreeTService(string apiPath) : base(apiPath)
        {
        }

        public virtual async Task<IList<T>?> GetTree()
        {
            try
            {
                var response = await g.ApiClient.ExecuteAsync(new RestRequest($"{ApiPath}/Tree"));
                if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                    return JsonConvert.DeserializeObject<List<T>>(response.Content);
            }
            catch (Exception e)
            {
            }

            return null;
        }

        public virtual async Task<T?> GetBranch(Guid? parentId)
        {
            try
            {
                var response = await g.ApiClient.ExecuteAsync(new RestRequest($"{ApiPath}/Branch/{parentId}"));
                if (response.IsSuccessStatusCode && !string.IsNullOrEmpty(response.Content))
                    return JsonConvert.DeserializeObject<T>(response.Content);
            }
            catch (Exception e)
            {
            }

            return null;
        }
    }
}
