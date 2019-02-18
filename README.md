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
var yourList = new List<string>() { "12345", "123", "01234", "01", "34" };
// will get "12345"
var firstMaxLenItem = yourList.FindFirstMaxPropertyItem(x => x.Length);
// will get ["12345", "01234"]
var MaxLenItems = yourList.FindMaxPropertyItems(x => x.Length).ToArray();
```