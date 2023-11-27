using MarinosV2PrototypeShared.Models;

namespace MarinosV2PrototypeClient.Models;

public class UI_SmsDocumentFile : SmsDocumentFile
{
    public UI_SmsDocumentFile()
    {
            
    }

    public UI_SmsDocumentFile(string file) : this()
    {
        File       = file;
    }
}