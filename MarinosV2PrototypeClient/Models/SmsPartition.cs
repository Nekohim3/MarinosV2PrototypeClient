using System.Collections.Generic;
using MarinosV2PrototypeClient.Models.BaseModels;
using MarinosV2PrototypeClient.Utils;
using MarinosV2PrototypeClient.Utils.Tracking;
using MarinosV2PrototypeShared.BaseModels;
using MarinosV2PrototypeShared.Models;
using Newtonsoft.Json;
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
    //private string _name;
    //[TrackInclude, JsonProperty]
    //public string Name
    //{
    //    get => _name;
    //    set => this.RaiseAndSetIfChanged(ref _name, value);
    //}

    //private string _number;
    //[TrackInclude, JsonProperty]
    //public string Number
    //{
    //    get => _number;
    //    set => this.RaiseAndSetIfChanged(ref _number, value);
    //}

    //private ObservableCollectionWithSelectedItem<SmsDocument> _documents = new();
    //[JsonProperty]
    //public ObservableCollectionWithSelectedItem<SmsDocument> Documents
    //{
    //    get => _documents;
    //    set => this.RaiseAndSetIfChanged(ref _documents, value);
    //}

    //public SmsPartition()
    //{
            
    //}

    //public SmsPartition(string name, string number)
    //{
    //    _name   = name;
    //    _number = number;
    //}

    //public void AddDocument(SmsDocument doc)
    //{
    //    Documents.Add(doc);
    //    doc.IdPartition = Id;
    //}

    //public void AddDocuments(IEnumerable<SmsDocument> docs)
    //{
    //    foreach (var x in docs)
    //        AddDocument(x);
    //}

}