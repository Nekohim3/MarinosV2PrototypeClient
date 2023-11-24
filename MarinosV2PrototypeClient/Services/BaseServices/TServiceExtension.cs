using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarinosV2PrototypeClient.Models.BaseModels;

namespace MarinosV2PrototypeClient.Services.BaseServices
{
    public static class TServiceExtension
    {
        public static TService<T> AsNoTracking<T>(this TService<T> service) where T : Entity
        {
            service.NoTrack = true;
            return service;
        }
    }
}
