using System.Collections.Generic;
using System.Threading.Tasks;
using MarinosV2PrototypeClient.Services;
using MarinosV2PrototypeClient.Utils;
using MarinosV2PrototypeShared.Models;
using MarinosV2PrototypeShared.Utils;
using ReactiveUI;

namespace MarinosV2PrototypeClient.Models;

public class UI_SmsPartition : SmsPartition
{
    public override ICollection<SmsDocument>? Documents
    {
        get 
        {
            if (_documents == null)
            {
                _documents = new ObservableCollectionWithSelectedItem<SmsDocument>();
                if (Version != 0)
                {
                    var docs = new SmsDocumentService().GetDocumentsByPartition(Id).Result;
                    if (docs != null)
                        _documents.AddRange(docs);
                }
            }
            return _documents;
        }
        set => this.RaiseAndSetIfChanged(ref _documents, value);
    }

    public override ICollection<SmsPartition>? Childs
    {
        get
        {
            if (_childs == null)
            {
                _childs = new ObservableCollectionWithSelectedItem<SmsPartition>();
                if (Version != 0)
                {
                    var childs = Task.Run(() => new SmsPartitionService().GetChildsByParentId(Id)).Result;
                    if (childs != null)
                        _childs.AddRange(childs);
                }
            }
            return _childs;
        }
        set => _childs = value;
    }

    public override SmsPartition? Parent
    {
        get => _parent;
        set => this.RaiseAndSetIfChanged(ref _parent, value);
    }

    public UI_SmsPartition()
    {

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