using System.Collections.Generic;
using MarinosV2PrototypeShared.Models;
using MarinosV2PrototypeShared.Utils;
using ReactiveUI;

namespace MarinosV2PrototypeClient.Models;

public class UI_SmsPartition : SmsPartition
{
    private string _test;
    public string Test
    {
        get => _test;
        set => this.RaiseAndSetIfChanged(ref _test, value);
    }

    public UI_SmsPartition()
    {
        Childs    = new ObservableCollectionWithSelectedItem<SmsPartition>();
        Documents = new ObservableCollectionWithSelectedItem<SmsDocument>();
    }

    public UI_SmsPartition(string name, string number) : this()
    {
        Name = name;
        Number = number;
    }

    public void AddDocument(UI_SmsDocument doc)
    {
        Documents.Add(doc);
        doc.IdPartition = Id;
    }

    public void AddDocuments(IEnumerable<UI_SmsDocument> docs)
    {
        foreach (var x in docs)
            AddDocument(x);
    }

}