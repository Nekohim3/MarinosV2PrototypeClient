using System;
using System.Collections.Generic;
using DynamicData;
using MarinosV2PrototypeClient.Models.BaseModels;
using MarinosV2PrototypeClient.Utils;
using MarinosV2PrototypeClient.Utils.Tracking;
using MarinosV2PrototypeShared.BaseModels;
using MarinosV2PrototypeShared.Models;
using Newtonsoft.Json;
using ReactiveUI;

namespace MarinosV2PrototypeClient.Models;

public class UI_SmsDocument : SmsDocument
{
    public UI_SmsDocument()
    {

    }

    public UI_SmsDocument(string name, string number)
    {
        Name = name;
        Number = number;
    }

    public void AddChange(SmsDocumentChange change)
    {
        DocumentChanges.Add(change);
        change.IdDocument = Id;
    }

    public void AddChanges(IEnumerable<SmsDocumentChange> changes)
    {
        foreach (var x in changes)
            AddChange(x);
    }

    public void AddFile(SmsDocumentFile file)
    {
        DocumentFiles.Add(file);
        file.IdDocument = Id;
    }

    public void AddFiles(IEnumerable<SmsDocumentFile> files)
    {
        foreach (var x in files)
            AddFile(x);
    }
}