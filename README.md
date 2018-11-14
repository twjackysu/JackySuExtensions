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