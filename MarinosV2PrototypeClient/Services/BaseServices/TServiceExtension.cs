using MarinosV2PrototypeShared.BaseModels;

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
