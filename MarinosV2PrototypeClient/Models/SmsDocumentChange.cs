using System;
using MarinosV2PrototypeClient.Models.BaseModels;
using MarinosV2PrototypeClient.Utils.Tracking;
using Newtonsoft.Json;
using ReactiveUI;

namespace MarinosV2PrototypeClient.Models;

public class SmsDocumentChange : Entity
{
    private string _documentVersion;
    [TrackInclude, JsonProperty]
    public string DocumentVersion
    {
        get => _documentVersion;
        set => this.RaiseAndSetIfChanged(ref _documentVersion, value);
    }

    private DateTime _documentVersionDate;
    [TrackInclude, JsonProperty]
    public DateTime DocumentVersionDate
    {
        get => _documentVersionDate;
        set => this.RaiseAndSetIfChanged(ref _documentVersionDate, value);
    }

    private string _description;
    [TrackInclude, JsonProperty]
    public string Description
    {
        get => _description;
        set => this.RaiseAndSetIfChanged(ref _description, value);
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

    public SmsDocumentChange()
    {
            
    }

    public SmsDocumentChange(string documentVersion, DateTime documentVersionDate, string description)
    {
        _documentVersion     = documentVersion;
        _documentVersionDate = documentVersionDate;
        _description         = description;
    }
}