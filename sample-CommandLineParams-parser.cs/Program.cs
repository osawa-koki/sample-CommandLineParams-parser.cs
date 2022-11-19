using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.AddCommandLine(args);

var config = builder.Build();

Console.WriteLine($"Key1: '{config["Key1"]}'");
Console.WriteLine($"Key2: '{config["Key2"]}'");
Console.WriteLine($"Key3: '{config["Key3"]}'");
Console.WriteLine($"Key4: '{config["Key4"]}'");
Console.WriteLine($"Key5: '{config["Key5"]}'");
