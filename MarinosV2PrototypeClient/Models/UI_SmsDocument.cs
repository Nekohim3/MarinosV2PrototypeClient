using System.Collections.Generic;
using MarinosV2PrototypeClient.Services;
using MarinosV2PrototypeClient.Utils;
using MarinosV2PrototypeShared.Models;
using MarinosV2PrototypeShared.Utils;
using ReactiveUI;

namespace MarinosV2PrototypeClient.Models;

public class UI_SmsDocument : SmsDocument
{
    public override ICollection<SmsDocumentChange>? DocumentChanges
    {
        get
        {
            if (_documentChanges == null)
            {
                _documentChanges = new ObservableCollectionWithSelectedItem<SmsDocumentChange>();
                if (Version != 0)
                {
                    var docChanges = new SmsDocumentChangeService().GetDocumentChangesByDocument(Id).Result;
                    if (docChanges != null)
                        _documentChanges.AddRange(docChanges);
                }
            }

            return _documentChanges;
        }
        set => this.RaiseAndSetIfChanged(ref _documentChanges, value);
    }

    public override ICollection<SmsDocumentFile>? DocumentFiles
    {
        get
        {
            if (_documentFiles == null)
            {
                _documentFiles = new ObservableCollectionWithSelectedItem<SmsDocumentFile>();
                if (Version != 0)
                {
                    var docFiles = new SmsDocumentFileService().GetDocumentFilesByDocument(Id).Result;
                    if (docFiles != null)
                        _documentFiles.AddRange(docFiles);
                }
            }

            return _documentFiles;
        }
        set => this.RaiseAndSetIfChanged(ref _documentFiles, value);
    }

    public UI_SmsDocument()
    {

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