using System;
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
        public TEnum? GetEnumByAttribute<TEnum, TAttribute>(Func<TAttribute[], bool> GetValueByAttributesFunc)
            where TEnum : struct, Enum
            where TAttribute : Attribute
        {
            return (TEnum?)typeof(TEnum).GetFields()
                .SingleOrDefault(x => GetValueByAttributesFunc((TAttribute[])x.GetCustomAttributes(typeof(TAttribute), false)))?.GetValue(null);
        }
    }
}
