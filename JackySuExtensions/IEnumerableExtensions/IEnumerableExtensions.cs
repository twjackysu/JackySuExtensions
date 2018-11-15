using System;
using System.Collections.Generic;

namespace JackySuExtensions.IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// 找到內部屬性最大值的第一個項目
        /// </summary>
        public static T FindFirstMaxPropertyItem<T, TProperty>(this IEnumerable<T> source, Func<T, TProperty> selector) where TProperty : IComparable<TProperty>
        {
            T maxObject = default(T);
            TProperty max = default(TProperty);
            foreach (var item in source)
            {
                if (selector(item).CompareTo(max) > 0)
                {
                    max = selector(item);
                    maxObject = item;
                }
            }
            return maxObject;
        }
        /// <summary>
        /// 找到內部屬性最大值的全部項目
        /// </summary>
        public static IEnumerable<T> FindMaxPropertyItems<T, TProperty>(this IEnumerable<T> source, Func<T, TProperty> selector) where TProperty : IComparable<TProperty>
        {
            var max = default(TProperty);
            var maxPropertyItems = new List<T>();
            foreach (var item in source)
            {
                var property = selector(item);
                var compareResult = property.CompareTo(max);
                if (compareResult > 0)
                {
                    maxPropertyItems.Clear();
                    max = property;
                    maxPropertyItems.Add(item);
                }
                else if(compareResult == 0)
                {
                    maxPropertyItems.Add(item);
                }
            }
            foreach (var item in maxPropertyItems)
            {
                yield return item;
            }
        }
    }
}
