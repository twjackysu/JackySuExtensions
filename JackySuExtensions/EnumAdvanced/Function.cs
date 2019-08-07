using System;
using System.Collections.Generic;
using System.Linq;

namespace JackySuExtensions.EnumAdvanced
{
    class Function
    {
        /// <summary>
        /// 在該Enum內找到有特定Attributes的Value
        /// </summary>
        /// <typeparam name="TEnum">Enum的Type</typeparam>
        /// <typeparam name="TAttribute">Attribute的Type</typeparam>
        /// <param name="GetValueByAttributesFunc"></param>
        /// <returns></returns>
        public TEnum? GetEnumByAttribute<TEnum, TAttribute>(Func<IEnumerable<TAttribute>, bool> GetValueByAttributesFunc)
            where TEnum : struct, Enum
            where TAttribute : Attribute
        {
            return (TEnum?)typeof(TEnum).GetFields()
                .SingleOrDefault(x => GetValueByAttributesFunc(x.GetCustomAttributes(false).OfType<TAttribute>()))?.GetValue(null);
        }
        /// <summary>
        /// 在該Enum內找到有特定Attributes的Values
        /// </summary>
        /// <typeparam name="TEnum">Enum的Type</typeparam>
        /// <typeparam name="TAttribute">Attribute的Type</typeparam>
        /// <param name="GetValueByAttributesFunc"></param>
        /// <returns></returns>
        public IEnumerable<TEnum> GetEnumsByAttribute<TEnum, TAttribute>(Func<IEnumerable<TAttribute>, bool> GetValueByAttributesFunc)
            where TEnum : struct, Enum
            where TAttribute : Attribute
        {
            return typeof(TEnum).GetFields()
                .Where(x => GetValueByAttributesFunc(x.GetCustomAttributes(false).OfType<TAttribute>()))
                .Select(x => (TEnum)x.GetValue(null));
        }
    }
}
