# JackySuExtensions
[![NuGet version (JackySuExtensions)](https://img.shields.io/nuget/v/JackySuExtensions.svg?style=flat-square)](https://www.nuget.org/packages/JackySuExtensions/)
![Publish Status](https://github.com/twjackysu/JackySuExtensions/actions/workflows/nuget-publish.yml/badge.svg)

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

---
You can simply encrypt and decrypt string or byte with a key. (Symmetric encryption)
```csharp
using JackySuExtensions.StringExtensions;
```

try this and see how to write this code
```csharp
var myData = "This is confidential data.";
var key = "#248GGVNvMvz";
var protectedValue = myData.Encrypt(key);
var unprotectedValue = protectedValue.Decrypt(key);
var protectedValueStr =  Convert.ToBase64String(protectedValue);
Console.WriteLine(protectedValueStr);
Console.WriteLine(unprotectedValue);
```

---
A quick way to encrypt specific fields in appsettings.json for .NET Core
```csharp
using JackySuExtensions.IConfigurationBuilderExtensions;
```
In fact, this refers to the practice on the Internet and makes some modifications to make it easier to use on .NET Core, and has not done a complete security assessment. Sometimes security and convenience are mutually exclusive, please choose the best a way that suits your convenience and part of the security.

Which article to refer to has also been commented in the code.

 ## Getting Started

Assuming your appsettings.json is as follows
```json
{
    "SomeApi": {
        "EndPoint": "https://fakeapi.com/resource",
        "Secret": "yourSecret"
    },
    "SomeOtherSetting": "Some text that doesn't need to be encrypted",
    "DBConnection": "Server=YourSQLServer;Database=YourDB;Persist Security Info=True;User ID=YourUser;Password=YourPassword;"
}
```
And you originally used AddJsonFile
```C#
new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
```
Now, use CipherLib
```C#
using JackySuExtensions.IConfigurationBuilderExtensions;
```
Since a password is used for symmetric encryption, please use a safe way to obtain your password.
```C#
var password = GetPasswordFromEnvironmentVariable();
//or
var password = GetPasswordFromFile();
//or
var password = GetPasswordFromSomewhere();
```
Use AddProtectedJsonFile instead of AddJsonFile, and please add regular expressions to indicate which fields need to be encrypted.
```C#
new ConfigurationBuilder()
.AddProtectedJsonFile(
    password,
    "appsettings.json", 
    optional: false,
    reloadOnChange: true, 
    new Regex("SomeApi:Secret"), 
    new Regex("DBConnection"))
```
Build your program. If the fields in your appsettings.json have not been encrypted, the fields in the build folder will be encrypted. If the fields have been encrypted, they will not be encrypted again.

This is adapted from another project of mine to JackySuExtensions [CipherLib](https://github.com/TWKuanLun/CipherLib)
