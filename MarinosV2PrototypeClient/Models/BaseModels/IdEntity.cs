using MarinosV2PrototypeClient.Utils.Tracking;
using Newtonsoft.Json;
using System;

namespace MarinosV2PrototypeClient.Models.BaseModels;

//public abstract class IdEntity : VersionEntity
//{
//    [TrackInclude, JsonProperty]
//    public virtual Guid Id { get; set; } = Guid.NewGuid();

//    public static bool operator !=(IdEntity? a, IdEntity? b)
//    {
//        return !(a == b);
//    }

//    public static bool operator ==(IdEntity? a, IdEntity? b)
//    {
//        if (a is null && b is null)
//            return true;
//        if (a is null || b is null)
//            return false;
//        return a.Equals(b);
//    }

//    public override bool Equals(object? o)
//    {
//        if (o is not IdEntity e)
//            return false;
//        if (e.Id                   == Guid.Empty && Id == Guid.Empty)
//            return e.GetHashCode() == GetHashCode();
//        return e.Id == Id;
//    }
//}