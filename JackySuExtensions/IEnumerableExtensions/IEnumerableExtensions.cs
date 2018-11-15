using System;
using System.Collections.Generic;

namespace JackySuExtensions.IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// 找到內部屬性最大值的第一個項目
        /// </summary>
        public static T FindFirstMaxPropertyItem<T, TResult>(this IEnumerable<T> source, Func<T, TResult> selector) where TResult : IComparable<TResult>
        {
            T maxObject = default(T);
            TResult max = default(TResult);
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
        public static IEnumerable<T> FindMaxPropertyItems<T, TResult>(this IEnumerable<T> source, Func<T, TResult> selector) where TResult : IComparable<TResult>
        {
            TResult max = default(TResult);
            foreach (var item in source)
            {
                if (selector(item).CompareTo(max) > 0)
                    max = selector(item);
            }
            foreach (var item in source)
            {
                if (selector(item).CompareTo(max) == 0)
                    yield return item;
            }
        }
    }
}
