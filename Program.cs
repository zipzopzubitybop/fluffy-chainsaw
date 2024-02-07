using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Usage: dotnet run <file.csv>");
            return;
        }

        string filePath = args[0];
        try
        {
            using (var reader = new StreamReader(filePath))
            {
                var lines = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    lines.Add($"array({string.Join(", ", Array.ConvertAll(values, v => $"\"{v}\""))})");
                }
                Console.WriteLine($"$array = array(\n    {string.Join(",\n    ", lines)}\n);");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error processing file: {ex.Message}");
        }
    }
}
