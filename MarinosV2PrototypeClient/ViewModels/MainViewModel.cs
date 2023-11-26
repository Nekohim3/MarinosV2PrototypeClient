using System;
using System.Collections.Generic;
using Avalonia.Animation;
using MarinosV2PrototypeClient.Models;
using MarinosV2PrototypeClient.Services;
using MarinosV2PrototypeClient.Services.BaseServices;
using MarinosV2PrototypeClient.Utils;
using ReactiveUI;

namespace MarinosV2PrototypeClient.ViewModels;

public class MainViewModel : ViewModelBase
{
    private ObservableCollectionWithSelectedItem<SmsPartition> _smsPartitionList;
    public ObservableCollectionWithSelectedItem<SmsPartition> SmsPartitionList
    {
        get => _smsPartitionList;
        set => this.RaiseAndSetIfChanged(ref _smsPartitionList, value);
    }

    private ObservableCollectionWithSelectedItem<SmsDocument> _smsDocumentList;
    public ObservableCollectionWithSelectedItem<SmsDocument> SmsDocumentList
    {
        get => _smsDocumentList;
        set => this.RaiseAndSetIfChanged(ref _smsDocumentList, value);
    }

    public MainViewModel()
    {
        InitData();
    }

    private async void InitData()
    {
        var partitionService = new SmsPartitionService();
        //var tree             = await partitionService.GetTree();
        //var partition        = await partitionService.GetById(Guid.Parse("78ba69ca-38e5-4ac1-8c11-5833eb596cb0"));
        var pList = new List<SmsPartition>();
        for (int i = 0; i < 1; i++)
        {
            var p1 = new SmsPartition($"p1-{i}", $"n1-{i}");
            var p2 = new SmsPartition($"p2-{i}", $"n2-{i}");
            var p3 = new SmsPartition($"p3-{i}", $"n3-{i}");
            var p4 = new SmsPartition($"p4-{i}", $"n4-{i}");
            var p5 = new SmsPartition($"p5-{i}", $"n5-{i}");
            p1.AddChild(p2);
            p2.AddChild(p3);
            p3.AddChild(p4);
            p4.AddChild(p5);
            pList.Add(p1);
        }
        //var lst              = await partitionService.GetAll();
        //var lst2             = await partitionService.GetTree();
        //for (var i = 0; i < 10000; i++)
        //{
        //var p1 = new SmsPartition("p1", "n1");
        //var p2 = new SmsPartition("p2", "n2");
        //var p3 = new SmsPartition("p3", "n3");
        //var p4 = new SmsPartition("p4", "n4");
        //var p5 = new SmsPartition("p5", "n5");
        //p1.AddChild(p2);
        //p2.AddChild(p3);
        //p3.AddChild(p4);
        //p4.AddChild(p5);
        //p3.Documents.Add(new SmsDocument("d1", "n1"));

            var qq = await partitionService.Save(pList);
        //}
    }
}
