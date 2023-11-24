using MarinosV2PrototypeClient.Models;
using MarinosV2PrototypeClient.Services.BaseServices;

namespace MarinosV2PrototypeClient.Services;

public class SmsDocumentChangeService : TService<SmsDocumentChange>
{
    public SmsDocumentChangeService() : base("SmsDocumentChange")
    {
    }
}