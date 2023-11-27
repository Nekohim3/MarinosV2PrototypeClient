using System.Collections.Generic;
using System.Linq;
using MarinosV2PrototypeShared.BaseModels;

namespace MarinosV2PrototypeClient.Utils
{
    public static class TreeExtension
    {
        public static ICollection<T> GetTreeFromList<T>(this ICollection<T> list) where T : TreeEntity<T>
        {
            var topList = list.Where(_ => !_.IdParent.HasValue).ToList();
            GetTreeFromListRecur(list, topList);
            return topList;
        }

        private static void GetTreeFromListRecur<T>(ICollection<T> allList, T item) where T : TreeEntity<T>
        {
            item.Childs.AddRange(allList.Where(_ => _.IdParent.HasValue && _.IdParent.Value == item.Id));
            foreach (var x in item.Childs)
                GetTreeFromListRecur<T>(allList, x);
        }

        private static void GetTreeFromListRecur<T>(ICollection<T> allList, ICollection<T> items) where T : TreeEntity<T>
        {
            foreach (var x in items)
            {
                x.Childs.AddRange(allList.Where(_ => _.IdParent.HasValue && _.IdParent.Value == x.Id));
                GetTreeFromListRecur(allList, x.Childs);
            }
        }
    }

    public static class CollectionExtension
    {
        public static void AddRange<T>(this ICollection<T> col, IEnumerable<T> toAdd)
        {
            foreach (var x in toAdd)
                col.Add(x);
        }
    }
}
