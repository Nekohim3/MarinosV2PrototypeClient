using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Avalonia;
using DynamicData;
using MarinosV2PrototypeClient.Models;
using MarinosV2PrototypeClient.Services;
using MarinosV2PrototypeShared.BaseModels;
using MarinosV2PrototypeShared.Models;
using MarinosV2PrototypeShared.Utils;
using Microsoft.EntityFrameworkCore;
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
            var p1 = new SmsPartition();
            //var p2 = new SmsPartition();
            //var p3 = new SmsPartition();
            //var p4 = new SmsPartition();
            //var p5 = new SmsPartition();
            //p1.AddChild(p2);
            //p2.AddChild(p3);
            //p3.AddChild(p4);
            //p4.AddChild(p5);
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

            //var qq = await partitionService.Save(pList);

            var qqq  = pList;
            var qqqq = EntityFrameworkQueryableExtensions.Include(pList, _ => _.Documents);
            //}
    }
}

//public class IncludeHelper<TEntity, TProperty>
//{
//    public string                            Name     { get; set; }
//    public TEntity                           Entity   { get; set; }
//    public TProperty                         Property { get; set; }
//    public IncludeHelper<TEntity, TProperty> Next     { get; set; }
//    public IncludeHelper<TEntity, TProperty> Parent   { get; set; }

//    public IncludeHelper(TEntity e, TProperty p)
//    {
//        Entity   = e;
//        Property = p;
//    }

//    public IncludeHelper<TEntity, TProperty> SetNext(TEntity e, TProperty p)
//    {
//        return new IncludeHelper<TEntity, TProperty>(e, p) { Parent = this };
//    }
//}
//public class IncludeHelper<TEntity>
//{
//    public string                            Name     { get; set; }
//    public TEntity                           Entity   { get; set; }
//    public object                         Property { get; set; }
//    public IncludeHelper<TEntity> Next     { get; set; }
//    public IncludeHelper<TEntity> Parent   { get; set; }

//    public IncludeHelper(TEntity e, object p)
//    {
//        Entity   = e;
//        Property = p;
//    }

//    public IncludeHelper<TEntity> SetNext(TEntity e, object p)
//    {
//        return new IncludeHelper<TEntity>(e, p) { Parent = this };
//    }
//}
//public static class IncludeExtension
//{
//    public static IncludeHelper<TEntity> Includee<TEntity>(this ICollection<TEntity> source, Expression<Func<TEntity, IEnumerable<object>>> nav) where TEntity : class
//    {
//        var func = nav.Compile();
//        var type = source.GetType();
//        var fga  = type.GenericTypeArguments[0];

//        var item = source.FirstOrDefault();
//        var q    = func(fga as TEntity);
//        var qq   = new IncludeHelper<TEntity>(item, q);
//        return qq;
//    }

//    //public static IncludeHelper<TEntity, TProperty> Includee<TEntity, TProperty>(this ICollection<TEntity> source, Expression<Func<TEntity, IEnumerable<TProperty>>> nav) where TEntity : Entity where TProperty : Entity
//    //{
//    //    var func = nav.Compile();
//    //    var item = source.FirstOrDefault();
//    //    var q = func(item);
//    //    //return new IncludeHelper<TEntity, TProperty>(item, q);
//    //    return null;
//    //}

//    //public static IncludeHelper<TEntity, TProperty> ThenIncludee<TEntity, TPreviousEntity, TPreviousProperty, TProperty>(this IncludeHelper<TPreviousEntity, TEntity> source, Expression<Func<TPreviousProperty, TProperty>> nav) where TEntity : Entity where TProperty : Entity where TPreviousProperty : Entity
//    //{
//    //    var func = nav.Compile();
//    //    var item = source.Property as TPreviousProperty;
//    //    //var item = source.First().Item2.First();
//    //    var q = func(item);
//    //    return source.SetNext(source.Entity, q);
//    //}
//    //public static List<(TEntity, TProperty)> ThenIncludee<TEntity, TPreviousProperty, TProperty>(this IEnumerable<(TEntity, TPreviousProperty)> source, Expression<Func<TPreviousProperty, TProperty>> nav) where TEntity : Entity where TPreviousProperty : Entity
//    //{
//    //    return null;
//    //}
//}

