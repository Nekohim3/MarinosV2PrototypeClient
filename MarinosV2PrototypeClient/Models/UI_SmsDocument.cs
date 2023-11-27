using System.Collections.Generic;
using MarinosV2PrototypeShared.Models;
using MarinosV2PrototypeShared.Utils;

namespace MarinosV2PrototypeClient.Models;

public class UI_SmsDocument : SmsDocument
{
    public UI_SmsDocument()
    {
        DocumentChanges = new ObservableCollectionWithSelectedItem<SmsDocumentChange>();
        DocumentFiles   = new ObservableCollectionWithSelectedItem<SmsDocumentFile>();
    }

    public UI_SmsDocument(string name, string number) : this()
    {
        Name = name;
        Number = number;
    }

    public void AddChange(UI_SmsDocumentChange change)
    {
        DocumentChanges.Add(change);
        change.IdDocument = Id;
    }

    public void AddChanges(IEnumerable<UI_SmsDocumentChange> changes)
    {
        foreach (var x in changes)
            AddChange(x);
    }

    public void AddFile(UI_SmsDocumentFile file)
    {
        DocumentFiles.Add(file);
        file.IdDocument = Id;
    }

    public void AddFiles(IEnumerable<UI_SmsDocumentFile> files)
    {
        foreach (var x in files)
            AddFile(x);
    }
}