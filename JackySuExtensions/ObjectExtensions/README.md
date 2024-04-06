[Back](https://github.com/twjackysu/JackySuExtensions/blob/master/README.md)

# ObjectExtensions

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