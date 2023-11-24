using MarinosV2PrototypeClient.Models.BaseModels;
using MarinosV2PrototypeClient.Utils.Tracking;
using Newtonsoft.Json;
using ReactiveUI;
using System;

namespace MarinosV2PrototypeClient.Models;

public class SmsDocumentFile : Entity
{
    private string _file;
    [TrackInclude, JsonProperty]
    public string File
    {
        get => _file;
        set => this.RaiseAndSetIfChanged(ref _file, value);
    }

    private Guid _idDocument;
    [TrackInclude, JsonProperty]
    public Guid IdDocument
    {
        get => _idDocument;
        set => this.RaiseAndSetIfChanged(ref _idDocument, value);
    }

    private SmsDocument? _document;
    public SmsDocument? Document
    {
        get => _document;
        set => this.RaiseAndSetIfChanged(ref _document, value);
    }

    public SmsDocumentFile()
    {
            
    }

    public SmsDocumentFile(string file)
    {
        _file       = file;
    }
}