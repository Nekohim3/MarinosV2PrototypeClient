using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicData;
using MarinosV2PrototypeClient.Models.BaseModels;

namespace MarinosV2PrototypeClient.Utils
{
    public static class TreeExtension
    {
        public static IList<T> GetTreeFromList<T>(this IList<T> list) where T : TreeEntity<T>
        {
            var topList = list.Where(_ => !_.IdParent.HasValue).ToList();
            GetTreeFromListRecur(list, topList);
            return topList;
        }

        private static void GetTreeFromListRecur<T>(IList<T> allList, T item) where T : TreeEntity<T>
        {
            item.Childs.AddRange(allList.Where(_ => _.IdParent.HasValue && _.IdParent.Value == item.Id));
            foreach (var x in item.Childs)
                GetTreeFromListRecur<T>(allList, x);
        }

        private static void GetTreeFromListRecur<T>(IList<T> allList, IList<T> items) where T : TreeEntity<T>
        {
            foreach (var x in items)
            {
                x.Childs.AddRange(allList.Where(_ => _.IdParent.HasValue && _.IdParent.Value == x.Id));
                GetTreeFromListRecur(allList, x.Childs);
            }
        }
    }
}
