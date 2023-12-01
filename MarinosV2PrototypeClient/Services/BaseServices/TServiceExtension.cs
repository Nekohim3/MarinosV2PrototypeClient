using MarinosV2PrototypeShared.BaseModels;

namespace MarinosV2PrototypeClient.Services.BaseServices
{
    public static class TServiceExtension
    {
        public static TService<T, TT> AsNoTracking<T, TT>(this TService<T, TT> service) where TT : Entity where T : TT
        {
            service.NoTrack = true;
            return service;
        }
    }
}
