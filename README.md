# JackySuExtensions
MyExtensions

Do you want to compare two objects equal?

try this

```csharp
using JackySuExtensions.GenericExtensions;
```

then
```csharp
bool isEqual = yourObject1.EqualsExt(yourObject2);
```
---
Do you want to check if a type implements a generic interface?

```csharp
using JackySuExtensions.TypeExtensions;
```

then
```csharp
bool isImplementIEquatable = typeof(YourClass).IsImplementGenericInterface(typeof(IEquatable<>));
```
---
You can get the item with the max property from any object that has IEnumerable implementation.
```csharp
using JackySuExtensions.IEnumerableExtensions;
```

try
```csharp
var yourList = new List<string>() { "12345", "123", "01234", "01", "34" };
// will get "12345"
var firstMaxLenItem = yourList.FindFirstMaxPropertyItem(x => x.Length);
// will get ["12345", "01234"]
var MaxLenItems = yourList.FindMaxPropertyItems(x => x.Length).ToArray();

// will get "01"
var firstMaxLenItem = yourList.FindFirstMinPropertyItem(x => x.Length);
// will get ["01", "34"]
var MaxLenItems = yourList.FindMinPropertyItems(x => x.Length).ToArray();
```

---
You can get or set property from an object by a string path.
```csharp
using JackySuExtensions.ObjectExtensions;
```

try this and see how to write this code
```csharp
//Get yourObject.a1[0].b1[1].c1 value
Console.WriteLine(yourObject.GetValue("a1[0].b1[1].c1"));
//Set yourObject.a1[0].b1[1].c1 to "WTF"
yourObject.SetValue("a1[0].b1[1].c1", "WTF");
```