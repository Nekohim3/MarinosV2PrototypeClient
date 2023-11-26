using System;
using MarinosV2PrototypeClient.Models.BaseModels;
using MarinosV2PrototypeClient.Utils.Tracking;
using MarinosV2PrototypeShared.BaseModels;
using MarinosV2PrototypeShared.Models;
using Newtonsoft.Json;
using ReactiveUI;

namespace MarinosV2PrototypeClient.Models;

public class UI_SmsDocumentChange : SmsDocumentChange
{
    public UI_SmsDocumentChange()
    {
            
    }

    public UI_SmsDocumentChange(string documentVersion, DateTime documentVersionDate, string description)
    {
        DocumentVersion     = documentVersion;
        DocumentVersionDate = documentVersionDate;
        Description         = description;
    }
}