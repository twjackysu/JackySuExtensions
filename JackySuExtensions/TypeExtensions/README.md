Do you want to check if a type implements a generic interface?

```csharp
using JackySuExtensions.TypeExtensions;
```

then
```csharp
bool isImplementIEquatable = typeof(YourClass).IsImplementGenericInterface(typeof(IEquatable<>));
```