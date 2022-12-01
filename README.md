# sample-CommandLineParams-parser.cs

C#でコマンドライン引数を解析するサンプルプロジェクト。  
代わりに[Microsoft.Extensions.Configuration.CommandLine](https://www.nuget.org/packages/Microsoft.Extensions.Configuration.CommandLine)を使用する。  

## 説明

特になし。  
非常に簡単に使える。  

```cs
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.AddCommandLine(args);

var config = builder.Build();

Console.WriteLine($"Key1: '{config["Key1"]}'");
Console.WriteLine($"Key2: '{config["Key2"]}'");
Console.WriteLine($"Key3: '{config["Key3"]}'");
Console.WriteLine($"Key4: '{config["Key4"]}'");
Console.WriteLine($"Key5: '{config["Key5"]}'");
```

## 補足

[Microsoft.Extensions.CommandLineUtils](https://www.nuget.org/packages/Microsoft.Extensions.CommandLineUtils)は既に非推奨。  

## 参考文献

- <https://learn.microsoft.com/ja-jp/dotnet/api/microsoft.extensions.configuration.commandlineconfigurationextensions.addcommandline?view=dotnet-plat-ext-7.0>