//public static class QueryInclude
//{
//    public static IIncludableQueryable<TEntity, TProperty> Include1<TEntity, TProperty>(this IQueryable<TEntity> source, Expression<Func<TEntity, TProperty>> path) where TProperty : class
//    {
//        //var includedSource = QueryableExtensions.Include(source, path);
//        var propertyName = GetPropertyName(path);
//        var s = new IncludableQueryable<TEntity, TProperty>(source, propertyName);
//        return s;
//    }

//    public static IIncludableQueryable<TEntity, TProperty> ThenInclude1<TEntity, TPreviousProperty, TProperty>(
//        this IIncludableQueryable<TEntity, IEnumerable<TPreviousProperty>> source,
//        Expression<Func<TPreviousProperty, TProperty>> navigationPropertyPath)
//        where TEntity : class
//    {
//        var propertyNameChildLambda = GetPropertyName(navigationPropertyPath);
//        if (source.Provider.GetType().Name == "DbQueryProvider")
//        {
//            var s = ((IncludableQueryable<TEntity, ICollection<TPreviousProperty>>)source);
//            var sourceChild = QueryableExtensions.Include(s.IQueryable, $"{s.PropertyName}.{propertyNameChildLambda}");
//            return new IncludableQueryable<TEntity, TProperty>(sourceChild, $"{s.PropertyName}.{propertyNameChildLambda}");
//        }
//        return new IncludableQueryable<TEntity, TProperty>(source, propertyNameChildLambda);
//    }

//    /// <summary>
//    /// Given an expression, extract the listed property name; similar to reflection but with familiar LINQ+lambdas.  Technique @via http://stackoverflow.com/a/16647343/1037948
//    /// </summary>
//    /// <remarks>Cheats and uses the tostring output -- Should consult performance differences</remarks>
//    /// <typeparam name="TModel">the model type to extract property names</typeparam>
//    /// <typeparam name="TValue">the value type of the expected property</typeparam>
//    /// <param name="propertySelector">expression that just selects a model property to be turned into a string</param>
//    /// <param name="delimiter">Expression toString delimiter to split from lambda param</param>
//    /// <param name="endTrim">Sometimes the Expression toString contains a method call, something like "Convert(x)", so we need to strip the closing part from the end</pa ram >
//    /// <returns>indicated property name</returns>
//    private static string GetPropertyName<TModel, TValue>(this Expression<Func<TModel, TValue>> propertySelector, char delimiter = '.', char endTrim = ')')
//    {

//        var asString = propertySelector.ToString(); // gives you: "o => o.Whatever"
//        var firstDelim = asString.IndexOf(delimiter); // make sure there is a beginning property indicator; the "." in "o.Whatever" -- this may not be necessary?

//        return firstDelim < 0
//            ? asString
//            : asString.Substring(firstDelim + 1).TrimEnd(endTrim);
//    }
//}
//public class IncludableQueryable<TEntity, TProperty> : IIncludableQueryable<TEntity, TProperty>
//{
//    private readonly IQueryable<TEntity> _queryable;
//    internal IQueryable<TEntity> IQueryable => _queryable;
//    public IncludableQueryable(IQueryable<TEntity> queryable, string propertyName)
//    {
//        _queryable = queryable;
//        PropertyName = propertyName;
//    }
//    public IncludableQueryable<TEntity, TProperty> Parent { get; set; }
//    public string PropertyName { get; set; }
//    public Expression Expression => _queryable.Expression;
//    public Type ElementType => _queryable.ElementType;
//    public IQueryProvider Provider => _queryable.Provider;

//    public IEnumerator<TEntity> GetEnumerator() => _queryable.GetEnumerator();

//    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
//}

//public interface IIncludableQueryable<out TEntity, out TProperty> : IQueryable<TEntity>
//{
//}
