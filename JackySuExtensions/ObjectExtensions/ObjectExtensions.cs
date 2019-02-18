using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace JackySuExtensions.ObjectExtensions
{
    public static class ObjectExtensions
    {
        public static object GetValue(this object instance, string path)
        {
            //maybe [ "a2", "b1", "1]", "3]", "c1" ]
            var pathSplitStr = path.Split(new char[] { '.', '[' });
            Type type = instance.GetType();
            PropertyInfo propInfo;
            foreach (var str in pathSplitStr)
            {
                if (str.Contains("]"))
                {
                    int index;
                    if (int.TryParse(str.Replace("]", ""), out index))
                    {
                        var elementType = type.GetElementType();
                        if (elementType == null)
                            throw new ArgumentException("Properties path is not correct");
                        var array = instance as Array;
                        if (array == null)
                            throw new ArgumentException("Properties path is not correct");
                        instance = array.GetValue(index);
                        type = elementType;
                    }
                    else
                    {
                        throw new Exception("Currently getting values in Array does not yet support using types other than int");
                    }
                }
                else
                {
                    propInfo = type.GetProperty(str);
                    if (propInfo != null)
                    {
                        instance = propInfo.GetValue(instance);
                        type = propInfo.PropertyType;
                    }
                    else throw new ArgumentException("Properties path is not correct");
                }
            }
            return instance;
        }
        public static void SetValue(this object instance, string path, object value)
        {
            //maybe [ "a2", "b1", "1]", "3]", "c1" ]
            var pathSplitStr = path.Split(new char[] { '.', '[' });
            Type type = instance.GetType();
            PropertyInfo propInfo;
            var lastIndex = pathSplitStr.Length - 1;
            for (int i = 0; i < pathSplitStr.Length; i++)
            {
                if (i == lastIndex)
                {
                    if (pathSplitStr[i].Contains("]"))
                    {
                        int index;
                        if (int.TryParse(pathSplitStr[i].Replace("]", ""), out index))
                        {
                            var elementType = type.GetElementType();
                            if (elementType == null)
                                throw new ArgumentException("Properties path is not correct");
                            var array = instance as Array;
                            if (array == null)
                                throw new ArgumentException("Properties path is not correct");
                            array.SetValue(Convert.ChangeType(value, elementType), index);
                        }
                        else
                        {
                            throw new Exception("Currently getting values in Array does not yet support using types other than int");
                        }
                    }
                    else
                    {
                        propInfo = type.GetProperty(pathSplitStr[i]);
                        if (propInfo != null)
                        {
                            propInfo.SetValue(instance, Convert.ChangeType(value, propInfo.PropertyType));
                        }
                        else throw new ArgumentException("Properties path is not correct");
                    }
                }
                else
                {
                    if (pathSplitStr[i].Contains("]"))
                    {
                        int index;
                        if (int.TryParse(pathSplitStr[i].Replace("]", ""), out index))
                        {
                            var elementType = type.GetElementType();
                            if (elementType == null)
                                throw new ArgumentException("Properties path is not correct");
                            var array = instance as Array;
                            if (array == null)
                                throw new ArgumentException("Properties path is not correct");
                            instance = array.GetValue(index);
                            if (instance == null)
                            {
                                //instance = Activator.CreateInstance(propInfo.PropertyType);
                            }
                            type = elementType;
                        }
                        else
                        {
                            throw new Exception("Currently getting values in Array does not yet support using types other than int");
                        }
                    }
                    else
                    {
                        propInfo = type.GetProperty(pathSplitStr[i]);
                        if (propInfo != null)
                        {
                            instance = propInfo.GetValue(instance);
                            if (instance == null)
                            {
                                instance = Activator.CreateInstance(propInfo.PropertyType);
                            }
                            type = propInfo.PropertyType;
                        }
                        else throw new ArgumentException("Properties path is not correct");
                    }
                }
            }
        }
    }
}
