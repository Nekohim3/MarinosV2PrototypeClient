using System;
using MarinosV2PrototypeShared.Models;

namespace MarinosV2PrototypeClient.Models;

public class UI_SmsDocumentChange : SmsDocumentChange
{
    public UI_SmsDocumentChange()
    {
            
    }

    public UI_SmsDocumentChange(string documentVersion, DateTime documentVersionDate, string description) : this()
    {
        DocumentVersion     = documentVersion;
        DocumentVersionDate = documentVersionDate;
        Description         = description;
    }
}