using MarinosV2PrototypeClient.Models.BaseModels;
using MarinosV2PrototypeClient.Utils.Tracking;
using Newtonsoft.Json;
using ReactiveUI;
using System;
using MarinosV2PrototypeShared.BaseModels;
using MarinosV2PrototypeShared.Models;

namespace MarinosV2PrototypeClient.Models;

public class UI_SmsDocumentFile : SmsDocumentFile
{
    public UI_SmsDocumentFile()
    {
            
    }

    public UI_SmsDocumentFile(string file)
    {
        File       = file;
    }
}