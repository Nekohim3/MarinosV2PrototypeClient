using MarinosV2PrototypeClient.Models;
using MarinosV2PrototypeClient.Services.BaseServices;

namespace MarinosV2PrototypeClient.Services;

public class SmsDocumentFileService : TService<SmsDocumentFile>
{
    public SmsDocumentFileService() : base("SmsDocumentFile")
    {
    }
}