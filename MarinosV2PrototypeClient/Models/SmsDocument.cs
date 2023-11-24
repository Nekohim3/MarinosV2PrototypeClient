using System;
using System.Collections.Generic;
using DynamicData;
using MarinosV2PrototypeClient.Models.BaseModels;
using MarinosV2PrototypeClient.Utils;
using MarinosV2PrototypeClient.Utils.Tracking;
using Newtonsoft.Json;
using ReactiveUI;

namespace MarinosV2PrototypeClient.Models;

public class SmsDocument : Entity
{
    private string _name;
    [TrackInclude, JsonProperty]
    public string Name
    {
        get => _name;
        set => this.RaiseAndSetIfChanged(ref _name, value);
    }

    private string _number;
    [TrackInclude, JsonProperty]
    public string Number
    {
        get => _number;
        set => this.RaiseAndSetIfChanged(ref _number, value);
    }

    private Guid _idPartition;
    [TrackInclude, JsonProperty]
    public Guid IdPartition
    {
        get => _idPartition;
        set => this.RaiseAndSetIfChanged(ref _idPartition, value);
    }

    private SmsPartition? _partition;
    public SmsPartition? Partition
    {
        get => _partition;
        set => this.RaiseAndSetIfChanged(ref _partition, value);
    }

    private ObservableCollectionWithSelectedItem<SmsDocumentChange> _documentChanges = new();
    [JsonProperty]
    public ObservableCollectionWithSelectedItem<SmsDocumentChange> DocumentChanges
    {
        get => _documentChanges;
        set => this.RaiseAndSetIfChanged(ref _documentChanges, value);
    }

    private ObservableCollectionWithSelectedItem<SmsDocumentFile> _documentFiles = new();
    [JsonProperty]
    public ObservableCollectionWithSelectedItem<SmsDocumentFile> DocumentFiles
    {
        get => _documentFiles;
        set => this.RaiseAndSetIfChanged(ref _documentFiles, value);
    }

    public SmsDocument()
    {
            
    }

    public SmsDocument(string name, string number)
    {
        _name        = name;
        _number      = number;
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